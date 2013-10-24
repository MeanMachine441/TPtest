using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    
    public partial class Form1 : Form
    {
        int count = 0;
        public Form1()
        {
            InitializeComponent();

            //int count = 0;
            
        }

        /*
        ///////////////////////////BEGIN SHIFTING OBJECTS ////////////////////////////////
        //PICTURE BOX 1
        int x1 = 0;
        int y1 = 0;
        bool drag1 = false;
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        { x1 = e.X; y1 = e.Y; drag1 = true;}

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {if (drag1)
            {
                pictureBox1.Top += e.Y - y1;
                pictureBox1.Left += e.X - x1;
            }
        }
        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            drag1 = false;
        }
        
*/

        //HOVER 1----
        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.Coral; //change color when enter area
        }
        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.Coral; //change color when over area
        }
        bool click1 = false;
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBox1.BackColor = Color.Coral; //if click change background to coral
            if (click1 == false) //if hasn't been clicked then click
            {
                click1 = true;
                count++;
                //label2.Text = (count.ToString());
            }
            else
            {
                click1 = false; //if already clicked once then unselect to return
                count--;
                //label2.Text = (count.ToString());
            }
        }
        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            if (click1 == true)
                pictureBox1.BackColor = Color.Coral; //if click then stay coral
            else
                pictureBox1.BackColor = Color.Transparent; // if not clicked return to transparent

        }

        //HOVER 2---
        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            pictureBox2.BackColor = Color.Coral;
        }
        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            pictureBox2.BackColor = Color.Coral;
        }
        bool click2 = false;
        private void pictureBox2_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBox2.BackColor = Color.Coral;
            if (click2 == false) //if hasn't been clicked then click
            {
                click2 = true;
                count++;
               // label2.Text = (count.ToString());
            }
            else
            {
                click2 = false; //if already clicked once then unselect to return
                count--;
              //  label2.Text = (count.ToString());
            }
        }
        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            if (click2 == true)
                pictureBox2.BackColor = Color.Coral;
            else
                pictureBox2.BackColor = Color.Transparent;
        }


        //HOVER 3 --->
        bool click3 = false;
        private void pictureBox3_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBox3.BackColor = Color.Coral;
            if (click3 == false) //if hasn't been clicked then click
            {
                click3 = true;
                count++;
            }
            else
            {
                click3 = false; //if already clicked once then unselect to return
                count--;
            }
        }

        private void pictureBox3_MouseEnter(object sender, EventArgs e)
        {
            pictureBox3.BackColor = Color.Coral;
        }

        private void pictureBox3_MouseHover(object sender, EventArgs e)
        {
            pictureBox3.BackColor = Color.Coral;
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            if (click3 == true)
                pictureBox3.BackColor = Color.Coral;
            else
                pictureBox3.BackColor = Color.Transparent;
        }

        //------> HOVER 4

        bool click4 = false;
        private void pictureBox4_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBox4.BackColor = Color.Coral;
            if (click4 == false) //if hasn't been clicked then click
            {
                click4 = true;
                count++;
            }
            else
            {
                click4 = false; //if already clicked once then unselect to return
                count--;
            }
        }

        private void pictureBox4_MouseEnter(object sender, EventArgs e)
        {
            pictureBox4.BackColor = Color.Coral;
        }

        private void pictureBox4_MouseHover(object sender, EventArgs e)
        {
            pictureBox4.BackColor = Color.Coral;
        }

        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
            if (click4 == true)
                pictureBox4.BackColor = Color.Coral;
            else
                pictureBox4.BackColor = Color.Transparent;
        }


        //HOVER 5------>

        bool click5 = false;
        private void pictureBox5_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBox5.BackColor = Color.Coral;
            if (click5 == false) //if hasn't been clicked then click
            {
                click5 = true;
                count++;
            }
            else
            {
                click5 = false; //if already clicked once then unselect to return
                count--;
            }
        }

        private void pictureBox5_MouseEnter(object sender, EventArgs e)
        {
            pictureBox5.BackColor = Color.Coral;
        }

        private void pictureBox5_MouseHover(object sender, EventArgs e)
        {
            pictureBox5.BackColor = Color.Coral;
        }

        private void pictureBox5_MouseLeave(object sender, EventArgs e)
        {
            if (click5 == true)
                pictureBox5.BackColor = Color.Coral;
            else
                pictureBox5.BackColor = Color.Transparent;
        }

        //HOVER 6------>

        bool click6 = false;
        private void pictureBox6_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBox6.BackColor = Color.Coral;
            if (click6 == false) //if hasn't been clicked then click
            {
                click6 = true;
                count++;
            }
            else
            {
                click6 = false; //if already clicked once then unselect to return
                count--;
            }
        }

        private void pictureBox6_MouseEnter(object sender, EventArgs e)
        {
            pictureBox6.BackColor = Color.Coral;
        }

        private void pictureBox6_MouseHover(object sender, EventArgs e)
        {
            pictureBox6.BackColor = Color.Coral;
        }

        private void pictureBox6_MouseLeave(object sender, EventArgs e)
        {
            if (click6 == true)
                pictureBox6.BackColor = Color.Coral;
            else
                pictureBox6.BackColor = Color.Transparent;
        }

        //HOVER 7------>

        bool click7 = false;
        private void pictureBox7_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBox7.BackColor = Color.Coral;
            if (click7 == false) //if hasn't been clicked then click
            {
                click7 = true;
                count++;
            }
            else
            {
                click7 = false; //if already clicked once then unselect to return
                count--;
            }
        }

        private void pictureBox7_MouseEnter(object sender, EventArgs e)
        {
            pictureBox7.BackColor = Color.Coral;
        }

        private void pictureBox7_MouseHover(object sender, EventArgs e)
        {
            pictureBox7.BackColor = Color.Coral;
        }

        private void pictureBox7_MouseLeave(object sender, EventArgs e)
        {
            if (click7 == true)
                pictureBox7.BackColor = Color.Coral;
            else
                pictureBox7.BackColor = Color.Transparent;
        }

        //HOVER 8------>

        bool click8 = false;
        private void pictureBox8_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBox8.BackColor = Color.Coral;
            if (click8 == false) //if hasn't been clicked then click
            {
                click8 = true;
                count++;
            }
            else
            {
                click8 = false; //if already clicked once then unselect to return
                count--;
            }
        }

        private void pictureBox8_MouseEnter(object sender, EventArgs e)
        {
            pictureBox8.BackColor = Color.Coral;
        }

        private void pictureBox8_MouseHover(object sender, EventArgs e)
        {
            pictureBox8.BackColor = Color.Coral;
        }

        private void pictureBox8_MouseLeave(object sender, EventArgs e)
        {
            if (click8 == true)
                pictureBox8.BackColor = Color.Coral;
            else
                pictureBox8.BackColor = Color.Transparent;
        }

        //HOVER 9------>

        bool click9 = false;
        private void pictureBox9_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBox9.BackColor = Color.Coral;
            if (click9 == false) //if hasn't been clicked then click
            {
                click9 = true;
                count++;
            }
            else
            {
                click9 = false; //if already clicked once then unselect to return
                count--;
            }
        }

        private void pictureBox9_MouseEnter(object sender, EventArgs e)
        {
            pictureBox9.BackColor = Color.Coral;
        }

        private void pictureBox9_MouseHover(object sender, EventArgs e)
        {
            pictureBox9.BackColor = Color.Coral;
        }

        private void pictureBox9_MouseLeave(object sender, EventArgs e)
        {
            if (click9 == true)
                pictureBox9.BackColor = Color.Coral;
            else
                pictureBox9.BackColor = Color.Transparent;
        }


        //HOVER 10------>

        bool click10 = false;
        private void pictureBox10_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBox10.BackColor = Color.Coral;
            if (click10 == false) //if hasn't been clicked then click
            {
                click10 = true;
                count++;
            }
            else
            {
                click10 = false; //if already clicked once then unselect to return
                count--;
            }
        }

        private void pictureBox10_MouseEnter(object sender, EventArgs e)
        {
            pictureBox10.BackColor = Color.Coral;
        }

        private void pictureBox10_MouseHover(object sender, EventArgs e)
        {
            pictureBox10.BackColor = Color.Coral;
        }

        private void pictureBox10_MouseLeave(object sender, EventArgs e)
        {
            if (click10 == true)
                pictureBox10.BackColor = Color.Coral;
            else
                pictureBox10.BackColor = Color.Transparent;
        }

        //HOVER 11------>

        bool click11 = false;
        private void pictureBox11_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBox11.BackColor = Color.Coral;
            if (click11 == false) //if hasn't been clicked then click
            {
                click11 = true;
                count++;
            }
            else
            {
                click11 = false; //if already clicked once then unselect to return
                count--;
            }
        }

        private void pictureBox11_MouseEnter(object sender, EventArgs e)
        {
            pictureBox11.BackColor = Color.Coral;
        }

        private void pictureBox11_MouseHover(object sender, EventArgs e)
        {
            pictureBox11.BackColor = Color.Coral;
        }

        private void pictureBox11_MouseLeave(object sender, EventArgs e)
        {
            if (click11 == true)
                pictureBox11.BackColor = Color.Coral;
            else
                pictureBox11.BackColor = Color.Transparent;
        }

        //HOVER 12------>

        bool click12 = false;
        private void pictureBox12_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBox12.BackColor = Color.Coral;
            if (click12 == false) //if hasn't been clicked then click
            {
                click12 = true;
                count++;
            }
            else
            {
                click12 = false; //if already clicked once then unselect to return
                count--;
            }
        }

        private void pictureBox12_MouseEnter(object sender, EventArgs e)
        {
            pictureBox12.BackColor = Color.Coral;
        }

        private void pictureBox12_MouseHover(object sender, EventArgs e)
        {
            pictureBox12.BackColor = Color.Coral;
        }

        private void pictureBox12_MouseLeave(object sender, EventArgs e)
        {
            if (click12 == true)
                pictureBox12.BackColor = Color.Coral;
            else
                pictureBox12.BackColor = Color.Transparent;
        }

        //HOVER 13------>

        bool click13 = false;
        private void pictureBox13_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBox13.BackColor = Color.Coral;
            if (click13 == false) //if hasn't been clicked then click
            {
                click13 = true;
                count++;
            }
            else
            {
                click13 = false; //if already clicked once then unselect to return
                count--;
            }
        }

        private void pictureBox13_MouseEnter(object sender, EventArgs e)
        {
            pictureBox13.BackColor = Color.Coral;
        }

        private void pictureBox13_MouseHover(object sender, EventArgs e)
        {
            pictureBox13.BackColor = Color.Coral;
        }

        private void pictureBox13_MouseLeave(object sender, EventArgs e)
        {
            if (click13 == true)
                pictureBox13.BackColor = Color.Coral;
            else
                pictureBox13.BackColor = Color.Transparent;
        }

        //HOVER 14------>

        bool click14 = false;
        private void pictureBox14_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBox14.BackColor = Color.Coral;
            if (click14 == false) //if hasn't been clicked then click
            {
                click14 = true;
                count++;
            }
            else
            {
                click14 = false; //if already clicked once then unselect to return
                count--;
            }
        }

        private void pictureBox14_MouseEnter(object sender, EventArgs e)
        {
            pictureBox14.BackColor = Color.Coral;
        }

        private void pictureBox14_MouseHover(object sender, EventArgs e)
        {
            pictureBox14.BackColor = Color.Coral;
        }

        private void pictureBox14_MouseLeave(object sender, EventArgs e)
        {
            if (click14 == true)
                pictureBox14.BackColor = Color.Coral;
            else
                pictureBox14.BackColor = Color.Transparent;
        }

        //HOVER 15------>

        bool click15 = false;
        private void pictureBox15_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBox15.BackColor = Color.Coral;
            if (click15 == false) //if hasn't been clicked then click
            {
                click15 = true;
                count++;
            }
            else
            {
                click15 = false; //if already clicked once then unselect to return
                count--;
            }
        }

        private void pictureBox15_MouseEnter(object sender, EventArgs e)
        {
            pictureBox15.BackColor = Color.Coral;
        }

        private void pictureBox15_MouseHover(object sender, EventArgs e)
        {
            pictureBox15.BackColor = Color.Coral;
        }

        private void pictureBox15_MouseLeave(object sender, EventArgs e)
        {
            if (click15 == true)
                pictureBox15.BackColor = Color.Coral;
            else
                pictureBox15.BackColor = Color.Transparent;
        }

        //HOVER 16------>

        bool click16 = false;
        private void pictureBox16_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBox16.BackColor = Color.Coral;
            if (click16 == false) //if hasn't been clicked then click
            {
                click16 = true;
                count++;
            }
            else
            {
                click16 = false; //if already clicked once then unselect to return
                count--;
            }
        }

        private void pictureBox16_MouseEnter(object sender, EventArgs e)
        {
            pictureBox16.BackColor = Color.Coral;
        }

        private void pictureBox16_MouseHover(object sender, EventArgs e)
        {
            pictureBox16.BackColor = Color.Coral;
        }

        private void pictureBox16_MouseLeave(object sender, EventArgs e)
        {
            if (click16 == true)
                pictureBox16.BackColor = Color.Coral;
            else
                pictureBox16.BackColor = Color.Transparent;
        }

        //HOVER 17------>

        bool click17 = false;
        private void pictureBox17_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBox17.BackColor = Color.Coral;
            if (click17 == false) //if hasn't been clicked then click
            {
                click17 = true;
                count++;
            }
            else
            {
                click17 = false; //if already clicked once then unselect to return
                count--;
            }
        }

        private void pictureBox17_MouseEnter(object sender, EventArgs e)
        {
            pictureBox17.BackColor = Color.Coral;
        }

        private void pictureBox17_MouseHover(object sender, EventArgs e)
        {
            pictureBox17.BackColor = Color.Coral;
        }

        private void pictureBox17_MouseLeave(object sender, EventArgs e)
        {
            if (click17 == true)
                pictureBox17.BackColor = Color.Coral;
            else
                pictureBox17.BackColor = Color.Transparent;
        }

        //HOVER 18------>

        bool click18 = false;
        private void pictureBox18_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBox18.BackColor = Color.Coral;
            if (click18 == false) //if hasn't been clicked then click
            {
                click18 = true;
                count++;
            }
            else
            {
                click18 = false; //if already clicked once then unselect to return
                count--;
            }
        }

        private void pictureBox18_MouseEnter(object sender, EventArgs e)
        {
            pictureBox18.BackColor = Color.Coral;
        }

        private void pictureBox18_MouseHover(object sender, EventArgs e)
        {
            pictureBox18.BackColor = Color.Coral;
        }

        private void pictureBox18_MouseLeave(object sender, EventArgs e)
        {
            if (click18 == true)
                pictureBox18.BackColor = Color.Coral;
            else
                pictureBox18.BackColor = Color.Transparent;
        }

        //HOVER 19------>

        bool click19 = false;
        private void pictureBox19_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBox19.BackColor = Color.Coral;
            if (click19 == false) //if hasn't been clicked then click
            {
                click19 = true;
                count++;
            }
            else
            {
                click19 = false; //if already clicked once then unselect to return
                count--;
            }
        }

        private void pictureBox19_MouseEnter(object sender, EventArgs e)
        {
            pictureBox19.BackColor = Color.Coral;
        }

        private void pictureBox19_MouseHover(object sender, EventArgs e)
        {
            pictureBox19.BackColor = Color.Coral;
        }

        private void pictureBox19_MouseLeave(object sender, EventArgs e)
        {
            if (click19 == true)
                pictureBox19.BackColor = Color.Coral;
            else
                pictureBox19.BackColor = Color.Transparent;
        }

        //HOVER 20------>

        bool click20 = false;
        private void pictureBox20_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBox20.BackColor = Color.Coral;
            if (click20 == false) //if hasn't been clicked then click
            {
                click20 = true;
                count++;
            }
            else
            {
                click20 = false; //if already clicked once then unselect to return
                count--;
            }
        }

        private void pictureBox20_MouseEnter(object sender, EventArgs e)
        {
            pictureBox20.BackColor = Color.Coral;
        }

        private void pictureBox20_MouseHover(object sender, EventArgs e)
        {
            pictureBox20.BackColor = Color.Coral;
        }

        private void pictureBox20_MouseLeave(object sender, EventArgs e)
        {
            if (click20 == true)
                pictureBox20.BackColor = Color.Coral;
            else
                pictureBox20.BackColor = Color.Transparent;
        }

        //HOVER 21------>

        bool click21 = false;
        private void pictureBox21_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBox21.BackColor = Color.Coral;
            if (click21 == false) //if hasn't been clicked then click
            {
                click21 = true;
                count++;
            }
            else
            {
                click21 = false; //if already clicked once then unselect to return
                count--;
            }
        }

        private void pictureBox21_MouseEnter(object sender, EventArgs e)
        {
            pictureBox21.BackColor = Color.Coral;
        }

        private void pictureBox21_MouseHover(object sender, EventArgs e)
        {
            pictureBox21.BackColor = Color.Coral;
        }

        private void pictureBox21_MouseLeave(object sender, EventArgs e)
        {
            if (click21 == true)
                pictureBox21.BackColor = Color.Coral;
            else
                pictureBox21.BackColor = Color.Transparent;
        }

        //HOVER 22------>

        bool click22 = false;
        private void pictureBox22_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBox22.BackColor = Color.Coral;
            if (click22 == false) //if hasn't been clicked then click
            {
                click22 = true;
                count++;
            }
            else
            {
                click22 = false; //if already clicked once then unselect to return
                count--;
            }
        }

        private void pictureBox22_MouseEnter(object sender, EventArgs e)
        {
            pictureBox22.BackColor = Color.Coral;
        }

        private void pictureBox22_MouseHover(object sender, EventArgs e)
        {
            pictureBox22.BackColor = Color.Coral;
        }

        private void pictureBox22_MouseLeave(object sender, EventArgs e)
        {
            if (click22 == true)
                pictureBox22.BackColor = Color.Coral;
            else
                pictureBox22.BackColor = Color.Transparent;
        }

        //HOVER 23------>

        bool click23 = false;
        private void pictureBox23_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBox23.BackColor = Color.Coral;
            if (click23 == false) //if hasn't been clicked then click
            {
                click23 = true;
                count++;
            }
            else
            {
                click23 = false; //if already clicked once then unselect to return
                count--;
            }
        }

        private void pictureBox23_MouseEnter(object sender, EventArgs e)
        {
            pictureBox23.BackColor = Color.Coral;
        }

        private void pictureBox23_MouseHover(object sender, EventArgs e)
        {
            pictureBox23.BackColor = Color.Coral;
        }

        private void pictureBox23_MouseLeave(object sender, EventArgs e)
        {
            if (click23 == true)
                pictureBox23.BackColor = Color.Coral;
            else
                pictureBox23.BackColor = Color.Transparent;
        }

        //HOVER 24------>

        bool click24 = false;
        private void pictureBox24_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBox24.BackColor = Color.Coral;
            if (click24 == false) //if hasn't been clicked then click
            {
                click24 = true;
                count++;
            }
            else
            {
                click24 = false; //if already clicked once then unselect to return
                count--;
            }
        }

        private void pictureBox24_MouseEnter(object sender, EventArgs e)
        {
            pictureBox24.BackColor = Color.Coral;
        }

        private void pictureBox24_MouseHover(object sender, EventArgs e)
        {
            pictureBox24.BackColor = Color.Coral;
        }

        private void pictureBox24_MouseLeave(object sender, EventArgs e)
        {
            if (click24 == true)
                pictureBox24.BackColor = Color.Coral;
            else
                pictureBox24.BackColor = Color.Transparent;
        }


        //HOVER 25------>

        bool click25 = false;
        private void pictureBox25_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBox25.BackColor = Color.Coral;
            if (click25 == false) //if hasn't been clicked then click
            {
                click25 = true;
                count++;
            }
            else
            {
                click25 = false; //if already clicked once then unselect to return
                count--;
            }
        }

        private void pictureBox25_MouseEnter(object sender, EventArgs e)
        {
            pictureBox25.BackColor = Color.Coral;
        }

        private void pictureBox25_MouseHover(object sender, EventArgs e)
        {
            pictureBox25.BackColor = Color.Coral;
        }

        private void pictureBox25_MouseLeave(object sender, EventArgs e)
        {
            if (click25 == true)
                pictureBox25.BackColor = Color.Coral;
            else
                pictureBox25.BackColor = Color.Transparent;
        }

        //HOVER 26------>

        bool click26 = false;
        private void pictureBox26_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBox26.BackColor = Color.Coral;
            if (click26 == false) //if hasn't been clicked then click
            {
                click26 = true;
                count++;
            }
            else
            {
                click26 = false; //if already clicked once then unselect to return
                count--;
            }
        }

        private void pictureBox26_MouseEnter(object sender, EventArgs e)
        {
            pictureBox26.BackColor = Color.Coral;
        }

        private void pictureBox26_MouseHover(object sender, EventArgs e)
        {
            pictureBox26.BackColor = Color.Coral;
        }

        private void pictureBox26_MouseLeave(object sender, EventArgs e)
        {
            if (click26 == true)
                pictureBox26.BackColor = Color.Coral;
            else
                pictureBox26.BackColor = Color.Transparent;
        }

        //HOVER 27------>

        bool click27 = false;
        private void pictureBox27_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBox27.BackColor = Color.Coral;
            if (click27 == false) //if hasn't been clicked then click
            {
                click27 = true;
                count++;
            }
            else
            {
                click27 = false; //if already clicked once then unselect to return
                count--;
            }
        }

        private void pictureBox27_MouseEnter(object sender, EventArgs e)
        {
            pictureBox27.BackColor = Color.Coral;
        }

        private void pictureBox27_MouseHover(object sender, EventArgs e)
        {
            pictureBox27.BackColor = Color.Coral;
        }

        private void pictureBox27_MouseLeave(object sender, EventArgs e)
        {
            if (click27 == true)
                pictureBox27.BackColor = Color.Coral;
            else
                pictureBox27.BackColor = Color.Transparent;
        }

        //HOVER 28------>

        bool click28 = false;
        private void pictureBox28_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBox28.BackColor = Color.Coral;
            if (click28 == false) //if hasn't been clicked then click
            {
                click28 = true;
                count++;
            }
            else
            {
                click28 = false; //if already clicked once then unselect to return
                count--;
            }
        }

        private void pictureBox28_MouseEnter(object sender, EventArgs e)
        {
            pictureBox28.BackColor = Color.Coral;
        }

        private void pictureBox28_MouseHover(object sender, EventArgs e)
        {
            pictureBox28.BackColor = Color.Coral;
        }

        private void pictureBox28_MouseLeave(object sender, EventArgs e)
        {
            if (click28 == true)
                pictureBox28.BackColor = Color.Coral;
            else
                pictureBox28.BackColor = Color.Transparent;
        }

        //HOVER 29------>

        bool click29 = false;
        private void pictureBox29_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBox29.BackColor = Color.Coral;
            if (click29 == false) //if hasn't been clicked then click
            {
                click29 = true;
                count++;
            }
            else
            {
                click29 = false; //if already clicked once then unselect to return
                count--;
            }
        }

        private void pictureBox29_MouseEnter(object sender, EventArgs e)
        {
            pictureBox29.BackColor = Color.Coral;
        }

        private void pictureBox29_MouseHover(object sender, EventArgs e)
        {
            pictureBox29.BackColor = Color.Coral;
        }

        private void pictureBox29_MouseLeave(object sender, EventArgs e)
        {
            if (click29 == true)
                pictureBox29.BackColor = Color.Coral;
            else
                pictureBox29.BackColor = Color.Transparent;
        }


        //HOVER 30------>

        bool click30 = false;
        private void pictureBox30_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBox30.BackColor = Color.Coral;
            if (click30 == false) //if hasn't been clicked then click
            {
                click30 = true;
                count++;
            }
            else
            {
                click30 = false; //if already clicked once then unselect to return
                count--;
            }
        }

        private void pictureBox30_MouseEnter(object sender, EventArgs e)
        {
            pictureBox30.BackColor = Color.Coral;
        }

        private void pictureBox30_MouseHover(object sender, EventArgs e)
        {
            pictureBox30.BackColor = Color.Coral;
        }

        private void pictureBox30_MouseLeave(object sender, EventArgs e)
        {
            if (click30 == true)
                pictureBox30.BackColor = Color.Coral;
            else
                pictureBox30.BackColor = Color.Transparent;
        }

        //HOVER 31------>

        bool click31 = false;
        private void pictureBox31_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBox31.BackColor = Color.Coral;
            if (click31 == false) //if hasn't been clicked then click
            {
                click31 = true;
                count++;
            }
            else
            {
                click31 = false; //if already clicked once then unselect to return
                count--;
            }
        }

        private void pictureBox31_MouseEnter(object sender, EventArgs e)
        {
            pictureBox31.BackColor = Color.Coral;
        }

        private void pictureBox31_MouseHover(object sender, EventArgs e)
        {
            pictureBox31.BackColor = Color.Coral;
        }

        private void pictureBox31_MouseLeave(object sender, EventArgs e)
        {
            if (click31 == true)
                pictureBox31.BackColor = Color.Coral;
            else
                pictureBox31.BackColor = Color.Transparent;
        }

        //HOVER 32------>

        bool click32 = false;
        private void pictureBox32_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBox32.BackColor = Color.Coral;
            if (click32 == false) //if hasn't been clicked then click
            {
                click32 = true;
                count++;
            }
            else
            {
                click32 = false; //if already clicked once then unselect to return
                count--;
            }
        }

        private void pictureBox32_MouseEnter(object sender, EventArgs e)
        {
            pictureBox32.BackColor = Color.Coral;
        }

        private void pictureBox32_MouseHover(object sender, EventArgs e)
        {
            pictureBox32.BackColor = Color.Coral;
        }

        private void pictureBox32_MouseLeave(object sender, EventArgs e)
        {
            if (click32 == true)
                pictureBox32.BackColor = Color.Coral;
            else
                pictureBox32.BackColor = Color.Transparent;
        }

        //HOVER 33------>

        bool click33 = false;
        private void pictureBox33_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBox33.BackColor = Color.Coral;
            if (click33 == false) //if hasn't been clicked then click
            {
                click33 = true;
                count++;
            }
            else
            {
                click33 = false; //if already clicked once then unselect to return
                count--;
            }
        }

        private void pictureBox33_MouseEnter(object sender, EventArgs e)
        {
            pictureBox33.BackColor = Color.Coral;
        }

        private void pictureBox33_MouseHover(object sender, EventArgs e)
        {
            pictureBox33.BackColor = Color.Coral;
        }

        private void pictureBox33_MouseLeave(object sender, EventArgs e)
        {
            if (click33 == true)
                pictureBox33.BackColor = Color.Coral;
            else
                pictureBox33.BackColor = Color.Transparent;
        }

        //HOVER 34------>

        bool click34 = false;
        private void pictureBox34_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBox34.BackColor = Color.Coral;
            if (click34 == false) //if hasn't been clicked then click
            {
                click34 = true;
                count++;
            }
            else
            {
                click34 = false; //if already clicked once then unselect to return
                count--;
            }
        }

        private void pictureBox34_MouseEnter(object sender, EventArgs e)
        {
            pictureBox34.BackColor = Color.Coral;
        }

        private void pictureBox34_MouseHover(object sender, EventArgs e)
        {
            pictureBox34.BackColor = Color.Coral;
        }

        private void pictureBox34_MouseLeave(object sender, EventArgs e)
        {
            if (click34 == true)
                pictureBox34.BackColor = Color.Coral;
            else
                pictureBox34.BackColor = Color.Transparent;
        }

        //HOVER 35------>

        bool click35 = false;
        private void pictureBox35_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBox35.BackColor = Color.Coral;
            if (click35 == false) //if hasn't been clicked then click
            {
                click35 = true;
                count++;
            }
            else
            {
                click35 = false; //if already clicked once then unselect to return
                count--;
            }
        }

        private void pictureBox35_MouseEnter(object sender, EventArgs e)
        {
            pictureBox35.BackColor = Color.Coral;
        }

        private void pictureBox35_MouseHover(object sender, EventArgs e)
        {
            pictureBox35.BackColor = Color.Coral;
        }

        private void pictureBox35_MouseLeave(object sender, EventArgs e)
        {
            if (click35 == true)
                pictureBox35.BackColor = Color.Coral;
            else
                pictureBox35.BackColor = Color.Transparent;
        }

        //HOVER 36------>

        bool click36 = false;
        private void pictureBox36_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBox36.BackColor = Color.Coral;
            if (click36 == false) //if hasn't been clicked then click
            {
                click36 = true;
                count++;
            }
            else
            {
                click36 = false; //if already clicked once then unselect to return
                count--;
            }
        }

        private void pictureBox36_MouseEnter(object sender, EventArgs e)
        {
            pictureBox36.BackColor = Color.Coral;
        }

        private void pictureBox36_MouseHover(object sender, EventArgs e)
        {
            pictureBox36.BackColor = Color.Coral;
        }

        private void pictureBox36_MouseLeave(object sender, EventArgs e)
        {
            if (click36 == true)
                pictureBox36.BackColor = Color.Coral;
            else
                pictureBox36.BackColor = Color.Transparent;
        }

        //HOVER 37------>

        bool click37 = false;
        private void pictureBox37_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBox37.BackColor = Color.Coral;
            if (click37 == false) //if hasn't been clicked then click
            {
                click37 = true;
                count++;
            }
            else
            {
                click37 = false; //if already clicked once then unselect to return
                count--;
            }
        }

        private void pictureBox37_MouseEnter(object sender, EventArgs e)
        {
            pictureBox37.BackColor = Color.Coral;
        }

        private void pictureBox37_MouseHover(object sender, EventArgs e)
        {
            pictureBox37.BackColor = Color.Coral;
        }

        private void pictureBox37_MouseLeave(object sender, EventArgs e)
        {
            if (click37 == true)
                pictureBox37.BackColor = Color.Coral;
            else
                pictureBox37.BackColor = Color.Transparent;
        }

        //HOVER 38------>

        bool click38 = false;
        private void pictureBox38_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBox38.BackColor = Color.Coral;
            if (click38 == false) //if hasn't been clicked then click
            {
                click38 = true;
                count++;
            }
            else
            {
                click38 = false; //if already clicked once then unselect to return
                count--;
            }
        }

        private void pictureBox38_MouseEnter(object sender, EventArgs e)
        {
            pictureBox38.BackColor = Color.Coral;
        }

        private void pictureBox38_MouseHover(object sender, EventArgs e)
        {
            pictureBox38.BackColor = Color.Coral;
        }

        private void pictureBox38_MouseLeave(object sender, EventArgs e)
        {
            if (click38 == true)
                pictureBox38.BackColor = Color.Coral;
            else
                pictureBox38.BackColor = Color.Transparent;
        }

        //HOVER 39------>

        bool click39 = false;
        private void pictureBox39_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBox39.BackColor = Color.Coral;
            if (click39 == false) //if hasn't been clicked then click
            {
                click39 = true;
                count++;
            }
            else
            {
                click39 = false; //if already clicked once then unselect to return
                count--;
            }
        }

        private void pictureBox39_MouseEnter(object sender, EventArgs e)
        {
            pictureBox39.BackColor = Color.Coral;
        }

        private void pictureBox39_MouseHover(object sender, EventArgs e)
        {
            pictureBox39.BackColor = Color.Coral;
        }

        private void pictureBox39_MouseLeave(object sender, EventArgs e)
        {
            if (click39 == true)
                pictureBox39.BackColor = Color.Coral;
            else
                pictureBox39.BackColor = Color.Transparent;
        }

        //HOVER 40------>

        bool click40 = false;
        private void pictureBox40_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBox40.BackColor = Color.Coral;
            if (click40 == false) //if hasn't been clicked then click
            {
                click40 = true;
                count++;
            }
            else
            {
                click40 = false; //if already clicked once then unselect to return
                count--;
            }
        }

        private void pictureBox40_MouseEnter(object sender, EventArgs e)
        {
            pictureBox40.BackColor = Color.Coral;
        }

        private void pictureBox40_MouseHover(object sender, EventArgs e)
        {
            pictureBox40.BackColor = Color.Coral;
        }

        private void pictureBox40_MouseLeave(object sender, EventArgs e)
        {
            if (click40 == true)
                pictureBox40.BackColor = Color.Coral;
            else
                pictureBox40.BackColor = Color.Transparent;
        }

        //HOVER 41------>

        bool click41 = false;
        private void pictureBox41_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBox41.BackColor = Color.Coral;
            if (click41 == false) //if hasn't been clicked then click
            {
                click41 = true;
                count++;
            }
            else
            {
                click41 = false; //if already clicked once then unselect to return
                count--;
            }
        }

        private void pictureBox41_MouseEnter(object sender, EventArgs e)
        {
            pictureBox41.BackColor = Color.Coral;
        }

        private void pictureBox41_MouseHover(object sender, EventArgs e)
        {
            pictureBox41.BackColor = Color.Coral;
        }

        private void pictureBox41_MouseLeave(object sender, EventArgs e)
        {
            if (click41 == true)
                pictureBox41.BackColor = Color.Coral;
            else
                pictureBox41.BackColor = Color.Transparent;
        }

        //HOVER 42------>

        bool click42 = false;
        private void pictureBox42_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBox42.BackColor = Color.Coral;
            if (click42 == false) //if hasn't been clicked then click
            {
                click42 = true;
                count++;
            }
            else
            {
                click42 = false; //if already clicked once then unselect to return
                count--;
            }
        }

        private void pictureBox42_MouseEnter(object sender, EventArgs e)
        {
            pictureBox42.BackColor = Color.Coral;
        }

        private void pictureBox42_MouseHover(object sender, EventArgs e)
        {
            pictureBox42.BackColor = Color.Coral;
        }

        private void pictureBox42_MouseLeave(object sender, EventArgs e)
        {
            if (click42 == true)
                pictureBox42.BackColor = Color.Coral;
            else
                pictureBox42.BackColor = Color.Transparent;
        }

        //HOVER 43------>

        bool click43 = false;
        private void pictureBox43_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBox43.BackColor = Color.Coral;
            if (click43 == false) //if hasn't been clicked then click
            {
                click43 = true;
                count++;
            }
            else
            {
                click43 = false; //if already clicked once then unselect to return
                count--;
            }
        }

        private void pictureBox43_MouseEnter(object sender, EventArgs e)
        {
            pictureBox43.BackColor = Color.Coral;
        }

        private void pictureBox43_MouseHover(object sender, EventArgs e)
        {
            pictureBox43.BackColor = Color.Coral;
        }

        private void pictureBox43_MouseLeave(object sender, EventArgs e)
        {
            if (click43 == true)
                pictureBox43.BackColor = Color.Coral;
            else
                pictureBox43.BackColor = Color.Transparent;
        }

        //HOVER 44------>

        bool click44 = false;
        private void pictureBox44_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBox44.BackColor = Color.Coral;
            if (click44 == false) //if hasn't been clicked then click
            {
                click44 = true;
                count++;
            }
            else
            {
                click44 = false; //if already clicked once then unselect to return
                count--;
            }
        }

        private void pictureBox44_MouseEnter(object sender, EventArgs e)
        {
            pictureBox44.BackColor = Color.Coral;
        }

        private void pictureBox44_MouseHover(object sender, EventArgs e)
        {
            pictureBox44.BackColor = Color.Coral;
        }

        private void pictureBox44_MouseLeave(object sender, EventArgs e)
        {
            if (click44 == true)
                pictureBox44.BackColor = Color.Coral;
            else
                pictureBox44.BackColor = Color.Transparent;
        }

        //HOVER 45------>

        bool click45 = false;
        private void pictureBox45_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBox45.BackColor = Color.Coral;
            if (click45 == false) //if hasn't been clicked then click
            {
                click45 = true;
                count++;
            }
            else
            {
                click45 = false; //if already clicked once then unselect to return
                count--;
            }
        }

        private void pictureBox45_MouseEnter(object sender, EventArgs e)
        {
            pictureBox45.BackColor = Color.Coral;
        }

        private void pictureBox45_MouseHover(object sender, EventArgs e)
        {
            pictureBox45.BackColor = Color.Coral;
        }

        private void pictureBox45_MouseLeave(object sender, EventArgs e)
        {
            if (click45 == true)
                pictureBox45.BackColor = Color.Coral;
            else
                pictureBox45.BackColor = Color.Transparent;
        }

        //HOVER 46------>

        bool click46 = false;
        private void pictureBox46_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBox46.BackColor = Color.Coral;
            if (click46 == false) //if hasn't been clicked then click
            {
                click46 = true;
                count++;
            }
            else
            {
                click46 = false; //if already clicked once then unselect to return
                count--;
            }
        }

        private void pictureBox46_MouseEnter(object sender, EventArgs e)
        {
            pictureBox46.BackColor = Color.Coral;
        }

        private void pictureBox46_MouseHover(object sender, EventArgs e)
        {
            pictureBox46.BackColor = Color.Coral;
        }

        private void pictureBox46_MouseLeave(object sender, EventArgs e)
        {
            if (click46 == true)
                pictureBox46.BackColor = Color.Coral;
            else
                pictureBox46.BackColor = Color.Transparent;
        }

        //HOVER 47------>

        bool click47 = false;
        private void pictureBox47_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBox47.BackColor = Color.Coral;
            if (click47 == false) //if hasn't been clicked then click
            {
                click47 = true;
                count++;
            }
            else
            {
                click47 = false; //if already clicked once then unselect to return
                count--;
            }
        }

        private void pictureBox47_MouseEnter(object sender, EventArgs e)
        {
            pictureBox47.BackColor = Color.Coral;
        }

        private void pictureBox47_MouseHover(object sender, EventArgs e)
        {
            pictureBox47.BackColor = Color.Coral;
        }

        private void pictureBox47_MouseLeave(object sender, EventArgs e)
        {
            if (click47 == true)
                pictureBox47.BackColor = Color.Coral;
            else
                pictureBox47.BackColor = Color.Transparent;
        }

        //HOVER 48------>

        bool click48 = false;
        private void pictureBox48_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBox48.BackColor = Color.Coral;
            if (click48 == false) //if hasn't been clicked then click
            {
                click48 = true;
                count++;
            }
            else
            {
                click48 = false; //if already clicked once then unselect to return
                count--;
            }
        }

        private void pictureBox48_MouseEnter(object sender, EventArgs e)
        {
            pictureBox48.BackColor = Color.Coral;
        }

        private void pictureBox48_MouseHover(object sender, EventArgs e)
        {
            pictureBox48.BackColor = Color.Coral;
        }

        private void pictureBox48_MouseLeave(object sender, EventArgs e)
        {
            if (click48 == true)
                pictureBox48.BackColor = Color.Coral;
            else
                pictureBox48.BackColor = Color.Transparent;
        }

        //HOVER 49------>

        bool click49 = false;
        private void pictureBox49_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBox49.BackColor = Color.Coral;
            if (click49 == false) //if hasn't been clicked then click
            {
                click49 = true;
                count++;
            }
            else
            {
                click49 = false; //if already clicked once then unselect to return
                count--;
            }
        }

        private void pictureBox49_MouseEnter(object sender, EventArgs e)
        {
            pictureBox49.BackColor = Color.Coral;
        }

        private void pictureBox49_MouseHover(object sender, EventArgs e)
        {
            pictureBox49.BackColor = Color.Coral;
        }

        private void pictureBox49_MouseLeave(object sender, EventArgs e)
        {
            if (click49 == true)
                pictureBox49.BackColor = Color.Coral;
            else
                pictureBox49.BackColor = Color.Transparent;
        }

        //HOVER 50------>

        bool click50 = false;
        private void pictureBox50_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBox50.BackColor = Color.Coral;
            if (click50 == false) //if hasn't been clicked then click
            {
                click50 = true;
                count++;
            }
            else
            {
                click50 = false; //if already clicked once then unselect to return
                count--;
            }
        }

        private void pictureBox50_MouseEnter(object sender, EventArgs e)
        {
            pictureBox50.BackColor = Color.Coral;
        }

        private void pictureBox50_MouseHover(object sender, EventArgs e)
        {
            pictureBox50.BackColor = Color.Coral;
        }

        private void pictureBox50_MouseLeave(object sender, EventArgs e)
        {
            if (click50 == true)
                pictureBox50.BackColor = Color.Coral;
            else
                pictureBox50.BackColor = Color.Transparent;
        }

        //HOVER 51------>

        bool click51 = false;
        private void pictureBox51_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBox51.BackColor = Color.Coral;
            if (click51 == false) //if hasn't been clicked then click
            {
                click51 = true;
                count++;
            }
            else
            {
                click51 = false; //if already clicked once then unselect to return
                count--;
            }
        }

        private void pictureBox51_MouseEnter(object sender, EventArgs e)
        {
            pictureBox51.BackColor = Color.Coral;
        }

        private void pictureBox51_MouseHover(object sender, EventArgs e)
        {
            pictureBox51.BackColor = Color.Coral;
        }

        private void pictureBox51_MouseLeave(object sender, EventArgs e)
        {
            if (click51 == true)
                pictureBox51.BackColor = Color.Coral;
            else
                pictureBox51.BackColor = Color.Transparent;
        }

        //HOVER 52------>

        bool click52 = false;
        private void pictureBox52_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBox52.BackColor = Color.Coral;
            if (click52 == false) //if hasn't been clicked then click
            {
                click52 = true;
                count++;
            }
            else
            {
                click52 = false; //if already clicked once then unselect to return
                count--;
            }
        }

        private void pictureBox52_MouseEnter(object sender, EventArgs e)
        {
            pictureBox52.BackColor = Color.Coral;
        }

        private void pictureBox52_MouseHover(object sender, EventArgs e)
        {
            pictureBox52.BackColor = Color.Coral;
        }

        private void pictureBox52_MouseLeave(object sender, EventArgs e)
        {
            if (click52 == true)
                pictureBox52.BackColor = Color.Coral;
            else
                pictureBox52.BackColor = Color.Transparent;
        }

        //HOVER 53------>

        bool click53 = false;
        private void pictureBox53_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBox53.BackColor = Color.Coral;
            if (click53 == false) //if hasn't been clicked then click
            {
                click53 = true;
                count++;
            }
            else
            {
                click53 = false; //if already clicked once then unselect to return
                count--;
            }
        }

        private void pictureBox53_MouseEnter(object sender, EventArgs e)
        {
            pictureBox53.BackColor = Color.Coral;
        }

        private void pictureBox53_MouseHover(object sender, EventArgs e)
        {
            pictureBox53.BackColor = Color.Coral;
        }

        private void pictureBox53_MouseLeave(object sender, EventArgs e)
        {
            if (click53 == true)
                pictureBox53.BackColor = Color.Coral;
            else
                pictureBox53.BackColor = Color.Transparent;
        }

        //HOVER 54------>

        bool click54 = false;
        private void pictureBox54_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBox54.BackColor = Color.Coral;
            if (click54 == false) //if hasn't been clicked then click
            {
                click54 = true;
                count++;
            }
            else
            {
                click54 = false; //if already clicked once then unselect to return
                count--;
            }
        }

        private void pictureBox54_MouseEnter(object sender, EventArgs e)
        {
            pictureBox54.BackColor = Color.Coral;
        }

        private void pictureBox54_MouseHover(object sender, EventArgs e)
        {
            pictureBox54.BackColor = Color.Coral;
        }

        private void pictureBox54_MouseLeave(object sender, EventArgs e)
        {
            if (click54 == true)
                pictureBox54.BackColor = Color.Coral;
            else
                pictureBox54.BackColor = Color.Transparent;
        }

        //HOVER 55------>

        bool click55 = false;
        private void pictureBox55_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBox55.BackColor = Color.Coral;
            if (click55 == false) //if hasn't been clicked then click
            {
                click55 = true;
                count++;
            }
            else
            {
                click55 = false; //if already clicked once then unselect to return
                count--;
            }
        }

        private void pictureBox55_MouseEnter(object sender, EventArgs e)
        {
            pictureBox55.BackColor = Color.Coral;
        }

        private void pictureBox55_MouseHover(object sender, EventArgs e)
        {
            pictureBox55.BackColor = Color.Coral;
        }

        private void pictureBox55_MouseLeave(object sender, EventArgs e)
        {
            if (click55 == true)
                pictureBox55.BackColor = Color.Coral;
            else
                pictureBox55.BackColor = Color.Transparent;
        }

        //HOVER 56------>

        bool click56 = false;
        private void pictureBox56_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBox56.BackColor = Color.Coral;
            if (click56 == false) //if hasn't been clicked then click
            {
                click56 = true;
                count++;
            }
            else
            {
                click56 = false; //if already clicked once then unselect to return
                count--;
            }
        }

        private void pictureBox56_MouseEnter(object sender, EventArgs e)
        {
            pictureBox56.BackColor = Color.Coral;
        }

        private void pictureBox56_MouseHover(object sender, EventArgs e)
        {
            pictureBox56.BackColor = Color.Coral;
        }

        private void pictureBox56_MouseLeave(object sender, EventArgs e)
        {
            if (click56 == true)
                pictureBox56.BackColor = Color.Coral;
            else
                pictureBox56.BackColor = Color.Transparent;
        }

        //HOVER 57------>

        bool click57 = false;
        private void pictureBox57_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBox57.BackColor = Color.Coral;
            if (click57 == false) //if hasn't been clicked then click
            {
                click57 = true;
                count++;
            }
            else
            {
                click57 = false; //if already clicked once then unselect to return
                count--;
            }
        }

        private void pictureBox57_MouseEnter(object sender, EventArgs e)
        {
            pictureBox57.BackColor = Color.Coral;
        }

        private void pictureBox57_MouseHover(object sender, EventArgs e)
        {
            pictureBox57.BackColor = Color.Coral;
        }

        private void pictureBox57_MouseLeave(object sender, EventArgs e)
        {
            if (click57 == true)
                pictureBox57.BackColor = Color.Coral;
            else
                pictureBox57.BackColor = Color.Transparent;
        }

        //HOVER 58------>

        bool click58 = false;
        private void pictureBox58_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBox58.BackColor = Color.Coral;
            if (click58 == false) //if hasn't been clicked then click
            {
                click58 = true;
                count++;
            }
            else
            {
                click58 = false; //if already clicked once then unselect to return
                count--;
            }
        }

        private void pictureBox58_MouseEnter(object sender, EventArgs e)
        {
            pictureBox58.BackColor = Color.Coral;
        }

        private void pictureBox58_MouseHover(object sender, EventArgs e)
        {
            pictureBox58.BackColor = Color.Coral;
        }

        private void pictureBox58_MouseLeave(object sender, EventArgs e)
        {
            if (click58 == true)
                pictureBox58.BackColor = Color.Coral;
            else
                pictureBox58.BackColor = Color.Transparent;
        }

        //HOVER 59------>

        bool click59 = false;
        private void pictureBox59_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBox59.BackColor = Color.Coral;
            if (click59 == false) //if hasn't been clicked then click
            {
                click59 = true;
                count++;
            }
            else
            {
                click59 = false; //if already clicked once then unselect to return
                count--;
            }
        }

        private void pictureBox59_MouseEnter(object sender, EventArgs e)
        {
            pictureBox59.BackColor = Color.Coral;
        }

        private void pictureBox59_MouseHover(object sender, EventArgs e)
        {
            pictureBox59.BackColor = Color.Coral;
        }

        private void pictureBox59_MouseLeave(object sender, EventArgs e)
        {
            if (click59 == true)
                pictureBox59.BackColor = Color.Coral;
            else
                pictureBox59.BackColor = Color.Transparent;
        }

        //HOVER 60------>

        bool click60 = false;
        private void pictureBox60_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBox60.BackColor = Color.Coral;
            if (click60 == false) //if hasn't been clicked then click
            {
                click60 = true;
                count++;
            }
            else
            {
                click60 = false; //if already clicked once then unselect to return
                count--;
            }
        }

        private void pictureBox60_MouseEnter(object sender, EventArgs e)
        {
            pictureBox60.BackColor = Color.Coral;
        }

        private void pictureBox60_MouseHover(object sender, EventArgs e)
        {
            pictureBox60.BackColor = Color.Coral;
        }

        private void pictureBox60_MouseLeave(object sender, EventArgs e)
        {
            if (click60 == true)
                pictureBox60.BackColor = Color.Coral;
            else
                pictureBox60.BackColor = Color.Transparent;
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            foreach (Control c in this.Controls)
            {
                //label2.Text = ("WORKS?");
                if (c is PictureBox)
                {
                    if (c.BackColor == Color.Coral)
                        label3.Text = (count.ToString());

                  //  if (c.MouseDown
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Control c in this.Controls)
            {
                if (c is PictureBox)
                    if (c.BackColor != Color.Coral)
                        c.Hide(); 
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
                        
            foreach (Control c in this.Controls)
            {
                c.Show();
            }
            label3.ResetText();
            count = 0;
                 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            /*
            foreach (Control d in this.Controls)
            {
                if (d is PictureBox)
                {
                    string storeLocation = " ";
                    d.Location = storeLocation;
                }
            }
             */
        }


        
        
    }

    
}