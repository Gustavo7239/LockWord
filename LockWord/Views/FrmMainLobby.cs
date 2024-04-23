using FontAwesome.Sharp;
using LockWord.Views;
using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LockWord
{
    public partial class FrmMainLobby : Form
    {
        //Fonts
        System.Drawing.Text.PrivateFontCollection privateFonts = new System.Drawing.Text.PrivateFontCollection();
        System.Drawing.Font font;
        
        public List<IconButton> FunctionButtons = new List<IconButton>();

        public FrmMainLobby()
        {
            InitializeComponent();
            InitializeButtons();

            //Button selected default
            OperChildForm(new FrmAnalyticsMenu());
            UpdateChildFormSize();
            selectedButton(BtnAnalytics);
        }

        private void FrmMainLobby_SizeChanged(object sender, EventArgs e)
        {
            UpdateChildFormSize();
        }

        private void UpdateChildFormSize()
        {
            if (PnlContainer.Controls.Count > 0 && PnlContainer.Controls[0] is Form childForm)
            {
                OperChildForm(childForm);
            }
        }
        public void InitializeButtons()
        {
            FunctionButtons.Add(BtnAnalytics);
            FunctionButtons.Add(BtnAccounts);
            FunctionButtons.Add(BtnCreditCards);
            FunctionButtons.Add(BtnLwMessages);
            FunctionButtons.Add(BtnPasswordGen);
        }

        private void AjustarRegionFormulario()
        {
            GraphicsPath path = new GraphicsPath();
            int cornerRadius = 15;
            path.AddArc(0, 0, cornerRadius * 2, cornerRadius * 2, 180, 90);
            path.AddArc(this.Width - (cornerRadius * 2), 0, cornerRadius * 2, cornerRadius * 2, 270, 90);
            path.AddArc(this.Width - (cornerRadius * 2), this.Height - (cornerRadius * 2), cornerRadius * 2, cornerRadius * 2, 0, 90);
            path.AddArc(0, this.Height - (cornerRadius * 2), cornerRadius * 2, cornerRadius * 2, 90, 90);
            this.Region = new Region(path);
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
            else if (bt.Name == "BtnMaximize")
            {
                MaximizeParentForm();
            }
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private static extern void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private static extern void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        public void MaximizeParentForm()
        {
            Form parentForm = this.FindForm();
            if (parentForm != null)
            {
                parentForm.WindowState = FormWindowState.Maximized;
            }
        }

        private void OperChildForm(Object ChildForm)
        {
            if (this.PnlContainer.Controls.Count > 0)
                this.PnlContainer.Controls.RemoveAt(0);

            Form fh = ChildForm as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.PnlContainer.Controls.Add(fh);
            this.PnlContainer.Tag = fh;
            fh.Show();
        }

        private void BtnAccounts_Click(object sender, EventArgs e)
        {
            OperChildForm(new AcountsTreeMenu());
            UpdateChildFormSize();
            selectedButton(BtnAccounts);
        }

        private void BtnPasswordGen_Click(object sender, EventArgs e)
        {
            OperChildForm(new PasswordGeneratorMenu());
            UpdateChildFormSize();
            selectedButton(BtnPasswordGen);
        }

        private void BtnAnalytics_Click(object sender, EventArgs e)
        {
            OperChildForm(new FrmAnalyticsMenu());
            UpdateChildFormSize();
            selectedButton(BtnAnalytics);
        }

        private void BtnCreditCards_Click(object sender, EventArgs e)
        {
            OperChildForm(new FrmCreditCardsMenu());
            UpdateChildFormSize();
            selectedButton(BtnCreditCards);
        }

        private void BtnLwMessages_Click(object sender, EventArgs e)
        {
            OperChildForm(new FrmLwMessagesMenu());
            UpdateChildFormSize();
            selectedButton(BtnLwMessages);
        }

        private void selectedButton(object sender)
        {
            IconButton btn = (IconButton) sender;

            Color activated = Color.FromArgb(255, 61, 56);
            Color normal = Color.White;

            foreach (IconButton iBtn in FunctionButtons)
            {
                if (iBtn.Name == btn.Name)
                {
                    btn.ForeColor = activated;
                    btn.IconColor = activated;
                }
                else
                {
                    iBtn.ForeColor = normal;
                    iBtn.IconColor = normal;
                }
                
            }
        }


    }
}
