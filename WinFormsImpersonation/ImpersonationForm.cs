#region using
using System;
using System.Security.Principal;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using System.Threading;
#endregion using

namespace WinFormsImpersonation
{
    public partial class ImpersonationForm : Form
    {
        #region Fields
        private Impersonator impersonator = new Impersonator();
        #endregion Fields

        #region Constructors
        public ImpersonationForm()
        {
            InitializeComponent();
        }
        #endregion Constructors

        #region Event Handlers
        private void ImpersonationForm_Load( object sender, EventArgs e )
        {
            ShowCurrentUser();
        }

        private void btnImpersonate_Click( object sender, EventArgs e )
        {
            bool impersonated =
                impersonator.ImpersonateUser( txtDomain.Text, txtUsername.Text, txtPassword.Text );

            if( impersonated )
            {
                ShowCurrentUser();

                btnRevert.Enabled = true;
                btnImpersonate.Enabled = false;
            }
            else
            {
                MessageBox.Show( "Impersonation attempt failed." );
            }
        }

        private void btnRevert_Click( object sender, EventArgs e )
        {
            RevertUser();
        }
        #endregion Event Handlers

        #region Private Methods
        private void ShowCurrentUser()
        {
            lblIdentity.Text = WindowsIdentity.GetCurrent().Name;
        }

        private void RevertUser()
        {
            impersonator.RevertUser();
            ShowCurrentUser();

            btnRevert.Enabled = false;
            btnImpersonate.Enabled = true;
        }

        private void btnExecuteQuery_Click( object sender, EventArgs e )
        {
            SqlConnection connection = null;

            try
            {
                connection = new SqlConnection( "Integrated Security=True;Server=cwagner-desk2;Database=Sample" );
                connection.Open();

                using( SqlCommand command = new SqlCommand( "select * from MenuItem", connection ) )
                {
                    SqlDataAdapter adapter = new SqlDataAdapter( command );

                    DataSet ds = new DataSet();

                    adapter.Fill( ds );

                    Thread.Sleep( 5000 );

                    txtDomain.Text = ds.Tables[0].Rows.Count.ToString();

                    RevertUser();
                }
            }
            catch( Exception ex )
            {
                MessageBox.Show( ex.ToString() );
            }
            finally
            {
                if( connection != null )
                {
                    connection.Close();
                }
            }
        }
        #endregion Private Methods
    }
}
