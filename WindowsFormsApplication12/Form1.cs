using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 s = new Form2();
            s.Show();
            this.Hide();

            string st = textBox1.Text; 
            int vp, urdu, dbms, ds, coa, math, total;
            double per;
            vp = Convert.ToInt32(textBox2.Text);
            urdu = Convert.ToInt32(textBox3.Text); 
            dbms = Convert.ToInt32(textBox4.Text);
            ds = Convert.ToInt32(textBox5.Text);
            coa = Convert.ToInt32(textBox6.Text);
            math = Convert.ToInt32(textBox7.Text);
            total = vp + urdu + dbms + ds + coa + math;
            per = (total * 100 )/ 600;
            s.label1.Text = "Student Name=" + st + "\n" + "VP=" + vp + "\n" + "URDU=" + urdu +
                "\n" + "DBMS=" + dbms + "\n" + "DS=" + ds + "\n" + "COA=" + coa + "\n" +"MATH="+ math + "\n";
            s.textBox1.Text = total.ToString();
            s.textBox2.Text = per.ToString();

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.Bisque;

        }
    }
}
