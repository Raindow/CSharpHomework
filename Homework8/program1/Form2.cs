using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace program1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try {
                Order order = new Order {
                    CustomerName = textBox1.Text,
                    PhoneNum = textBox2.Text
                };
                Form1 form1 = (Form1)this.Owner;
                form1.orderService.addOrder(order);
                DialogResult result = MessageBox.Show("excellent", "Congratulation", MessageBoxButtons.OK, MessageBoxIcon.None);

            }
            catch(Exception ex) {
                DialogResult result = MessageBox.Show(ex.Message + "you have input " + this.textBox1.Text + " and "  + this.textBox2.Text, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally {
                this.textBox1.Text = "";
                this.textBox2.Text = "";
            }
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form1 = (Form1)this.Owner;
            form1.getDGVUpdate();
            form1.Visible = true;
            this.Close();
        }
    }
}
