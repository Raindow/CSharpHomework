using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassAboutOrder;

namespace program1
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try {
                Form1 form1 = (Form1)this.Owner;
                Order order = (Order)form1.DataGridView1.CurrentRow.DataBoundItem;
                Good good = (Good)form1.DataGridView2.CurrentRow.DataBoundItem;
                form1.orderService.renewOrderGoods(order.CustomerName, good.Name, textBox1.Text, textBox2.Text);
                form1.OrderBindingSource.ResetBindings(false);
            }
            catch (Exception ex) {
                DialogResult result = MessageBox.Show(ex.Message + "\nyou have input " + this.textBox1.Text + " and " + this.textBox2.Text, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally {
                this.textBox1.Text = null;
                this.textBox2.Text = null;
            }

        }
    }
}
