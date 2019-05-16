using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp20
{


    public partial class Form1 : Form
    {
        int money = 10000;
        int CoinUpgrade = 0;
        int CoinCost = 10;
        int DollarUpgrade = 0;
        int DollarCost = 100;
        int MBupgrade = 0;
        int MBCost = 500;

        public Form1()
        {
            InitializeComponent();
          
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
        }
        private void button2_Click(object sender, EventArgs e)
        {

            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
                      
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void timer3_Tick(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {


            money += 1 + CoinUpgrade;
            label1.Text = "Money : " + money;

            
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (money >= CoinCost)
            {
                CoinUpgrade += 1;
                money = money - CoinCost;
                label1.Text = "Money : " + money;
                CoinCost += 15;
                label4.Text = "Money per click :" + (CoinUpgrade + 1);
                

            }
            else
            {
                button2.Text = "Not enough money";
            }
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            label2.Text = "Money per second :" + (MBupgrade + DollarUpgrade);

            if (money >= CoinCost)
            {
                button2.BackColor = Color.Green;
            }
            else
            {
                button2.BackColor = Color.Red;
            }
            if (money >= DollarCost)
            {
                button3.BackColor = Color.Green;
            }
            else
            {
                button3.BackColor = Color.Red;
            }
            if (money >= MBCost)
            {
                button4.BackColor = Color.Green;
            }
            else
            {
                button4.BackColor = Color.Red;
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            if (money >= DollarCost)
            {
                DollarUpgrade += 1;
                money = money - DollarCost;
                label1.Text = "Money : " + money;
                DollarCost += 150;
                button3.Text = "Dollar :" + DollarCost;


            }
            else
            {
                button3.Text = "Not enough money";
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            button2.Text = "Coin :" + CoinCost + " $";
            button3.Text = "Dollar :" + DollarCost + " $";
            button4.Text = "Money Bag :" + MBCost + " $";

            money = money + DollarUpgrade + MBupgrade;
                  
            label1.Text = "Money : " + money;
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            button14.Enabled = true;
            button14.Visible = true;

            button15.Enabled = true;
            button15.Visible = true;

            Random location = new Random();
            int randomLocation = location.Next(0,986);
            button14.Location = new Point (randomLocation,0);
            button15.Location = new Point(randomLocation, 0);
        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            
            button14.Top += 25;
            if (button14.Top > 548)
            {
                button14.Visible = false;
                button14.Enabled = false;                              
            } 
            
            
        }

        private void button14_Click(object sender, EventArgs e)
        {
            
            money += 500;
            button14.Visible = false;
            button14.Enabled = false;
            label1.Text = "Money : " + money;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            

            if (money >= MBCost)
            {
                MBupgrade += 5;
                money = money - MBCost;
                label1.Text = "Money : " + money;
                
                MBCost += 350;
                button4.Text = "Money Bag :" + MBCost;


            }
            else
            {
                button4.Text = "Not enough money";
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {

        }
    }
}
