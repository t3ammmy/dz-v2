using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace WindowsFormsApp14
{
    public partial class Form1 : Form
    {
        int monsterHp2 = 50;

        int monsterHp = 50;

        int gold = 190000;
                      

        int defeated = 0;

        int power = 50;

        int buff = 0;

        int gbuff = 0;

        int level = 1;

        int dmgdone = 0;

        int defeatedall = 0;  
        
        int buff2 = 0;

        int gbuff2 = 100;
             
        int cPs = 0;

        int ar4Price = 100;  // цены
        int sqrPrice = 20;
        int kngPrice = 50;
        int wizPrice = 500;
        int assPrice = 1000;
        int dkPrice = 5000;
        int ncPrice = 10000;
        int godPrice = 50000;
        int rebPrice = 100000;



        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dmgdone += power;                                          // действия при клике                            
            
            label1.Text = "HP " + (monsterHp - (dmgdone - cPs)) + "/" + monsterHp2;
        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            if (gold >= sqrPrice)                                                       // покупка оруженосца
            {
                gold -= sqrPrice;
                power++;
                sqrPrice += 30;
                label7.Text = "Click power \n" + power;
            }
            else
            {
                button2.Text = "Not enough money!";
            }
        }

        private void button2_MouseEnter(object sender, EventArgs e)           // подсказка оруженосец
        {
            label6.Visible = true;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            label6.Visible = false;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            button2.Text = "Squire " + sqrPrice + " G";       // обновление текста

            button4.Text = "Knight " + kngPrice + " G";

            button7.Text = "Archer " + ar4Price + " G";

            button9.Text = "Wizard " + wizPrice + " G";

            button3.Text = "Assassin " + assPrice + " G";

            button5.Text = "Dark Knight " + dkPrice + " G";

            button6.Text = "Necromancer " + ncPrice + " G";

            button8.Text = "God " + godPrice + " G";

            button10.Text = "Reborn " + rebPrice + " G";

            if (monsterHp - dmgdone <= 0)                                                  //убийство монстра
            {
                defeatedall++;
                monsterHp2 = 50 + buff;
                monsterHp = 50 + buff;
                gold += 10 + gbuff;
                defeated++;
                label3.Text = "Gold :" + gold;
                label4.Text = "Monsters defeated: \n" + defeatedall;
                label5.Text = "Level :" + level;
                dmgdone = 0;

            }


            if (defeated == 10)                                        //обновление уровня
            {
                buff += 50;
                gbuff += 20;

                defeated = 0;
                level++;

                buff2 += 150;
                gbuff2 += 100;

                monsterHp = 0;
            }

            monsterHp -= cPs;
            label1.Text = "HP " + (monsterHp - (dmgdone - cPs)) + "/" + monsterHp2;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            label3.Text = "Gold :" + gold;

            label5.Text = "Level :" + level;



            if (gold >= sqrPrice)                           // цвет
            {
                button2.BackColor = Color.Green;
            }
            else
            {
                button2.BackColor = Color.Red;
            }

            

            if (gold >= kngPrice)
            {
                button4.BackColor = Color.Green;
            }
            else
            {
                button4.BackColor = Color.Red;
            }

            if (gold >= ar4Price)
            {
                button7.BackColor = Color.Green;
            }
            else
            {
                button7.BackColor = Color.Red;
            }

            if (gold >= wizPrice)
            {
                button9.BackColor = Color.Green;
            }
            else
            {
                button9.BackColor = Color.Red;
            }


            if (gold >= assPrice)
            {
                button3.BackColor = Color.Green;
            }
            else
            {
                button3.BackColor = Color.Red;
            }


            if (gold >= dkPrice)
            {
                button5.BackColor = Color.Green;
            }
            else
            {
                button5.BackColor = Color.Red;
            }

            if (gold >= ncPrice)
            {
                button6.BackColor = Color.Green;
            }
            else
            {
                button6.BackColor = Color.Red;
            }

            if (gold >= godPrice)
            {
                button8.BackColor = Color.Green;
            }
            else
            {
                button8.BackColor = Color.Red;
            }

            if (gold >= rebPrice)
            {
                button10.BackColor = Color.Green;
            }
            else
            {
                button10.BackColor = Color.Red;
            }


            if (monsterHp - dmgdone <= 0)                                                  //убийство монстра
            {
                defeatedall++;
                monsterHp2 = 50 + buff;
                monsterHp = 50 + buff;
                gold += 10 + gbuff;
                defeated++;
                label3.Text = "Gold :" + gold;
                label4.Text = "Monsters defeated: \n" + defeatedall;
                label5.Text = "Level :" + level;
                dmgdone = 0;

            }


            if (defeated == 10)                                        //обновление уровня
            {
                buff += 50;
                gbuff += 20;

                defeated = 0;
                level++;

                buff2 += 150;
                gbuff2 += 100;

                monsterHp = 0;
            }



        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_MouseEnter(object sender, EventArgs e)
        {
            label9.Visible = true;
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            label9.Visible = false;
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            if (gold >= kngPrice)                                                       // покупка рыцаря
            {
                gold -= kngPrice;
                power += 5;
                kngPrice += 50;
                label7.Text = "Click power \n" + power;
            }
            else
            {
                button4.Text = "Not enough money!";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
           
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            if (gold >= ar4Price)                                                       // покупка лучника
            {
                gold -= ar4Price;
                cPs += 5;
                ar4Price += 100;
                label8.Text = "Damage \n per second \n" + cPs;
            }
            else
            {
                button7.Text = "Not enough money!";
            }
        }

        private void button7_MouseEnter(object sender, EventArgs e)
        {
            label10.Visible = true;
        }

        private void button7_MouseLeave(object sender, EventArgs e)
        {
            label10.Visible = false;
        }

        private void button9_Click(object sender, EventArgs e)
        {
        }

        private void button9_MouseEnter(object sender, EventArgs e)
        {
            label11.Visible = true;
        }

        private void button9_MouseLeave(object sender, EventArgs e)
        {
            label11.Visible = false;
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            if (gold >= wizPrice)                                                       // покупка мага
            {
                gold -= wizPrice;
                cPs += 20;
                wizPrice += 250;
                label8.Text = "Damage \n per second \n" + cPs;
            }
            else
            {
                button9.Text = "Not enough money!";
            }
        }

        private void button7_MouseEnter_1(object sender, EventArgs e)
        {
            label10.Visible = true;
        }

        private void button7_MouseLeave_1(object sender, EventArgs e)
        {
            label10.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (gold >= assPrice)                                                       // покупка убийцы
            {
                gold -= assPrice;
                power += 25;
                assPrice += 500;
                label7.Text = "Click power \n" + power;
            }
            else
            {
                button3.Text = "Not enough money!";
            }
        }

        private void button3_MouseEnter(object sender, EventArgs e)
        {
            label12.Visible = true;
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            label12.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (gold >= dkPrice)                                                       // покупка dk
            {
                gold -= dkPrice;
                power += 50;
                dkPrice += 2500;
                label7.Text = "Click power \n" + power;
            }
            else
            {
                button5.Text = "Not enough money!";
            }
        }

        private void button5_MouseEnter(object sender, EventArgs e)
        {
            label13.Visible = true;
        }

        private void button5_MouseLeave(object sender, EventArgs e)
        {
            label13.Visible = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
        }

        private void button6_MouseEnter(object sender, EventArgs e)
        {
            label14.Visible = true;
        }

        private void button6_MouseLeave(object sender, EventArgs e)
        {
            label14.Visible = false;
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            if (gold >= ncPrice)                                                       // покупка некра
            {
                gold -= ncPrice;
                cPs += 50;
                ncPrice += 250;
                label8.Text = "Damage \n per second \n" + cPs;
            }
            else
            {
                button6.Text = "Not enough money!";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (gold >= godPrice)                                                       // покупка бога
            {
                gold -= godPrice;
                cPs += 100;
                godPrice += 50000;
                label8.Text = "Damage \n per second \n" + cPs;
            }
            else
            {
                button8.Text = "Not enough money!";
            }
        }

        private void button8_MouseLeave(object sender, EventArgs e)
        {
            label15.Visible = false;
        }

        private void button8_MouseEnter(object sender, EventArgs e)
        {
            label15.Visible = true;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (gold >= rebPrice)
            {
                monsterHp2 = 50;

               monsterHp = 50;

                gold = 0;

                defeated = 0;

                power = 1;

                 buff = 0;

                 gbuff = 50;

                 level = 1;

                 dmgdone = 0;

                 defeatedall = 0;


                 cPs = 0;

                 ar4Price = 100;  // цены
                 sqrPrice = 20;
                 kngPrice = 50;
                 wizPrice = 500;
                 assPrice = 1000;
                 dkPrice = 5000;
                 ncPrice = 10000;
                 godPrice = 50000;
                 rebPrice = 100000;


                label7.Text = "Click power \n" + power;
                label8.Text = "Damage \n per second \n" + cPs;
                label3.Text = "Gold :" + gold;
                label4.Text = "Monsters defeated: \n" + defeatedall;
                label5.Text = "Level :" + level;
            }
            else
            {
                button10.Text = "Not enough money";
            }
        }
    }

   



}
