using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LunchBillCalculatorApp
{
    public partial class LunchBillUI : Form
    {
        public LunchBillUI()
        {
            InitializeComponent();
        }
        public int aRice, bFish, cMeat, rUint = 0, fUnit = 0, mUnit = 0, rUnitPrice = 20, fUnitPrice = 80, mUnitPrice = 100, totalGross;
        private void showTotalButton_Click(object sender, EventArgs e)
        {
          
           
            aRice = Convert.ToInt32(richTextBox.Text);
            bFish = Convert.ToInt32(fishTextBox.Text);
            cMeat = Convert.ToInt32(meatTextBox.Text);
          rUint =   aRice*rUnitPrice;
           fUnit =  bFish*fUnitPrice;
           mUnit = cMeat*mUnitPrice;

            totalGross = rUint + fUnit + mUnit;
            totalGrossTextBox.Text = totalGross.ToString();
            //totalGrossTextBox.Text = string.Empty;
            //MessageBox.Show(Convert.ToString(totalGross));

            ClearTexboxes();

        }

        private void showNetBillButton_Click(object sender, EventArgs e)
        {
            int  netBill,vatAmount;
            int dCount=Convert.ToInt32(discountTextBox.Text);
            vatAmount = (totalGross*5)/100;
            dCount = (totalGross*dCount)/100;
            
            
            
            netBill = (totalGross - dCount) + vatAmount;
            MessageBox.Show(Convert.ToString(netBill));



        }

        public void ClearTexboxes()
        {
            richTextBox.Text = "";
            fishTextBox.Text = "";
            meatTextBox.Text = "";
        }
    }
}
