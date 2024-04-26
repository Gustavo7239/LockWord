using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Card
{
    public int ID { get; set; }
    public string BankName { get; set; }
    public string FullOwnerName { get; set; }
    public string BankAccount { get; set; }
    public string Date { get; set; }
    public int CVC { get; set; }
    public string Country { get; set; }
    public string TypeCard { get; set; }
    public bool IsDebit { get; set; }
    public string CardColor { get; set; }
}