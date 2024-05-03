using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LockWord.Views
{
    public partial class UCCreditCard : UserControl
    {
        private Card card;

        public UCCreditCard(Card card)
        {
            InitializeComponent();
            this.card = card;
            insertData();
        }

        private void insertData()
        {
            if (card != null)
            {
                if (!string.IsNullOrEmpty(card.BankName))
                    LblBankNameCreditCard1.Text = card.BankName;
                if (!string.IsNullOrEmpty(card.BankAccount))
                    LblBankAccountCreditCard1.Text = card.BankAccount;
                if (!string.IsNullOrEmpty(card.FullOwnerName))
                    LblFullOwnerNameCreditCard1.Text = card.FullOwnerName;
                LblMounthCreditCard1.Text = card.Month.ToString();
                LblYearCreditCard1.Text = card.Year.ToString();
                if (!string.IsNullOrEmpty(card.Country))
                    LblCountryCreditCard1.Text = card.Country;
                changeType();
                PctTypeOfCardCreditCard1.IconChar = card.TypeCard;

                this.BackColor = background();
                LblCVCCreditCard1.BackColor = this.BackColor;

                LblCVCCreditCard1.Text = card.CVC.ToString();
            }
        }

        private Color background()
        {
            // Convertir el valor hexadecimal en un objeto Color
            Color cardColor = Color.Crimson; // Color predeterminado
            if (!string.IsNullOrEmpty(card.CardColor.ToString()))
            {
                try
                {
                    //int argb = int.Parse(card.CardColor.ToString(), System.Globalization.NumberStyles.HexNumber);
                    //cardColor = Color.FromArgb(argb);
                    cardColor = Parse(card.CardColor.ToString());
                    Console.WriteLine(cardColor.ToString());

                    //Color C = (Color)card.CardColor;
                    //cardColor =  C.ToArgb();
                    //cardColor = Color.Black;
                }
                catch (Exception ex)
                {
                    // Manejar cualquier error que pueda ocurrir al convertir el color
                    MessageBox.Show($"Error al convertir el color: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            return cardColor;
        }

        private void changeType()
        {
            if (card.IsDebit)
            {
                PctCreditCard1.IconChar = FontAwesome.Sharp.IconChar.D;
            }
            else
            {
                PctCreditCard1.IconChar = FontAwesome.Sharp.IconChar.C;
            }
        }

        private void BtnCrossCVCCredit1_Click(object sender, EventArgs e)
        {
            if (LblCVCCreditCard1.UseSystemPasswordChar)
            {
                LblCVCCreditCard1.UseSystemPasswordChar = false; // Mostrar el texto normalmente
                BtnCrossCVCCredit1.IconChar = FontAwesome.Sharp.IconChar.EyeSlash; // Cambiar el ícono a EyeSlash
            }
            else
            {
                LblCVCCreditCard1.UseSystemPasswordChar = true; // Ocultar el texto con un asterisco
                BtnCrossCVCCredit1.IconChar = FontAwesome.Sharp.IconChar.Eye; // Cambiar el ícono a Eye
            }
        }

        private Color Parse(string colorString)
        {
            // Remover los caracteres no necesarios
            colorString = colorString.Replace("Color ", "").Replace("[", "").Replace("]", "");

            // Separar los componentes RGB
            string[] components = colorString.Split(new char[] { '=', ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);

            // Convertir los componentes a valores numéricos
            int a = int.Parse(components[1]);
            int r = int.Parse(components[3]);
            int g = int.Parse(components[5]);
            int b = int.Parse(components[7]);

            // Crear y devolver el objeto Color
            return Color.FromArgb(a, r, g, b);
        }
    }
}
