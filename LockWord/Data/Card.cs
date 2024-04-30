using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Card
{
    public int ID { get; set; }
    public string BankName { get; set; }
    public string FullOwnerName { get; set; }
    public string BankAccount { get; set; }
    public int Month { get; set; }
    public int Year { get; set; }
    public int CVC { get; set; }
    public string Country { get; set; }
    public IconChar TypeCard { get; set; }
    public bool IsDebit { get; set; }
    public Color CardColor { get; set; }
}