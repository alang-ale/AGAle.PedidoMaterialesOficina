namespace AGAle.PedidoMaterialesOficina.GeneracionOrdenDeCompra
{
    partial class GeneracionOrdenDeCompraForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ListViewItem listViewItem13 = new ListViewItem(new string[] { "RES-BL-001", "Resma de hojas", "5", "$8.000", "$40.000" }, -1);
            ListViewItem listViewItem14 = new ListViewItem(new string[] { "LAP-AZ-001", "Lapicera", "100", "$1.000", "$100.000" }, -1);
            ListViewItem listViewItem15 = new ListViewItem(new string[] { "CU-RO-003", "Cuaderno cuadriculado", "$5.000" }, -1);
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            comboBox1 = new ComboBox();
            listView1 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            textBox2 = new TextBox();
            label3 = new Label();
            SKU = new ColumnHeader();
            listView2 = new ListView();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            columnHeader8 = new ColumnHeader();
            button2 = new Button();
            button1 = new Button();
            textBox3 = new TextBox();
            label4 = new Label();
            button3 = new Button();
            button4 = new Button();
            label5 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 25);
            label1.Name = "label1";
            label1.Size = new Size(127, 20);
            label1.TabIndex = 24;
            label1.Text = "Numero de orden";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 66);
            label2.Name = "label2";
            label2.Size = new Size(77, 20);
            label2.TabIndex = 25;
            label2.Text = "Proveedor";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(171, 22);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(101, 27);
            textBox1.TabIndex = 27;
            textBox1.Text = "OC-123";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(171, 63);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(225, 28);
            comboBox1.TabIndex = 28;
            comboBox1.Text = "Librería xi";
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { SKU, columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            listViewItem14.Tag = "";
            listView1.Items.AddRange(new ListViewItem[] { listViewItem13, listViewItem14 });
            listView1.Location = new Point(12, 327);
            listView1.Name = "listView1";
            listView1.Size = new Size(742, 139);
            listView1.TabIndex = 29;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Item";
            columnHeader1.Width = 300;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Cantidad";
            columnHeader2.Width = 90;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Precio unitario";
            columnHeader3.Width = 120;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Total";
            columnHeader4.Width = 100;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(541, 64);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(225, 27);
            textBox2.TabIndex = 31;
            textBox2.Text = "30-71123456-8";
            textBox2.TextChanged += this.textBox2_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(466, 67);
            label3.Name = "label3";
            label3.Size = new Size(40, 20);
            label3.TabIndex = 30;
            label3.Text = "CUIT";
            label3.Click += this.label3_Click;
            // 
            // SKU
            // 
            SKU.Text = "SKU";
            SKU.Width = 120;
            // 
            // listView2
            // 
            listView2.Columns.AddRange(new ColumnHeader[] { columnHeader5, columnHeader6, columnHeader8 });
            listViewItem15.Tag = "";
            listView2.Items.AddRange(new ListViewItem[] { listViewItem15 });
            listView2.Location = new Point(12, 162);
            listView2.Name = "listView2";
            listView2.Size = new Size(742, 139);
            listView2.TabIndex = 32;
            listView2.UseCompatibleStateImageBehavior = false;
            listView2.View = View.Details;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "SKU";
            columnHeader5.Width = 120;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Item";
            columnHeader6.Width = 300;
            // 
            // columnHeader8
            // 
            columnHeader8.Text = "Precio unitario";
            columnHeader8.Width = 120;
            // 
            // button2
            // 
            button2.Location = new Point(560, 549);
            button2.Name = "button2";
            button2.Size = new Size(219, 29);
            button2.TabIndex = 34;
            button2.Text = "Generar orden de compra";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(789, 549);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 33;
            button1.Text = "Cancelar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(159, 126);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(101, 27);
            textBox3.TabIndex = 36;
            textBox3.Text = "CU-RO-003";
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 129);
            label4.Name = "label4";
            label4.Size = new Size(110, 20);
            label4.TabIndex = 35;
            label4.Text = "Buscar por SKU";
            label4.Click += this.label4_Click;
            // 
            // button3
            // 
            button3.Location = new Point(760, 206);
            button3.Name = "button3";
            button3.Size = new Size(128, 29);
            button3.TabIndex = 37;
            button3.Text = "Agregar a orden";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(760, 377);
            button4.Name = "button4";
            button4.Size = new Size(128, 29);
            button4.TabIndex = 38;
            button4.Text = "Quitar producto";
            button4.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(631, 489);
            label5.Name = "label5";
            label5.Size = new Size(252, 41);
            label5.TabIndex = 39;
            label5.Text = "TOTAL: $140.000";
            // 
            // GeneracionOrdenDeCompraForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(897, 590);
            Controls.Add(label5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(textBox3);
            Controls.Add(label4);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(listView2);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(listView1);
            Controls.Add(comboBox1);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "GeneracionOrdenDeCompraForm";
            Text = "Generación de orden de compra";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private ComboBox comboBox1;
        private ListView listView1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader SKU;
        private TextBox textBox2;
        private Label label3;
        private ListView listView2;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader8;
        private Button button2;
        private Button button1;
        private TextBox textBox3;
        private Label label4;
        private Button button3;
        private Button button4;
        private Label label5;
    }
}