#region using
using System;
using System.Runtime.InteropServices;
using System.Security.Principal;
#endregion using

namespace WinFormsImpersonation
{
    /// <summary>
    /// This class supports impersonating different users in WinForms and 
    /// Console applications. The class maintains state (the impersonation
    /// context), so the instance that is used to initiate the impersonation
    /// (via a call to ImpersonateUser) must be used to revert back to the
    /// original context (via a call to RevertUser).
    /// </summary>
    /// <remarks>
    /// There is a quirk with impersonation in WinForms applications. If the
    /// application loses and regains focus while impersonating a different
    /// user there is a delay of a number of seconds before the UI will respond
    /// to user input. It is highly recommended that impersonation sessions be
    /// kept very short and without user interaction.
    /// </remarks>
    class Impersonator
    {
        #region Enumerations
        public enum SecurityImpersonationLevel : int
        {
            Anonymous = 0,
            Identification = 1,
            Impersonation = 2,
            Delegation = 3
        }
        #endregion Enumerations

        #region Fields
        private const int logon32ProviderDefault = 0;
        private const int logon32LogonInteractive = 2;

        // Maintains the state of the impersonation context; this is needed
        // to revert the process back to the original user
        WindowsImpersonationContext impersonationContext;
        #endregion Fields

        #region External Methods
        [DllImport( "advapi32.dll" )]
        private static extern bool LogonUserA(
            string userName,
            string domain,
            string password,
            int logonType,
            int logonProvider,
            ref IntPtr token );

        [DllImport( "advapi32.dll", CharSet = CharSet.Auto, SetLastError = true )]
        private static extern int DuplicateToken( IntPtr token, int impersonationLevel, ref IntPtr newToken );

        [DllImport( "advapi32.dll", CharSet = CharSet.Auto, SetLastError = true )]
        private static extern bool RevertToSelf();

        [DllImport( "kernel32.dll", CharSet = CharSet.Auto )]
        private static extern bool CloseHandle( IntPtr handle );
        #endregion External Methods

        #region Public Methods
        /// <summary>
        /// Begin impersonating a different user.
        /// </summary>
        /// <param name="domain">
        /// The domain against which the user should be authenticated. This can 
        /// be the machine name if username represents a local machine account.
        /// </param>
        /// <param name="username">
        /// Name of the user to impersonate.
        /// </param>
        /// <param name="password">
        /// Password for the username.
        /// </param>
        /// <returns>
        /// true if impersonation succeeds; false otherwise.
        /// </returns>
        public bool ImpersonateUser( string domain, string username, string password )
        {
            WindowsIdentity windowsIdentity;
            IntPtr token = IntPtr.Zero;
            IntPtr tokenDuplicate = IntPtr.Zero;
            bool success = false;

            // First make sure we're not already impersonating
            if( RevertToSelf() )
            {
                // Log on using the supplied user credentials
                bool loggedIn = LogonUserA( username, domain, password, logon32LogonInteractive, logon32ProviderDefault, ref token );

                if( loggedIn )
                {
                    // Create a copy of the login token
                    if( DuplicateToken( token, (int)SecurityImpersonationLevel.Impersonation, ref tokenDuplicate ) != 0 )
                    {
                        // Begin impersonating the new user
                        windowsIdentity = new WindowsIdentity( tokenDuplicate );

                        impersonationContext = windowsIdentity.Impersonate();

                        if( impersonationContext != null )
                        {
                            success = true;
                        }
                    }
                }
            }

            if( token != IntPtr.Zero )
            {
                CloseHandle( token );
            }

            if( tokenDuplicate != IntPtr.Zero )
            {
                CloseHandle( tokenDuplicate );
            }

            return success;
        }

        /// <summary>
        /// Undo a previous ImpersonateUser request. This sets the identity 
        /// back to the original.
        /// </summary>
        public void RevertUser()
        {
            impersonationContext.Undo();
        }
        #endregion Public Methods
    }
}
