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

                //this.BackColor = background();

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
                    int argb = int.Parse(card.CardColor.ToString(), System.Globalization.NumberStyles.HexNumber);
                    cardColor = Color.FromArgb(argb);
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
    }
}
