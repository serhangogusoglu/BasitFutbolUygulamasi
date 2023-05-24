using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace csharpaRANDOM
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        Random rastgele = new Random();

        int bjkpuan = 0;
        int gspuan = 0;
        int fbpuan = 0;
        int tspuan = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            int a = rastgele.Next(0,5);
            int b = rastgele.Next(0, 5);
            int c = rastgele.Next(0, 5);
            int d = rastgele.Next(0, 5);

            label5.Text = a.ToString();
            label6.Text = b.ToString();
            label8.Text = c.ToString();
            label4.Text = d.ToString();

            if(Convert.ToInt32(label5.Text) > Convert.ToInt32(label6.Text)) 
            {
                gspuan = gspuan + 3;
                label11.Text = gspuan.ToString();
            }
            if (Convert.ToInt32(label6.Text) > Convert.ToInt32(label5.Text)) 
            { 
             bjkpuan = bjkpuan + 3;
                label16.Text = bjkpuan.ToString();

            }

            if(Convert.ToInt32(label5.Text )== Convert.ToInt32(label6.Text)) 
           {
                gspuan = gspuan + 1;
                bjkpuan=bjkpuan + 1;
                label11.Text =gspuan.ToString();
                label16.Text =bjkpuan.ToString();
            
            }

            if (Convert.ToInt32(label8.Text) > Convert.ToInt32(label4.Text))
            { 
            fbpuan = fbpuan + 3;
                label15.Text = fbpuan.ToString();
            }

            if (Convert.ToInt32(label4.Text) > Convert.ToInt32(label8.Text))
             {
              tspuan = tspuan + 3;
                label12.Text = tspuan.ToString();
            }

            if (Convert.ToInt32(label4.Text) == Convert.ToInt32(label8.Text))
                {
                fbpuan = fbpuan + 1;
                tspuan=tspuan + 1;
                label15.Text=fbpuan.ToString();
                label12.Text=tspuan.ToString();
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {

            button2.Enabled = false;
            int a = rastgele.Next(0, 5);
            int b = rastgele.Next(0, 5);
            int c = rastgele.Next(0, 5);
            int d = rastgele.Next(0, 5);

            label24.Text = a.ToString();
            label14.Text = b.ToString();
            label23.Text = c.ToString();
            label13.Text = d.ToString();



            if (Convert.ToInt32(label24.Text) > Convert.ToInt32(label4.Text))
            {
                gspuan = gspuan + 3;
                label11.Text = gspuan.ToString();
            }
            if (Convert.ToInt32(label14.Text) > Convert.ToInt32(label24.Text))
            {
                fbpuan = fbpuan + 3;
                label15.Text = fbpuan.ToString();

            }

            if (Convert.ToInt32(label24.Text) == Convert.ToInt32(label14.Text))
            {
                gspuan = gspuan + 1;
                fbpuan = fbpuan + 1;
                label11.Text = gspuan.ToString();
                label15.Text = bjkpuan.ToString();

            }

            if (Convert.ToInt32(label23.Text) > Convert.ToInt32(label13.Text))
            {
                bjkpuan = bjkpuan + 3;
                label16.Text = bjkpuan.ToString();
            }
            if (Convert.ToInt32(label13.Text) > Convert.ToInt32(label23.Text))
            {
                tspuan = tspuan + 3;
                label12.Text = tspuan.ToString();

            }

            if (Convert.ToInt32(label23.Text) == Convert.ToInt32(label13.Text))
            {
                gspuan = gspuan + 1;
                fbpuan = fbpuan + 1;
                label16.Text = bjkpuan.ToString();
                label12.Text = tspuan.ToString();

            }








        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.Enabled = false;
            int a = rastgele.Next(0, 5);
            int b = rastgele.Next(0, 5);
            int c = rastgele.Next(0, 5);
            int d = rastgele.Next(0, 5);

            label34.Text = a.ToString();
            label30.Text = b.ToString();
            label33.Text = c.ToString();
            label29.Text = d.ToString();



            if (Convert.ToInt32(label34.Text) > Convert.ToInt32(label30.Text))
            {
                tspuan = tspuan + 3;
                label12.Text = tspuan.ToString();
            }
            if (Convert.ToInt32(label30.Text) > Convert.ToInt32(label34.Text))
            {
                bjkpuan = bjkpuan + 3;
                label16.Text = bjkpuan.ToString();

            }

            if (Convert.ToInt32(label34.Text) == Convert.ToInt32(label30.Text))
            {
                tspuan = tspuan + 1;
                bjkpuan = bjkpuan + 1;
                label12.Text = tspuan.ToString();
                label16.Text = bjkpuan.ToString();

            }

            if (Convert.ToInt32(label33.Text) > Convert.ToInt32(label29.Text))
            {
                fbpuan = fbpuan + 3;
                label15.Text = fbpuan.ToString();
            }
            if (Convert.ToInt32(label29.Text) > Convert.ToInt32(label33.Text))
            {
                gspuan = gspuan + 3;
                label11.Text = gspuan.ToString();

            }

            if (Convert.ToInt32(label33.Text) == Convert.ToInt32(label29.Text))
            {
                fbpuan = fbpuan + 1;
                gspuan = gspuan + 1;
                label11.Text = gspuan.ToString();
                label15.Text = fbpuan.ToString();

            }

        }
    }
}


