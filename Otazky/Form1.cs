using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Otazky
{
    public partial class Form1 : Form
    {
        Color col;
        Info info = new Info();
        private int score;
        public Form1()
        {
            InitializeComponent();
            col = label1.BackColor;
        }




        private void Form1_Load(object sender, EventArgs e)
        {
            label7.Text = "";
        }
       
       

        private void button1_Click(object sender, EventArgs e)
        {
            isFirst();
            isSecond();
            isThird();
            isFourth();
            isFifth();
            isSixth();
            label7.Text = "your score: "+score.ToString();
        }

        public void isFirst()
        {
            if (info.firstQestion.Equals(textBox1.Text.ToUpper()))
                score += 1;
            else label1.BackColor = Color.Red;
        }

        public void isSecond()
        {
            if (radioButton1.Checked == true)
            {
                score += 1;
            }
            else label2.BackColor = Color.Red;
        }
        public void isThird()
        {
            if (checkBox1.Checked == true && checkBox2.Checked == true)
            {
                score += 2;
            }
            else if(checkBox1.Checked != true || checkBox2.Checked != true)
            {
                 label3.BackColor = Color.Red;
            }
           else 
            {
                if (checkBox1.Checked == true)
                {
                    score += 1;
                }
                else if (checkBox2.Checked == true)
                {
                    score += 1;
                }

                
            }
           /* if (checkBox2.Checked == true)
            {
                score += 1;
            }*/
           
        }
        public void isFourth()
        {
            if (radioButton6.Checked == true)
            {
                score += 1;
            }
            else label4.BackColor = Color.Red;
        }
        public void isFifth()
        {
            if (comboBox1.SelectedItem == "Ring")
            {
                score += 1;
            }
            else label5.BackColor = Color.Red;
        }
        public void isSixth()
        {
            if ("1970-01-01" == dateTimePicker1.Value.ToString("yyyy-MM-dd") )
            {
                score += 1;
            }
            else label6.BackColor = Color.Red;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.BackColor = col;
            label2.BackColor = col;
            label3.BackColor = col; ;
            label4.BackColor = col;
            label5.BackColor = col;
            label6.BackColor = col;
            label7.BackColor = col;
            label7.Text = "";

        }
    }
}
