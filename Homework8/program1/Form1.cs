using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.XPath;
using System.Xml.Xsl;

namespace program1
{
    public partial class Form1 : Form
    {
        public OrderService orderService = new OrderService();

        public void getDGVUpdate()
        {
            this.orderBindingSource.DataSource = new List<Order>();
            this.orderBindingSource.DataSource = orderService.OrderList;
        }
        public DataGridView DataGridView1
        {
            get {
                return this.dataGridView1;
            }
        }
        public DataGridView DataGridView2
        {
            get {
                return this.dataGridView2;
            }
        }
        public BindingSource OrderBindingSource
        {
            get {
                return this.orderBindingSource;
            }
        }
        public Form1()
        {
            Order order1 = new Order {
                CustomerName = "001",
                PhoneNum = "12345678987"
            };
            order1.OrderDetails.TotalPrice = 1;
            orderService.addOrder(order1);
            orderService.addOrderGoods("001", "hu", "86", "5");
            orderService.addOrderGoods("001", "hf", "85", "5");
            orderService.addOrderGoods("001", "a", "6", "5");


            Order order2 = new Order {
                CustomerName = "002"
            };
            orderService.addOrder(order2);

            Order order3 = new Order {
                CustomerName = "003"
            };
            orderService.addOrder(order3);


            InitializeComponent();
            this.Resize += new System.EventHandler(this.Form1_Load);
            this.ResizeEnd += new System.EventHandler(this.Form1_Load);
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataGridView1.ColumnHeadersHeight = (this.dataGridView2.ColumnHeadersHeight + 订单详情功能框.Height);
            this.orderBindingSource.DataSource = orderService.OrderList;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataGridView1.ColumnHeadersHeight = (this.dataGridView2.ColumnHeadersHeight + 订单详情功能框.Height);
            if (订单详情功能框.Height < 4) {
                this.dataGridView2.ColumnHeadersHeight = 4;
            } else {
                this.dataGridView2.ColumnHeadersHeight = 订单详情功能框.Height;
            }
        }

        private void 查询_Click(object sender, EventArgs e)
        {
            try {
                if (this.textBox1.Text != "") {
                    orderBindingSource.DataSource = orderService.seekOrder(this.textBox1.Text);
                } else {
                    this.getDGVUpdate();
                }
            }
            catch (Exception ex) {
                DialogResult result = MessageBox.Show(ex.Message + "you have input" + this.textBox1.Text + "there is no such thing", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally {
                this.textBox1.Text = "";
            }

        }

        private void 删除_Click(object sender, EventArgs e)
        {
            try {
                if (this.textBox1.Text != "") {
                    orderService.deleteOrder(this.textBox1.Text);
                }

                //this.dataGridView1.Rows.Clear();
                //this.orderBindingSource.DataSource = orderService.OrderList;
                //this.dataGridView1.DataSource = orderBindingSource;
                //this.orderBindingSource.Clear();
                //this.getDGVUpdate();
                this.orderBindingSource.ResetBindings(false);
            }
            catch (Exception ex) {
                string text = @textBox1.Text;
                DialogResult result = MessageBox.Show(ex.Message + "you have input " + text + " there is no such thing", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally {
                this.textBox1.Text = "";
            }
        }

        private void 添加_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Owner = this;
            form2.Show();
            this.Visible = false;
        }


        private void 删除商品_Click(object sender, EventArgs e)
        {
            try {
                Order order = (Order)this.dataGridView1.CurrentRow.DataBoundItem;
                this.orderService.deleteOrderGoods(order.CustomerName, (this.dataGridView2.CurrentCellAddress.X + 1).ToString());
                this.orderBindingSource.ResetBindings(false);
            }
            catch (Exception ex) {
                DialogResult result = MessageBox.Show(ex.Message + " there is nothing", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void 添加商品_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Owner = this;
            form3.Show();
        }

        private void 查询商品_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Owner = this;
            form4.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            orderService.Export("temp");
            XmlDocument doc = new XmlDocument();
            doc.Load(@".\temp");

            XPathNavigator nav = doc.CreateNavigator();
            nav.MoveToRoot();

            XslCompiledTransform xt = new XslCompiledTransform();
            xt.Load(@".\temp.xslt");

            XmlTextWriter xmlTextWriter = new XmlTextWriter("orderSevice.html", Encoding.BigEndianUnicode);

            xt.Transform(nav, null, xmlTextWriter);

            xmlTextWriter.Close();
        }
    }
}
