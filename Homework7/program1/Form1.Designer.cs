namespace program1
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.seekorder = new System.Windows.Forms.Panel();
            this.查询 = new System.Windows.Forms.Button();
            this.删除 = new System.Windows.Forms.Button();
            this.添加 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.totalPrice = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.总价 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.orderDetail = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.订单详情功能框 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.查询商品 = new System.Windows.Forms.Button();
            this.panel10 = new System.Windows.Forms.Panel();
            this.删除商品 = new System.Windows.Forms.Button();
            this.添加商品框 = new System.Windows.Forms.Panel();
            this.添加商品 = new System.Windows.Forms.Button();
            this.订单详情 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.order = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel4.SuspendLayout();
            this.seekorder.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.orderDetail.SuspendLayout();
            this.panel9.SuspendLayout();
            this.订单详情功能框.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel10.SuspendLayout();
            this.添加商品框.SuspendLayout();
            this.订单详情.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.order.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(35, 492);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(897, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(35, 492);
            this.panel3.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.seekorder);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(35, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(862, 40);
            this.panel4.TabIndex = 3;
            // 
            // seekorder
            // 
            this.seekorder.Controls.Add(this.查询);
            this.seekorder.Controls.Add(this.删除);
            this.seekorder.Controls.Add(this.添加);
            this.seekorder.Controls.Add(this.textBox1);
            this.seekorder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.seekorder.Location = new System.Drawing.Point(0, 0);
            this.seekorder.Name = "seekorder";
            this.seekorder.Size = new System.Drawing.Size(858, 36);
            this.seekorder.TabIndex = 0;
            // 
            // 查询
            // 
            this.查询.Dock = System.Windows.Forms.DockStyle.Right;
            this.查询.Location = new System.Drawing.Point(633, 0);
            this.查询.Name = "查询";
            this.查询.Size = new System.Drawing.Size(75, 36);
            this.查询.TabIndex = 3;
            this.查询.Text = "查询";
            this.查询.UseVisualStyleBackColor = true;
            this.查询.Click += new System.EventHandler(this.查询_Click);
            // 
            // 删除
            // 
            this.删除.Dock = System.Windows.Forms.DockStyle.Right;
            this.删除.Location = new System.Drawing.Point(708, 0);
            this.删除.Name = "删除";
            this.删除.Size = new System.Drawing.Size(75, 36);
            this.删除.TabIndex = 2;
            this.删除.Text = "删除";
            this.删除.UseVisualStyleBackColor = true;
            this.删除.Click += new System.EventHandler(this.删除_Click);
            // 
            // 添加
            // 
            this.添加.Dock = System.Windows.Forms.DockStyle.Right;
            this.添加.Location = new System.Drawing.Point(783, 0);
            this.添加.Name = "添加";
            this.添加.Size = new System.Drawing.Size(75, 36);
            this.添加.TabIndex = 1;
            this.添加.Text = "添加";
            this.添加.UseVisualStyleBackColor = true;
            this.添加.Click += new System.EventHandler(this.添加_Click);
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Font = new System.Drawing.Font("宋体", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox1.Location = new System.Drawing.Point(0, 0);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(858, 41);
            this.textBox1.TabIndex = 0;
            this.textBox1.WordWrap = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 413);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(862, 39);
            this.panel1.TabIndex = 0;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.totalPrice);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel7.Location = new System.Drawing.Point(212, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(650, 39);
            this.panel7.TabIndex = 1;
            // 
            // totalPrice
            // 
            this.totalPrice.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orderBindingSource, "GoodsTotalPrice", true));
            this.totalPrice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.totalPrice.Font = new System.Drawing.Font("幼圆", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.totalPrice.Location = new System.Drawing.Point(0, 0);
            this.totalPrice.Name = "totalPrice";
            this.totalPrice.Size = new System.Drawing.Size(650, 39);
            this.totalPrice.TabIndex = 0;
            this.totalPrice.Text = "label2";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.总价);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(212, 39);
            this.panel6.TabIndex = 0;
            // 
            // 总价
            // 
            this.总价.Dock = System.Windows.Forms.DockStyle.Fill;
            this.总价.Font = new System.Drawing.Font("幼圆", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.总价.Location = new System.Drawing.Point(0, 0);
            this.总价.Name = "总价";
            this.总价.Size = new System.Drawing.Size(212, 39);
            this.总价.TabIndex = 0;
            this.总价.Text = "Goods Total price:";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.orderDetail);
            this.panel5.Controls.Add(this.order);
            this.panel5.Controls.Add(this.panel1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(35, 40);
            this.panel5.Margin = new System.Windows.Forms.Padding(2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(862, 452);
            this.panel5.TabIndex = 4;
            // 
            // orderDetail
            // 
            this.orderDetail.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.orderDetail.Controls.Add(this.panel9);
            this.orderDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.orderDetail.Location = new System.Drawing.Point(191, 0);
            this.orderDetail.Margin = new System.Windows.Forms.Padding(0);
            this.orderDetail.Name = "orderDetail";
            this.orderDetail.Size = new System.Drawing.Size(671, 413);
            this.orderDetail.TabIndex = 2;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.订单详情功能框);
            this.panel9.Controls.Add(this.dataGridView2);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel9.Location = new System.Drawing.Point(0, 0);
            this.panel9.Margin = new System.Windows.Forms.Padding(0);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(667, 409);
            this.panel9.TabIndex = 1;
            // 
            // 订单详情功能框
            // 
            this.订单详情功能框.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.订单详情功能框.Controls.Add(this.panel11);
            this.订单详情功能框.Controls.Add(this.panel10);
            this.订单详情功能框.Controls.Add(this.添加商品框);
            this.订单详情功能框.Controls.Add(this.订单详情);
            this.订单详情功能框.Dock = System.Windows.Forms.DockStyle.Fill;
            this.订单详情功能框.Location = new System.Drawing.Point(0, 0);
            this.订单详情功能框.Margin = new System.Windows.Forms.Padding(0);
            this.订单详情功能框.Name = "订单详情功能框";
            this.订单详情功能框.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.订单详情功能框.Size = new System.Drawing.Size(667, 26);
            this.订单详情功能框.TabIndex = 0;
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.查询商品);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel11.Location = new System.Drawing.Point(441, 0);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(75, 24);
            this.panel11.TabIndex = 3;
            // 
            // 查询商品
            // 
            this.查询商品.Dock = System.Windows.Forms.DockStyle.Fill;
            this.查询商品.Location = new System.Drawing.Point(0, 0);
            this.查询商品.Name = "查询商品";
            this.查询商品.Size = new System.Drawing.Size(75, 24);
            this.查询商品.TabIndex = 0;
            this.查询商品.Text = "修改";
            this.查询商品.UseVisualStyleBackColor = true;
            this.查询商品.Click += new System.EventHandler(this.查询商品_Click);
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.删除商品);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel10.Location = new System.Drawing.Point(516, 0);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(75, 24);
            this.panel10.TabIndex = 2;
            // 
            // 删除商品
            // 
            this.删除商品.Dock = System.Windows.Forms.DockStyle.Fill;
            this.删除商品.Location = new System.Drawing.Point(0, 0);
            this.删除商品.Name = "删除商品";
            this.删除商品.Size = new System.Drawing.Size(75, 24);
            this.删除商品.TabIndex = 0;
            this.删除商品.Text = "删除商品";
            this.删除商品.UseVisualStyleBackColor = true;
            this.删除商品.Click += new System.EventHandler(this.删除商品_Click);
            // 
            // 添加商品框
            // 
            this.添加商品框.Controls.Add(this.添加商品);
            this.添加商品框.Dock = System.Windows.Forms.DockStyle.Right;
            this.添加商品框.Location = new System.Drawing.Point(591, 0);
            this.添加商品框.Name = "添加商品框";
            this.添加商品框.Size = new System.Drawing.Size(74, 24);
            this.添加商品框.TabIndex = 1;
            // 
            // 添加商品
            // 
            this.添加商品.Dock = System.Windows.Forms.DockStyle.Fill;
            this.添加商品.Location = new System.Drawing.Point(0, 0);
            this.添加商品.Name = "添加商品";
            this.添加商品.Size = new System.Drawing.Size(74, 24);
            this.添加商品.TabIndex = 0;
            this.添加商品.Text = "添加商品";
            this.添加商品.UseVisualStyleBackColor = true;
            this.添加商品.Click += new System.EventHandler(this.添加商品_Click);
            // 
            // 订单详情
            // 
            this.订单详情.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.订单详情.Controls.Add(this.label1);
            this.订单详情.Dock = System.Windows.Forms.DockStyle.Fill;
            this.订单详情.Location = new System.Drawing.Point(0, 0);
            this.订单详情.Name = "订单详情";
            this.订单详情.Size = new System.Drawing.Size(665, 24);
            this.订单详情.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.MinimumSize = new System.Drawing.Size(0, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(665, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "订单详情";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn3,
            this.quantityDataGridViewTextBoxColumn,
            this.uPriceDataGridViewTextBoxColumn,
            this.tPriceDataGridViewTextBoxColumn});
            this.dataGridView2.DataMember = "Goods";
            this.dataGridView2.DataSource = this.orderBindingSource;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView2.Location = new System.Drawing.Point(0, 26);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dataGridView2.RowTemplate.Height = 27;
            this.dataGridView2.Size = new System.Drawing.Size(667, 383);
            this.dataGridView2.TabIndex = 0;
            // 
            // order
            // 
            this.order.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.order.Controls.Add(this.dataGridView1);
            this.order.Dock = System.Windows.Forms.DockStyle.Left;
            this.order.Location = new System.Drawing.Point(0, 0);
            this.order.Margin = new System.Windows.Forms.Padding(0);
            this.order.Name = "order";
            this.order.Size = new System.Drawing.Size(191, 413);
            this.order.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.dataGridView1.DataSource = this.orderBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(187, 409);
            this.dataGridView1.TabIndex = 0;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.Frozen = true;
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Width = 54;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn3.Frozen = true;
            this.dataGridViewTextBoxColumn3.HeaderText = "Id";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 42;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.Frozen = true;
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            this.quantityDataGridViewTextBoxColumn.ReadOnly = true;
            this.quantityDataGridViewTextBoxColumn.Width = 78;
            // 
            // uPriceDataGridViewTextBoxColumn
            // 
            this.uPriceDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.uPriceDataGridViewTextBoxColumn.DataPropertyName = "UPrice";
            this.uPriceDataGridViewTextBoxColumn.Frozen = true;
            this.uPriceDataGridViewTextBoxColumn.HeaderText = "Unit Price";
            this.uPriceDataGridViewTextBoxColumn.Name = "uPriceDataGridViewTextBoxColumn";
            this.uPriceDataGridViewTextBoxColumn.ReadOnly = true;
            this.uPriceDataGridViewTextBoxColumn.Width = 90;
            // 
            // tPriceDataGridViewTextBoxColumn
            // 
            this.tPriceDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tPriceDataGridViewTextBoxColumn.DataPropertyName = "TPrice";
            this.tPriceDataGridViewTextBoxColumn.HeaderText = "Good Total Price";
            this.tPriceDataGridViewTextBoxColumn.Name = "tPriceDataGridViewTextBoxColumn";
            this.tPriceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // orderBindingSource
            // 
            this.orderBindingSource.DataSource = typeof(program1.Order);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 42;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "CustomerName";
            this.dataGridViewTextBoxColumn2.HeaderText = "CustomerName";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 492);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel4.ResumeLayout(false);
            this.seekorder.ResumeLayout(false);
            this.seekorder.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.orderDetail.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.订单详情功能框.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.添加商品框.ResumeLayout(false);
            this.订单详情.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.order.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel orderDetail;
        private System.Windows.Forms.Panel order;
        private System.Windows.Forms.Panel 订单详情功能框;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Panel seekorder;
        private System.Windows.Forms.Button 添加;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button 查询;
        private System.Windows.Forms.Button 删除;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel 添加商品框;
        private System.Windows.Forms.Panel 订单详情;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button 查询商品;
        private System.Windows.Forms.Button 删除商品;
        private System.Windows.Forms.Button 添加商品;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label totalPrice;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label 总价;
        private System.Windows.Forms.DataGridViewTextBoxColumn cusNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderNumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderDetailsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource orderBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}

