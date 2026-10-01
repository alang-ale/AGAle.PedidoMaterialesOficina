namespace AGAle.PedidoMaterialesOficina.GestionEntregaMateriales
{
    partial class GestionEntregaInsumosForm
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
            ListViewItem listViewItem1 = new ListViewItem(new string[] { "159", "29/09/2026", "Recursos humanos", "Media", "En preparación" }, -1);
            ListViewItem listViewItem2 = new ListViewItem(new string[] { "160", "30/09/2026", "Depósito", "Baja", "Pendiente" }, -1);
            ListViewItem listViewItem3 = new ListViewItem(new string[] { "CU-RO-003", "Cuaderno cuadriculado", "5" }, -1);
            listView1 = new ListView();
            columnHeader2 = new ColumnHeader();
            columnHeader1 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            listView3 = new ListView();
            columnHeader11 = new ColumnHeader();
            columnHeader12 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            label1 = new Label();
            label2 = new Label();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            button1 = new Button();
            button4 = new Button();
            comboBox2 = new ComboBox();
            label3 = new Label();
            groupBox1 = new GroupBox();
            label4 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader2, columnHeader1, columnHeader3, columnHeader4, columnHeader5 });
            listView1.Items.AddRange(new ListViewItem[] { listViewItem1, listViewItem2 });
            listView1.Location = new Point(12, 64);
            listView1.Name = "listView1";
            listView1.Size = new Size(776, 115);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "N° solicitud";
            columnHeader2.Width = 100;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Fecha aprobación";
            columnHeader1.Width = 200;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Área";
            columnHeader3.Width = 150;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Prioridad";
            columnHeader4.Width = 100;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Estado";
            columnHeader5.Width = 120;
            // 
            // listView3
            // 
            listView3.Activation = ItemActivation.OneClick;
            listView3.CheckBoxes = true;
            listView3.Columns.AddRange(new ColumnHeader[] { columnHeader11, columnHeader12, columnHeader6 });
            listView3.HotTracking = true;
            listView3.HoverSelection = true;
            listViewItem3.StateImageIndex = 0;
            listViewItem3.Tag = "";
            listView3.Items.AddRange(new ListViewItem[] { listViewItem3 });
            listView3.Location = new Point(12, 275);
            listView3.Name = "listView3";
            listView3.Size = new Size(776, 139);
            listView3.TabIndex = 33;
            listView3.UseCompatibleStateImageBehavior = false;
            listView3.UseWaitCursor = true;
            listView3.View = View.Details;
            // 
            // columnHeader11
            // 
            columnHeader11.Text = "SKU";
            columnHeader11.Width = 120;
            // 
            // columnHeader12
            // 
            columnHeader12.Text = "Item";
            columnHeader12.Width = 300;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Cantidad";
            columnHeader6.Width = 100;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 241);
            label1.Name = "label1";
            label1.Size = new Size(133, 20);
            label1.TabIndex = 34;
            label1.Text = "Detalle de entrega";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 32);
            label2.Name = "label2";
            label2.Size = new Size(131, 20);
            label2.TabIndex = 35;
            label2.Text = "Entregas entrantes";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(13, 50);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(99, 24);
            radioButton1.TabIndex = 37;
            radioButton1.TabStop = true;
            radioButton1.Text = "Entregado";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(13, 21);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(130, 24);
            radioButton2.TabIndex = 38;
            radioButton2.TabStop = true;
            radioButton2.Text = "En preparación";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(693, 540);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 40;
            button1.Text = "Cancelar";
            button1.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(582, 540);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 42;
            button4.Text = "Guardar";
            button4.UseVisualStyleBackColor = true;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(701, 26);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(82, 28);
            comboBox2.TabIndex = 43;
            comboBox2.Text = "Todos";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(641, 26);
            label3.Name = "label3";
            label3.Size = new Size(43, 20);
            label3.TabIndex = 44;
            label3.Text = "Filtro";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Location = new Point(533, 442);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(250, 92);
            groupBox1.TabIndex = 45;
            groupBox1.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(466, 455);
            label4.Name = "label4";
            label4.Size = new Size(54, 20);
            label4.TabIndex = 46;
            label4.Text = "Estado";
            // 
            // GestionEntregaMaterialesForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 594);
            Controls.Add(label4);
            Controls.Add(groupBox1);
            Controls.Add(label3);
            Controls.Add(comboBox2);
            Controls.Add(button4);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(listView3);
            Controls.Add(listView1);
            Name = "GestionEntregaMaterialesForm";
            Text = "Gestionar entrega de materiales";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView listView1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader1;
        private ListView listView3;
        private ColumnHeader columnHeader11;
        private ColumnHeader columnHeader12;
        private Label label1;
        private Label label2;
        private ColumnHeader columnHeader6;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private Button button1;
        private Button button4;
        private ComboBox comboBox2;
        private Label label3;
        private GroupBox groupBox1;
        private Label label4;
    }
}