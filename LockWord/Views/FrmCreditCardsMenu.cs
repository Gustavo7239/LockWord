using System;
using System.IO;
using System.Windows.Forms;

namespace LockWord.Views
{
    public partial class FrmCreditCardsMenu : Form
    {
        // Database vars
        public static string rutaBD = Path.Combine(Application.StartupPath, "DataBase\\LocalWord.sqlite");
        public static SQLiteHelper dbHelper = new SQLiteHelper(rutaBD);

        public FrmCreditCardsMenu()
        {
            InitializeComponent();
            SeeCards();
        }

        private void BtnAddBankAccounts_Click(object sender, EventArgs e)
        {
            FrmCreationCards fcc = new FrmCreationCards();

            DialogResult result = fcc.ShowDialog();
            SeeCards();
        }

        // Método para mostrar todas las tarjetas en el FlowLayoutPanel
        private void SeeCards()
        {
            FlowPnlCards.Controls.Clear(); 

            foreach (Card card in dbHelper.GetAllCards())
            {
                UCCreditCard frmCreditCard = new UCCreditCard(card);
                FlowPnlCards.Controls.Add(frmCreditCard); 
            }
        }

        private void BtnLeftCards_Click(object sender, EventArgs e)
        {
            FlowPnlCards.AutoScrollPosition = new System.Drawing.Point(FlowPnlCards.HorizontalScroll.Value - 393, 10);
        }

        private void BtnRightCards_Click(object sender, EventArgs e)
        {
            FlowPnlCards.AutoScrollPosition = new System.Drawing.Point(FlowPnlCards.HorizontalScroll.Value + 393, 100);
        }
    }
}
