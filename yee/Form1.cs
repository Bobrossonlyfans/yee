using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace yee
{
   

    public partial class Form1 : Form
    {
        double total;
        double cheesePrice = 1.50;
        double pepperoniPrice = 2.00;
        double canadianPrice = 2.50;
        double cheesetot = 0;
        double pepperoniTot = 0;
        double canadianTot = 0;
        double totalcost = 0;
        double taxrate = 0.13;
        double taxtot = 0;
        double grandtotal = 0;

        int cheeseNum = 0;
        int pepperoniNum = 0;
        int canaidanNum = 0;
        public Form1()
        {
            InitializeComponent();
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            cheeseNum = Convert.ToInt32(cheeseInput.Text);
            pepperoniNum = Convert.ToInt32(peppInput.Text);
            canaidanNum = Convert.ToInt32(cadInput.Text);


            cheesetot = cheesePrice * cheeseNum;
            pepperoniTot = pepperoniPrice * pepperoniNum;
            canadianTot = canadianPrice * pepperoniNum;
            totalcost = cheesetot + pepperoniTot + canadianTot;

            label9.Text = $"{totalcost}";
            taxtot = totalcost * taxrate;
            grandtotal = taxtot + totalcost;
            label14.Text = $"{taxtot}";
            label16.Text = $"{grandtotal}";
        
        
        
        
        
        
        
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
