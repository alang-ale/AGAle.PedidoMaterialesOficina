namespace AGAle.PedidoMaterialesOficina.AprobaciónSolicitudesMaterialOInsumo
{
    partial class AprobaciónSolicitudesMaterialOInsumoForm
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
            ListViewItem listViewItem5 = new ListViewItem(new string[] { "150", "aale.externo", "Alta", "29/09/2026" }, -1);
            ListViewItem listViewItem6 = new ListViewItem(new string[] { "149", "jperez", "Baja", "29/09/2026" }, -1);
            ListViewItem listViewItem7 = new ListViewItem(new string[] { "Resma de hojas", "5", "Alta" }, -1);
            ListViewItem listViewItem8 = new ListViewItem(new string[] { "Lapicera", "100", "Alta" }, -1);
            listView1 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            label1 = new Label();
            button2 = new Button();
            Fechasolicitud = new ColumnHeader();
            button3 = new Button();
            listView2 = new ListView();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            label2 = new Label();
            label3 = new Label();
            richTextBox1 = new RichTextBox();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, Fechasolicitud });
            listViewItem6.Tag = "";
            listView1.Items.AddRange(new ListViewItem[] { listViewItem5, listViewItem6 });
            listView1.Location = new Point(18, 42);
            listView1.Name = "listView1";
            listView1.Size = new Size(573, 132);
            listView1.TabIndex = 14;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "N° de solicitud";
            columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Solicitante";
            columnHeader2.Width = 120;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Prioridad";
            columnHeader3.Width = 90;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 9);
            label1.Name = "label1";
            label1.Size = new Size(158, 20);
            label1.TabIndex = 15;
            label1.Text = "Solicitudes pendientes";
            // 
            // button2
            // 
            button2.Location = new Point(497, 519);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 16;
            button2.Text = "Rechazar";
            button2.UseVisualStyleBackColor = true;
            // 
            // Fechasolicitud
            // 
            Fechasolicitud.Text = "Fecha de solicitud";
            Fechasolicitud.Width = 150;
            // 
            // button3
            // 
            button3.Location = new Point(382, 519);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 18;
            button3.Text = "Aprobar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += this.button3_Click;
            // 
            // listView2
            // 
            listView2.Columns.AddRange(new ColumnHeader[] { columnHeader4, columnHeader5 });
            listViewItem8.Tag = "";
            listView2.Items.AddRange(new ListViewItem[] { listViewItem7, listViewItem8 });
            listView2.Location = new Point(18, 220);
            listView2.Name = "listView2";
            listView2.Size = new Size(573, 139);
            listView2.TabIndex = 19;
            listView2.UseCompatibleStateImageBehavior = false;
            listView2.View = View.Details;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Item";
            columnHeader4.Width = 450;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Cantidad";
            columnHeader5.Width = 90;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 192);
            label2.Name = "label2";
            label2.Size = new Size(57, 20);
            label2.TabIndex = 20;
            label2.Text = "Detalle";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 392);
            label3.Name = "label3";
            label3.Size = new Size(91, 20);
            label3.TabIndex = 22;
            label3.Text = "Observación";
            // 
            // richTextBox1
            // 
            richTextBox1.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            richTextBox1.Location = new Point(18, 424);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(573, 73);
            richTextBox1.TabIndex = 23;
            richTextBox1.Tag = "";
            richTextBox1.Text = "Se aprueba la solicitud notificando al área de compras";
            // 
            // AprobaciónSolicitudesMaterialOInsumoForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(611, 576);
            Controls.Add(richTextBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(listView2);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(label1);
            Controls.Add(listView1);
            Name = "AprobaciónSolicitudesMaterialOInsumoForm";
            Text = "Aprobación de solicitudes";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView listView1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private Label label1;
        private ColumnHeader Fechasolicitud;
        private Button button2;
        private Button button3;
        private ListView listView2;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private Label label2;
        private Label label3;
        private RichTextBox richTextBox1;
    }
}