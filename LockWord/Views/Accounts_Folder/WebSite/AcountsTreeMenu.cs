using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LockWord.Views
{
    public partial class AcountsTreeMenu : Form
    {
        // Database vars
        public static string rutaBD = Path.Combine(Application.StartupPath, "DataBase\\LocalWord.sqlite");
        public static SQLiteHelper dbHelper = new SQLiteHelper(rutaBD);

        public AcountsTreeMenu()
        {
            InitializeComponent();
            SeeWebSites();
        }

        private void BtnAddAccounts_Click(object sender, EventArgs e)
        {
            FrmCreationWebSite fcW = new FrmCreationWebSite();
            DialogResult result = fcW.ShowDialog();
            SeeWebSites();
        }

        private void SeeWebSites()
        {
            FlowPnlWebsites.Controls.Clear();

            foreach (WebSite ws in dbHelper.GetAllWebSites())
            {
                UCWebSiteItem frmCreditCard = new UCWebSiteItem(ws);
                FlowPnlWebsites.Controls.Add(frmCreditCard);
            }
        }
    }
}
