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
    public partial class FrmCreditCardsMenu : Form
    {
        public FrmCreditCardsMenu()
        {
            InitializeComponent();
        }

        private void BtnAddBankAccounts_Click(object sender, EventArgs e)
        {
            FrmCreationCards fcc = new FrmCreationCards();

            // Mostrar el formulario hijo como un cuadro de diálogo modal
            DialogResult result = fcc.ShowDialog();
        }
    }
}
