using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Web.ModelBinding;
using System.Windows.Forms;
using System.IO;

namespace LockWord.Views
{
    public partial class FrmCreationCards : Form
    {
        private bool isVisualDesigneShow = true;
        private bool isDebitCard = true;

        Color activated = Color.FromArgb(255, 61, 56);
        Color normal = Color.White;

        Color colorCard = Color.Crimson;

        public static String rutaBD = Path.Combine(Application.StartupPath, "DataBase\\LocalWord.sqlite");
        SQLiteHelper sqlh = new SQLiteHelper(rutaBD);

        public FrmCreationCards()
        {
            InitializeComponent();

            PnlCreditCardView.Visible = false;
            // Ajustar el tamaño del formulario al ancho del primer panel
            int newFormWidth = this.Width - PnlCreditCardView.Width;
            this.Size = new Size(newFormWidth, this.Height);
            // Forzar la actualización de los componentes de la ventana
            this.Invalidate();
            isVisualDesigneShow = false;
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

        private void BtnLeftRightSliderCredit1_Click(object sender, EventArgs e)
        {
            this.ResizeRedraw = true;

            if (isVisualDesigneShow)
            {
                PnlCreditCardView.Visible = false;

                // Ajustar el tamaño del formulario al ancho del primer panel
                int newFormWidth = this.Width - PnlCreditCardView.Width;
                this.Size = new Size(newFormWidth, this.Height);

                // Forzar la actualización de los componentes de la ventana
                this.Invalidate();
                isVisualDesigneShow = false;
                resizeConponents();

                //repositionObject(LblAddNewCard);
            }
            else
            {
                PnlCreditCardView.Visible = true;

                // Ajustar el tamaño del formulario al ancho del primer panel
                int newFormWidth = this.Width + PnlCreditCardView.Width;
                this.Size = new Size(newFormWidth, this.Height);

                // Forzar la actualización de los componentes de la ventana
                this.Invalidate();
                isVisualDesigneShow = true;

                

                resizeConponents();
            }

            this.StartPosition = FormStartPosition.CenterParent;
        }

        private void resizeConponents()
        {
            if (PnlCreditCardView.Visible)
            {
                BtnUndo.Visible = true;
                BtnCreate.Visible = true;
                BtnCancel.Visible = true;
                PnlMinOptions.Visible = false;  
            }
            else
            {
                BtnUndo.Visible = false;
                BtnCreate.Visible = false;
                BtnCancel.Visible = false;
                PnlMinOptions.Visible = true;
            }


        }

        private void repositionObject()
        {
            if (PnlCreditCardView.Visible)
            {
                BtnUndo.Text = "Undo";
                BtnUndo.Size = new Size(196, BtnUndo.Size.Height);
                BtnUndo.Padding = new Padding(3,0,0,0); 

                BtnCreate.Text = "Create";
                BtnCreate.Size = new Size(196, BtnUndo.Size.Height);
                BtnCreate.Padding = new Padding(3, 0, 0, 0);

                BtnCancel.Text = "Cancel";
                BtnCancel.Size = new Size(196, BtnUndo.Size.Height);
                BtnCancel.Padding = new Padding(3, 0, 0, 0);
            }
            else
            {
                BtnUndo.Text = string.Empty;
                BtnUndo.Size = new Size(BtnUndo.Size.Height, BtnUndo.Size.Height);
                BtnUndo.Padding = new Padding(0);

                BtnCreate.Text = string.Empty;
                BtnCreate.Size = new Size(BtnUndo.Size.Height, BtnUndo.Size.Height);
                BtnCreate.Padding = new Padding(0);

                BtnCancel.Text = string.Empty;
                BtnCancel.Size = new Size(BtnUndo.Size.Height, BtnUndo.Size.Height);
                BtnCancel.Padding = new Padding(0);
            }
        }



        private void TxtBankNameCredit1_TextChanged(object sender, EventArgs e)
        {
            LblBankNameCreditCard1.Text = TxtBankNameCredit1.Text;
        }

        private void BtnCrossCVCCredit1_Click(object sender, EventArgs e)
        {
            if (TxtCVCCredit1.UseSystemPasswordChar)
            {
                TxtCVCCredit1.UseSystemPasswordChar = false; // Mostrar el texto normalmente
                BtnCrossCVCCredit1.IconChar = FontAwesome.Sharp.IconChar.EyeSlash; // Cambiar el ícono a EyeSlash
            }
            else
            {
                TxtCVCCredit1.UseSystemPasswordChar = true; // Ocultar el texto con un asterisco
                BtnCrossCVCCredit1.IconChar = FontAwesome.Sharp.IconChar.Eye; // Cambiar el ícono a Eye
            }
            cvcDesigne();
        }

        private void TxtCVCCredit1_TextChanged(object sender, EventArgs e)
        {
            cvcDesigne();
        }

        private void cvcDesigne()
        {
            String dataChange = "";
            if (TxtCVCCredit1.UseSystemPasswordChar)
            {
                int i = TxtCVCCredit1.Text.Length;
                for (int x = 0; x < i; x++)
                {
                    dataChange += "*";
                }
                LblCVCCreditCard1.Text = dataChange;
            }
            else
            {
                LblCVCCreditCard1.Text = TxtCVCCredit1.Text;
            }
        }

        private void TxtFullOwnerNameCredit1_TextChanged(object sender, EventArgs e)
        {
            LblFullOwnerNameCreditCard1.Text = TxtFullOwnerNameCredit1.Text;
        }

        private void TxtBankAccountCredit1_TextChanged(object sender, EventArgs e)
        {
            LblBankAccountCreditCard1.Text = TxtBankAccountCredit1.Text;
        }

        private void TxtMounthYearCredit1_TextChanged(object sender, EventArgs e)
        {
            LblMounthCreditCard1.Text = TxtMounthCredit1.Text;
        }

        private void TxtCountryCredit1_TextChanged(object sender, EventArgs e)
        {
            LblCountryCreditCard1.Text = TxtCountryCredit1.Text;
        }
        private void BtnOptionCardsType_Click(object sender, EventArgs e)
        {
            IconButton ib = (IconButton)sender;
            if (ib.Name == "BtnOptionDebitCard")
            {
                isDebitCard = true;
                BtnOptionCreditCard.ForeColor = normal;
                BtnOptionCreditCard.IconColor = normal;
                BtnOptionDebitCard.ForeColor = activated;
                BtnOptionDebitCard.IconColor = activated;
                PctCreditCard1.IconChar = FontAwesome.Sharp.IconChar.C;
            }
            else
            {
                isDebitCard = false;
                BtnOptionCreditCard.ForeColor = activated;
                BtnOptionCreditCard.IconColor = activated;
                BtnOptionDebitCard.ForeColor = normal;
                BtnOptionDebitCard.IconColor = normal;
                PctCreditCard1.IconChar = FontAwesome.Sharp.IconChar.D;
            }
        }

        private void BtnChangeColorCredit1_Click(object sender, EventArgs e)
        {
            Color c = GenerarColorParaTarjetaCredito();
            PnlPreViewDesigneCreditCard1.BackColor = c;
            BtnChangeColorCredit1.IconColor = c;
            colorCard = c;
        }

        private Color GenerarColorParaTarjetaCredito()
        {
            Random rnd = new Random();

            int red = rnd.Next(100, 256); // Componente rojo entre 100 y 255
            int green = rnd.Next(100, 256); // Componente verde entre 100 y 255
            int blue = rnd.Next(100, 256); // Componente azul entre 100 y 255

            return Color.FromArgb(red, green, blue);
        }
        private bool isReadyToInsert()
        {
            bool value = false; 

            if (
                TxtBankNameCredit1.Text != "" ||
                TxtFullOwnerNameCredit1.Text != "" ||
                TxtBankAccountCredit1.Text != "" ||
                TxtMounthCredit1.Text != "" ||
                TxtYearCredit1.Text != "" ||
                TxtCVCCredit1.Text != "" ||
                TxtCountryCredit1.Text != ""
                )
            {
                value = true; // Si algún campo no está vacío, no está listo para insertar
            }

            return value;
        }

        private void BtnCreate_Click(object sender, EventArgs e)
        {
            string bankName = TxtBankNameCredit1.Text;
            string fullOwnerName = TxtFullOwnerNameCredit1.Text;
            string bankAccount = TxtBankAccountCredit1.Text;
            string country = TxtCountryCredit1.Text;
            IconChar typeCardIcon = BtnTypeOfCardCredit1.IconChar;

            int year, month, cvcAccount;

            if (!int.TryParse(TxtYearCredit1.Text, out year) || !int.TryParse(TxtMounthCredit1.Text, out month) || !int.TryParse(TxtCVCCredit1.Text, out cvcAccount))
            {
                MessageBox.Show("Please enter valid numeric values for Year, Month and CVC.");
                return;
            }

            if (isReadyToInsert())
            {
                Card c1 = new Card
                {
                    ID = 0,
                    BankName = bankName,
                    FullOwnerName = fullOwnerName,
                    BankAccount = bankAccount,
                    Month = month,
                    Year = year,
                    CVC = cvcAccount,
                    Country = country,
                    TypeCard = typeCardIcon,
                    IsDebit = isDebitCard,
                    CardColor = colorCard
                };

                sqlh.AddCard(c1);

                MessageBox.Show("Card added successfully.");

                this.Close();
            }
            else
            {
                MessageBox.Show("Please complete all fields.");
            }
        }

        private void TxtYearCredit1_TextChanged(object sender, EventArgs e)
        {
            LblYearCreditCard1.Text = TxtYearCredit1.Text;
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnUndo_Click(object sender, EventArgs e)
        {
            TxtBankNameCredit1.Text = "";
            TxtFullOwnerNameCredit1.Text = "";
            TxtBankAccountCredit1.Text = "";
            TxtMounthCredit1.Text = "";
            TxtYearCredit1.Text = "";
            TxtCVCCredit1.Text = "";
            TxtCountryCredit1.Text = "";

            isDebitCard = true;
            BtnOptionCreditCard.ForeColor = normal;
            BtnOptionCreditCard.IconColor = normal;
            BtnOptionDebitCard.ForeColor = activated;
            BtnOptionDebitCard.IconColor = activated;
            PctCreditCard1.IconChar = FontAwesome.Sharp.IconChar.C;

            PnlPreViewDesigneCreditCard1.BackColor = Color.Crimson;
            BtnChangeColorCredit1.IconColor = Color.Crimson;
        }
    }

}
