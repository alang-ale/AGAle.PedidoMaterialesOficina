namespace AGAle.PedidoMaterialesOficina.ConfirmaciónRecepciónInsumo
{
    partial class ConfirmacionRecepcionInsumosForm
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
            ListViewItem listViewItem3 = new ListViewItem(new string[] { "159", "29/09/2026", "Recursos humanos", "Media", "Recibido" }, -1);
            ListViewItem listViewItem4 = new ListViewItem(new string[] { "160", "30/09/2026", "Depósito", "Baja", "Pendiente de confirmar recepción" }, -1);
            listView1 = new ListView();
            columnHeader2 = new ColumnHeader();
            columnHeader1 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            textBox1 = new TextBox();
            label5 = new Label();
            button3 = new Button();
            button4 = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader2, columnHeader1, columnHeader3, columnHeader4, columnHeader5 });
            listView1.Items.AddRange(new ListViewItem[] { listViewItem3, listViewItem4 });
            listView1.Location = new Point(12, 89);
            listView1.Name = "listView1";
            listView1.Size = new Size(776, 158);
            listView1.TabIndex = 1;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
           
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "N° solicitud";
            columnHeader2.Width = 150;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Fecha aprobación";
            columnHeader1.Width = 150;
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
            columnHeader5.Width = 150;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(96, 28);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "aale.externo";
            textBox1.Size = new Size(225, 27);
            textBox1.TabIndex = 14;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(20, 28);
            label5.Name = "label5";
            label5.Size = new Size(59, 20);
            label5.TabIndex = 13;
            label5.Text = "Usuario";
            // 
            // button3
            // 
            button3.Location = new Point(602, 253);
            button3.Name = "button3";
            button3.Size = new Size(186, 29);
            button3.TabIndex = 15;
            button3.Text = "Confirmar recepción";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(583, 317);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 44;
            button4.Text = "Guardar";
            button4.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(694, 317);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 43;
            button1.Text = "Cancelar";
            button1.UseVisualStyleBackColor = true;
            // 
            // ConfirmacionRecepcionInsumosForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 367);
            Controls.Add(button4);
            Controls.Add(button1);
            Controls.Add(button3);
            Controls.Add(textBox1);
            Controls.Add(label5);
            Controls.Add(listView1);
            Name = "ConfirmacionRecepcionInsumosForm";
            Text = "Confirmar recepción de insumos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView listView1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private TextBox textBox1;
        private Label label5;
        private Button button3;
        private Button button4;
        private Button button1;
    }
}