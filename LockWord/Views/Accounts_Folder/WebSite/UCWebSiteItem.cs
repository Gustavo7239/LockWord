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
    public partial class UCWebSiteItem : UserControl
    {
        private WebSite webSite;
        private string IMAGES_PATH = Path.Combine(Application.StartupPath, "Images");

        public UCWebSiteItem(WebSite webSite)
        {
            InitializeComponent();
            this.webSite = webSite;
            insertData();
        }

        private void insertData()
        {
            LblNameWebSite.Text = webSite.WebName;
            PctPhotoWebSite.ImageLocation = Path.Combine(IMAGES_PATH, webSite.ImageName);

            addTooltip(PctPhotoWebSite, webSite.Description);
           
            addTooltip(BtnChangeColorTxt, "Change font color");
            addTooltip(BtnChangeColorBackground, "Change background color");
            addTooltip(BtnAddAccount, "Add new account");

        }

        private void addTooltip(Control c, string message)
        {
            ToolTip tooltip = new ToolTip();
            tooltip.SetToolTip(c, message);
        }

        private void BtnAddAccount_Click(object sender, EventArgs e)
        {
            FrmCreationAccountsMenu fca = new FrmCreationAccountsMenu(webSite);
            DialogResult result = fca.ShowDialog();
        }
    }
}
