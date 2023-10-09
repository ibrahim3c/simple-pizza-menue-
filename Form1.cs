using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;

namespace pizza_project
{
    
    public partial class mainForm : Form
    {
        //private int d = 0;

        public void updateSize(string s)
        {
            lbs.Text = s;

        }
        public void updateTopping()
        {
            
            string t = "";
            int n = 0;
            if (ckOnion.Checked == true)
            {
                t += "Onion";
                if(n==2)
                {
                    t += "\n";
                }
                n++;
               
            }
            if (ckGreen.Checked == true)
            {
                t += ", Green Peppers";
               
                if (n == 2)
                {
                    t += "\n";
                }
                n++;

            }
           
            if (ckExtra.Checked == true)
            {
                t += ", Extra Cheese";
                
                if (n == 2)
                {
                    t += "\n";
                }
                n++;
            }
            if (ckMushrooms.Checked == true)
            {
                t += ", Mushrooms";
               
                if (n == 2)
                {
                    t += "\n";
                }
                n++;
            }
            if (ckTomatoes.Checked == true)
            {
                t += ", Tomatoes";
               
                if (n == 2)
                {
                    t += "\n";
                }
                n++;

            }
            if (ckOlives.Checked == true)
            {
                t += ",Olives";
               
                if (n == 2)
                {
                    t += "\n";
                }
                n++;

            }
            if (t == "") { lbt.Text = ""; }
            if(t.StartsWith(",")) { t = t.Substring(1); }

            lbt.Text = t;

        }

        public void updateCrust(string s)
        {
            lbc.Text = s;

        }
        public void updateWhere(string s)
        {
            lbw.Text = s;

        }
        public mainForm()
        {
            InitializeComponent();
        }
        float calculatePrice()
        {
            float price = 0;
            
            if (ckOnion.Checked == true) { price += int.Parse(ckOnion.Tag.ToString());
               
            }
            if (ckGreen.Checked == true) {price += int.Parse(ckGreen.Tag.ToString());
             
            }
            if (rdLarg.Checked == true) { price += int.Parse(rdLarg.Tag.ToString()); }
            if (rdSmall.Checked == true) {price += int.Parse(rdSmall.Tag.ToString()); }
            if (rdMedium.Checked == true) { price += int.Parse(rdMedium.Tag.ToString()); }
            if (ckExtra.Checked == true) {price += int.Parse(ckExtra.Tag.ToString());
                
            }
            if (ckMushrooms.Checked == true) { price += int.Parse(ckMushrooms.Tag.ToString());
               
            }
            if (ckTomatoes.Checked == true) {price += int.Parse(ckTomatoes.Tag.ToString());
               

            }
            if (ckOlives.Checked == true) { price += int.Parse(ckOlives.Tag.ToString());
                

            }
            if (rdThin.Checked == true) { price += int.Parse(rdThin.Tag.ToString()); }
            if (rdThick.Checked == true) { price += int.Parse(rdThick.Tag.ToString()); }


            return price;
        }
        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
           // updateTopping(" Onion");
           
            label6.Text = calculatePrice().ToString();
            updateTopping();


        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            //updateTopping(" Green Peppers");
            
            label6.Text = calculatePrice().ToString();
            updateTopping();




        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void rdSmall_CheckedChanged(object sender, EventArgs e)
        {
            updateSize("Small");
           
            label6.Text = calculatePrice().ToString();
           
        }

        private void rdMedium_CheckedChanged(object sender, EventArgs e)
        {
            updateSize("Medium");
            
            label6.Text = calculatePrice().ToString();

        }

        private void rdLarg_CheckedChanged(object sender, EventArgs e)
        {
            updateSize("Larg");
            
            label6.Text = calculatePrice().ToString();



        }

        private void gpCrust_Enter(object sender, EventArgs e)
        {

        }

        private void gpSize_Enter(object sender, EventArgs e)
        {
           

        }

        private void lbs_Click(object sender, EventArgs e)
        {
           
        }

        private void gpOrder_Enter(object sender, EventArgs e)
        {

        }
        private  void updateALL()
        {
            updateCrust("Thin Crust");
            rdThin.Checked = true;
            updateSize("Small");
            rdSmall.Checked = true;
            updateTopping();
            updateWhere("Eat in");
            rdIn.Checked = true;
            calculatePrice();

        }
        private void mainForm_Load(object sender, EventArgs e)
        {
            updateALL();

        }

        private void ckExtra_CheckedChanged(object sender, EventArgs e)
        {
            //updateTopping(" Extra Cheese");
           
            label6.Text = calculatePrice().ToString();
            updateTopping();


        }

        private void ckMushrooms_CheckedChanged(object sender, EventArgs e)
        {
            //updateTopping(" Mushrooms");
            
            label6.Text = calculatePrice().ToString();
            updateTopping();


        }

        private void ckTomatoes_CheckedChanged(object sender, EventArgs e)
        {
            //updateTopping(" Tomatoes");
           
            label6.Text = calculatePrice().ToString();
            updateTopping();



        }

        private void ckOlives_CheckedChanged(object sender, EventArgs e)
        {
            //updateTopping(" Olives");
            
            label6.Text = calculatePrice().ToString();
            updateTopping();


        }

        private void rdIn_CheckedChanged(object sender, EventArgs e)
        {
            updateWhere("Eat in");
        }

        private void rbTake_CheckedChanged(object sender, EventArgs e)
        {
            updateWhere("Take out");
        }

        private void rdThin_CheckedChanged(object sender, EventArgs e)
        {
            updateCrust("Thin");
            
            label6.Text = calculatePrice().ToString();

        }

        private void rdThick_CheckedChanged(object sender, EventArgs e)
        {
            updateCrust("Thick");
            
            label6.Text = calculatePrice().ToString();


        }

        private void button1_Click(object sender, EventArgs e)
        {
          if(  MessageBox.Show("do you confirm ", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.OK)
            {
                MessageBox.Show("your order is done ");
                button1.Enabled = false;
                gpSize.Enabled = false;
                gpToppings.Enabled = false;
                gpSize.Enabled = false;
                gpCrust.Enabled = false;
                gpWhere.Enabled = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {    // reset groups
            button1.Enabled = true;
            gpSize.Enabled = true;
            gpToppings.Enabled = true;
            gpSize.Enabled = true;
            gpCrust.Enabled = true;
            gpWhere.Enabled = true;
            //reset toppings
            ckGreen.Checked = false;
            ckExtra.Checked = false;
            ckMushrooms.Checked = false;
            ckOlives.Checked = false;
            ckOnion.Checked = false;
            ckTomatoes.Checked = false;
            //reset where
            rdIn.Checked = true;
            //reset crust
            rdThin.Checked = true;
            //reset size
            rdSmall.Checked = true;
          
        }

        private void lbw_Click(object sender, EventArgs e)
        {

        }

        private void lbPrice_Click(object sender, EventArgs e)
        {

        }
    }
}
