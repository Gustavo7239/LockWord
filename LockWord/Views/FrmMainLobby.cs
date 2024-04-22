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

        public FrmMainLobby()
        {
            InitializeComponent();
            //AjustarRegionFormulario();
        }

        private void AjustarRegionFormulario()
        {
            GraphicsPath path = new GraphicsPath();
            int cornerRadius = 15;
            path.AddArc(0, 0, cornerRadius * 2, cornerRadius * 2, 180, 90); // Superior izquierdo
            path.AddArc(this.Width - (cornerRadius * 2), 0, cornerRadius * 2, cornerRadius * 2, 270, 90); // Superior derecho
            path.AddArc(this.Width - (cornerRadius * 2), this.Height - (cornerRadius * 2), cornerRadius * 2, cornerRadius * 2, 0, 90); // Inferior derecho
            path.AddArc(0, this.Height - (cornerRadius * 2), cornerRadius * 2, cornerRadius * 2, 90, 90); // Inferior izquierdo
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


        //Drag Form
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



    }
}
