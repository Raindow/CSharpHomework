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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try {
                Form1 form1 = (Form1)this.Owner;
                Order order = (Order)form1.DataGridView1.CurrentRow.DataBoundItem;
                form1.orderService.addOrderGoods(order.ID, textBox1.Text, textBox3.Text, textBox2.Text);
                form1.OrderBindingSource.ResetBindings(false);
            }
            catch (Exception ex) {
                DialogResult result = MessageBox.Show(ex.Message + "\nsomething wrong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally {
                textBox1.Text = null;
                textBox2.Text = null;
                textBox3.Text = null;
            }
        }
    }
}
