namespace AGAle.PedidoMaterialesOficina
{
    partial class SolicitarMaterialOInsumoForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            ListViewItem listViewItem1 = new ListViewItem(new string[] { "Resma de hojas", "5", "Alta" }, -1);
            ListViewItem listViewItem2 = new ListViewItem(new string[] { "Lapicera", "100", "Alta" }, -1);
            comboBox1 = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            richTextBox1 = new RichTextBox();
            label4 = new Label();
            toolTip1 = new ToolTip(components);
            button1 = new Button();
            button2 = new Button();
            label5 = new Label();
            textBox1 = new TextBox();
            listView1 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            button3 = new Button();
            button4 = new Button();
            columnHeader3 = new ColumnHeader();
            label3 = new Label();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(127, 59);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(225, 28);
            comboBox1.TabIndex = 0;
            comboBox1.Text = "Recursos humanos";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(9, 62);
            label1.Name = "label1";
            label1.Size = new Size(112, 20);
            label1.TabIndex = 1;
            label1.Text = "Área solicitante";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 285);
            label2.Name = "label2";
            label2.Size = new Size(236, 20);
            label2.TabIndex = 3;
            label2.Text = "Descripción del pedido (opcional)";
            label2.Click += label2_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            richTextBox1.Location = new Point(12, 315);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(776, 93);
            richTextBox1.TabIndex = 4;
            richTextBox1.Tag = "";
            richTextBox1.Text = "'Se abre solicitud de compra para realizar actividades administrativas del proyecto X'";
            richTextBox1.TextChanged += richTextBox1_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BorderStyle = BorderStyle.FixedSingle;
            label4.Font = new Font("Segoe UI", 7.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(643, 18);
            label4.Name = "label4";
            label4.Size = new Size(145, 70);
            label4.TabIndex = 7;
            label4.Text = "Prioridades\r\nAlta: menos de 24 horas\r\nMedia: 24-48 horas\r\nBaja: más de 48 horas";
            // 
            // button1
            // 
            button1.Location = new Point(691, 441);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 8;
            button1.Text = "Cancelar";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(581, 441);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 9;
            button2.Text = "Solicitar";
            button2.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(9, 20);
            label5.Name = "label5";
            label5.Size = new Size(59, 20);
            label5.TabIndex = 11;
            label5.Text = "Usuario";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(127, 20);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "aale.externo";
            textBox1.Size = new Size(225, 27);
            textBox1.TabIndex = 12;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3 });
            listViewItem2.Tag = "";
            listView1.Items.AddRange(new ListViewItem[] { listViewItem1, listViewItem2 });
            listView1.Location = new Point(9, 141);
            listView1.Name = "listView1";
            listView1.Size = new Size(575, 132);
            listView1.TabIndex = 13;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Item";
            columnHeader1.Width = 400;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Cantidad";
            columnHeader2.Width = 90;
            // 
            // button3
            // 
            button3.Location = new Point(602, 158);
            button3.Name = "button3";
            button3.Size = new Size(186, 29);
            button3.TabIndex = 14;
            button3.Text = "Agregar";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(602, 202);
            button4.Name = "button4";
            button4.Size = new Size(186, 29);
            button4.TabIndex = 15;
            button4.Text = "Quitar";
            button4.UseVisualStyleBackColor = true;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Prioridad";
            columnHeader3.Width = 90;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 7.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 447);
            label3.Name = "label3";
            label3.Size = new Size(401, 17);
            label3.TabIndex = 16;
            label3.Text = "*Esta solicitud deberá ser aprobada por el jefe de área correspondiente";
            // 
            // SolicitarMaterialOInsumoForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 482);
            Controls.Add(label3);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(listView1);
            Controls.Add(textBox1);
            Controls.Add(label5);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(richTextBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Name = "SolicitarMaterialOInsumoForm";
            Text = "Solicitud de Materiales - OfiCentral S.A.";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private Label label1;
        private Label label2;
        private RichTextBox richTextBox1;
        private Label label4;
        private ToolTip toolTip1;
        private Button button1;
        private Button button2;
        private Label label5;
        private TextBox textBox1;
        private ListView listView1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private Button button3;
        private Button button4;
        private ColumnHeader columnHeader3;
        private Label label3;
    }
}
