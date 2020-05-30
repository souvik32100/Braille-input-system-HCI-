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

namespace HCI
{
    public partial class Keybord : Form
    {
        public Keybord()
        {
            InitializeComponent();
        }
        int i = 0;

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        

        private void richTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue >= 96 && e.KeyValue <= 105)
            {

                
                if (e.KeyValue == 103)
                {
                    key1.BackColor = Color.Aqua;
                    
                }
                if (e.KeyValue==100)
                {
                    key2.BackColor = Color.Aqua;
                    
                }
                
                if (e.KeyValue == 97)
                {
                    key3.BackColor = Color.Aqua;
                    
                }
                if (e.KeyValue == 104)
                {
                    key4.BackColor = Color.Aqua;
                    
                }
                if (e.KeyValue == 101)
                {
                    key5.BackColor = Color.Aqua;
                    
                }
                if (e.KeyValue == 98)
                {
                    key6.BackColor = Color.Aqua;
                    

                }
                if (e.KeyValue == 105)
                {
                    backBtn();

                }
                if (e.KeyValue == 102)
                {
                    spaceBtn();

                }
                if (e.KeyValue == 99)
                {
                    enterBtn();

                }
                if (e.KeyValue == 96)
                {
                    print();
                    update();
                    
                }



            }
        }

        private void Keybord_KeyDown_1(object sender, KeyEventArgs e)
        {
            
        }

        public void update()
        {
            key1.BackColor = Color.White;
            key2.BackColor = Color.White;
            key3.BackColor = Color.White;
            key4.BackColor = Color.White;
            key5.BackColor = Color.White;
            key6.BackColor = Color.White;
        }
        public void print()
        {
            if(key1.BackColor.Equals(Color.Aqua)&& key2.BackColor.Equals(Color.White) && key3.BackColor.Equals(Color.White) && key4.BackColor.Equals(Color.White) && key5.BackColor.Equals(Color.White) && key6.BackColor.Equals(Color.White))
            {
                richTextBox1.Text = richTextBox1.Text + "A";
                //playSound();
            }
            if (key1.BackColor.Equals(Color.Aqua)&& key2.BackColor.Equals(Color.Aqua) && key3.BackColor.Equals(Color.White) && key4.BackColor.Equals(Color.White) && key5.BackColor.Equals(Color.White) && key6.BackColor.Equals(Color.White))
            {
                richTextBox1.Text = richTextBox1.Text + "B";
            }
            if (key1.BackColor.Equals(Color.Aqua) && key4.BackColor.Equals(Color.Aqua) && key2.BackColor.Equals(Color.White) && key3.BackColor.Equals(Color.White)&& key5.BackColor.Equals(Color.White) && key6.BackColor.Equals(Color.White))
            {
                richTextBox1.Text = richTextBox1.Text + "C";
            }
            if (key1.BackColor.Equals(Color.Aqua) && key4.BackColor.Equals(Color.Aqua) && key5.BackColor.Equals(Color.Aqua) && key2.BackColor.Equals(Color.White) && key3.BackColor.Equals(Color.White) && key6.BackColor.Equals(Color.White))
            {
                richTextBox1.Text = richTextBox1.Text + "D";
            }
            if (key1.BackColor.Equals(Color.Aqua) && key5.BackColor.Equals(Color.Aqua) && key4.BackColor.Equals(Color.White) && key2.BackColor.Equals(Color.White) && key3.BackColor.Equals(Color.White) && key6.BackColor.Equals(Color.White))
            {
                richTextBox1.Text = richTextBox1.Text + "E";
            }
            if (key1.BackColor.Equals(Color.Aqua) && key2.BackColor.Equals(Color.Aqua) && key4.BackColor.Equals(Color.Aqua) && key3.BackColor.Equals(Color.White) && key5.BackColor.Equals(Color.White) && key6.BackColor.Equals(Color.White))
            {
                richTextBox1.Text = richTextBox1.Text + "F";
            }
            if (key1.BackColor.Equals(Color.Aqua) && key2.BackColor.Equals(Color.Aqua) && key4.BackColor.Equals(Color.Aqua) && key5.BackColor.Equals(Color.Aqua) && key3.BackColor.Equals(Color.White) && key6.BackColor.Equals(Color.White))
            {
                richTextBox1.Text = richTextBox1.Text + "G";
            }
            if (key1.BackColor.Equals(Color.Aqua) && key2.BackColor.Equals(Color.Aqua) && key5.BackColor.Equals(Color.Aqua) && key3.BackColor.Equals(Color.White) && key4.BackColor.Equals(Color.White) && key6.BackColor.Equals(Color.White))
            {
                richTextBox1.Text = richTextBox1.Text + "H";
            }
            if (key2.BackColor.Equals(Color.Aqua) && key4.BackColor.Equals(Color.Aqua) && key1.BackColor.Equals(Color.White) && key3.BackColor.Equals(Color.White) && key6.BackColor.Equals(Color.White) && key5.BackColor.Equals(Color.White))
            {
                richTextBox1.Text = richTextBox1.Text + "I";
            }
            if (key2.BackColor.Equals(Color.Aqua) && key4.BackColor.Equals(Color.Aqua) && key5.BackColor.Equals(Color.Aqua) && key1.BackColor.Equals(Color.White) && key3.BackColor.Equals(Color.White) && key6.BackColor.Equals(Color.White))
            {
                richTextBox1.Text = richTextBox1.Text + "J";
            }
            if (key1.BackColor.Equals(Color.Aqua) && key3.BackColor.Equals(Color.Aqua) && key2.BackColor.Equals(Color.White) && key6.BackColor.Equals(Color.White) && key5.BackColor.Equals(Color.White) && key4.BackColor.Equals(Color.White))
            {
                richTextBox1.Text = richTextBox1.Text + "K";
            }
            if (key1.BackColor.Equals(Color.Aqua) && key2.BackColor.Equals(Color.Aqua) && key3.BackColor.Equals(Color.Aqua) && key6.BackColor.Equals(Color.White) && key5.BackColor.Equals(Color.White) && key4.BackColor.Equals(Color.White))
            {
                richTextBox1.Text = richTextBox1.Text + "L";
            }
            if (key1.BackColor.Equals(Color.Aqua) && key3.BackColor.Equals(Color.Aqua) && key4.BackColor.Equals(Color.Aqua) && key6.BackColor.Equals(Color.White) && key5.BackColor.Equals(Color.White) && key2.BackColor.Equals(Color.White))
            {
                richTextBox1.Text = richTextBox1.Text + "M";
            }
            if (key1.BackColor.Equals(Color.Aqua) && key3.BackColor.Equals(Color.Aqua) && key4.BackColor.Equals(Color.Aqua) && key5.BackColor.Equals(Color.Aqua) && key6.BackColor.Equals(Color.White) && key2.BackColor.Equals(Color.White))
            {
                richTextBox1.Text = richTextBox1.Text + "N";
            }
            if (key1.BackColor.Equals(Color.Aqua) && key3.BackColor.Equals(Color.Aqua) && key5.BackColor.Equals(Color.Aqua) && key2.BackColor.Equals(Color.White) && key6.BackColor.Equals(Color.White) && key4.BackColor.Equals(Color.White))
            {
                richTextBox1.Text = richTextBox1.Text + "O";
            }
            if (key1.BackColor.Equals(Color.Aqua) && key3.BackColor.Equals(Color.Aqua) && key4.BackColor.Equals(Color.Aqua) && key2.BackColor.Equals(Color.Aqua) && key5.BackColor.Equals(Color.White) && key6.BackColor.Equals(Color.White))
            {
                richTextBox1.Text = richTextBox1.Text + "P";
            }
            if (key1.BackColor.Equals(Color.Aqua) && key3.BackColor.Equals(Color.Aqua) && key4.BackColor.Equals(Color.Aqua) && key2.BackColor.Equals(Color.Aqua) && key5.BackColor.Equals(Color.Aqua) && key6.BackColor.Equals(Color.White))
            {
                richTextBox1.Text = richTextBox1.Text + "Q";
            }
            if (key1.BackColor.Equals(Color.Aqua) && key2.BackColor.Equals(Color.Aqua) && key3.BackColor.Equals(Color.Aqua) && key5.BackColor.Equals(Color.Aqua) && key4.BackColor.Equals(Color.White) && key6.BackColor.Equals(Color.White))
            {
                richTextBox1.Text = richTextBox1.Text + "R";
            }
            if (key2.BackColor.Equals(Color.Aqua) && key3.BackColor.Equals(Color.Aqua) && key4.BackColor.Equals(Color.Aqua) && key1.BackColor.Equals(Color.White) && key5.BackColor.Equals(Color.White) && key6.BackColor.Equals(Color.White))
            {
                richTextBox1.Text = richTextBox1.Text + "S";
            }
            if (key2.BackColor.Equals(Color.Aqua) && key3.BackColor.Equals(Color.Aqua) && key4.BackColor.Equals(Color.Aqua) && key5.BackColor.Equals(Color.Aqua) && key1.BackColor.Equals(Color.White) && key6.BackColor.Equals(Color.White))
            {
                richTextBox1.Text = richTextBox1.Text + "T";
            }
            if (key1.BackColor.Equals(Color.Aqua) && key3.BackColor.Equals(Color.Aqua) && key6.BackColor.Equals(Color.Aqua) && key2.BackColor.Equals(Color.White) && key4.BackColor.Equals(Color.White) && key5.BackColor.Equals(Color.White))
            {
                richTextBox1.Text = richTextBox1.Text + "U";
            }
            if (key2.BackColor.Equals(Color.Aqua) && key3.BackColor.Equals(Color.Aqua) && key1.BackColor.Equals(Color.Aqua) && key6.BackColor.Equals(Color.Aqua) && key4.BackColor.Equals(Color.White) && key5.BackColor.Equals(Color.White))
            {
                richTextBox1.Text = richTextBox1.Text + "V";
            }
            if (key2.BackColor.Equals(Color.Aqua) && key4.BackColor.Equals(Color.Aqua) && key5.BackColor.Equals(Color.Aqua) && key6.BackColor.Equals(Color.Aqua) && key1.BackColor.Equals(Color.White) && key3.BackColor.Equals(Color.White))
            {
                richTextBox1.Text = richTextBox1.Text + "W";
            }
            if (key1.BackColor.Equals(Color.Aqua) && key3.BackColor.Equals(Color.Aqua) && key4.BackColor.Equals(Color.Aqua) && key6.BackColor.Equals(Color.Aqua) && key2.BackColor.Equals(Color.White) && key5.BackColor.Equals(Color.White))
            {
                richTextBox1.Text = richTextBox1.Text + "X";
            }
            if (key1.BackColor.Equals(Color.Aqua) && key3.BackColor.Equals(Color.Aqua) && key4.BackColor.Equals(Color.Aqua) && key5.BackColor.Equals(Color.Aqua) && key6.BackColor.Equals(Color.Aqua) && key2.BackColor.Equals(Color.White))
            {
                richTextBox1.Text = richTextBox1.Text + "Y";
            }
            if (key1.BackColor.Equals(Color.Aqua) && key3.BackColor.Equals(Color.Aqua) && key5.BackColor.Equals(Color.Aqua) && key6.BackColor.Equals(Color.Aqua) && key2.BackColor.Equals(Color.White) && key4.BackColor.Equals(Color.White))
            {
                richTextBox1.Text = richTextBox1.Text + "Z";
            }
        }



        public void backBtn()
        {
            string x = richTextBox1.Text;
            if (x.Length > 0) { x = x.Remove(x.Length - 1); }
            
            richTextBox1.Text=x;
        }

        public void spaceBtn()
        {
            richTextBox1.Text = richTextBox1.Text + " ";
        }
        
        public void enterBtn()
        {
            richTextBox1.Text = richTextBox1.Text + "\n";
        }

        public void playSound()
        {
            SoundPlayer s = new SoundPlayer(@"C:\Users\SOUVIK\source\repos\HCI\HCI\audio-alphabet\A.wave");
            s.Play();
        }
    }
}