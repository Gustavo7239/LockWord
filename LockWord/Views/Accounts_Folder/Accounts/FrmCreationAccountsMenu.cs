using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media.TextFormatting;

namespace LockWord.Views
{
    public partial class FrmCreationAccountsMenu : Form
    {
        private WebSite webSite;
        public static String rutaBD = Path.Combine(Application.StartupPath, "DataBase\\LocalWord.sqlite");
        public static SQLiteHelper dbHelper = new SQLiteHelper(rutaBD);

        public FrmCreationAccountsMenu(WebSite webSite)
        {
            InitializeComponent();
            this.webSite = webSite;
        }
        private void BtnControlWindowAction_Click(object sender, EventArgs e)
        {
            LWButtonActions bt = (LWButtonActions)sender;
            if (bt.Name == "BtnClose")
            {
                this.Close();
            }
            else if (bt.Name == "BtnMinimize")
            {
                this.WindowState = FormWindowState.Minimized;
            }
        }


        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private static extern void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private static extern void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void PnlHeader_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void BrnCreate_Click(object sender, EventArgs e)
        {
            if (isReadyToInsert())
            {
                string UserName = TxtUsername.Text;
                string Gmail = TxtGmailAccount.Text;
                string Password = TxtPassword.Text;

                Account ac = new Account
                {
                    ID = 0,
                    WebSiteID = webSite.ID,
                    UserName = UserName,
                    Mail = Gmail,
                    Password = Password
                };

                dbHelper.AddAccount(ac);

                MessageBox.Show("Account added successfully.");

                this.Close();
            }
            else
            {
                MessageBox.Show("Please complete all fields.");
            }
        }

        private bool isReadyToInsert()
        {
            bool value = false;

            if (
                TxtUsername.Text != "" ||
                TxtGmailAccount.Text != "" ||
                TxtPassword.Text != ""
                )
            {
                value = true;
            }

            return value;
        }

        private void BtnUndo_Click(object sender, EventArgs e)
        {
            TxtUsername.Text = "";
            TxtGmailAccount.Text = "";
            TxtPassword.Text = "";
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
