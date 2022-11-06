namespace Login
{
    partial class Tickets
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.fechadateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.usuariotextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.preciotextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.descripcionrespuestatextBox = new System.Windows.Forms.TextBox();
            this.descripcionsolicitudtextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tiposoportetextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.clientetextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.totaltextBox = new System.Windows.Forms.TextBox();
            this.descuentotextBox = new System.Windows.Forms.TextBox();
            this.impuestotextBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(-2, 307);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 28);
            this.button1.TabIndex = 0;
            this.button1.Text = "Volver al Menu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 15);
            this.label1.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.fechadateTimePicker);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.usuariotextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(8, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(678, 56);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // fechadateTimePicker
            // 
            this.fechadateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fechadateTimePicker.Location = new System.Drawing.Point(570, 22);
            this.fechadateTimePicker.Name = "fechadateTimePicker";
            this.fechadateTimePicker.Size = new System.Drawing.Size(102, 23);
            this.fechadateTimePicker.TabIndex = 3;
            this.fechadateTimePicker.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(527, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fecha:";
            // 
            // usuariotextBox
            // 
            this.usuariotextBox.Location = new System.Drawing.Point(66, 22);
            this.usuariotextBox.Name = "usuariotextBox";
            this.usuariotextBox.Size = new System.Drawing.Size(200, 23);
            this.usuariotextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Usuario:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.preciotextBox);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.descripcionrespuestatextBox);
            this.groupBox2.Controls.Add(this.descripcionsolicitudtextBox);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.tiposoportetextBox);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.clientetextBox);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(8, 74);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(678, 148);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "DATOS";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(565, 106);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "ACEPTAR";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // preciotextBox
            // 
            this.preciotextBox.Location = new System.Drawing.Point(427, 106);
            this.preciotextBox.Name = "preciotextBox";
            this.preciotextBox.Size = new System.Drawing.Size(100, 23);
            this.preciotextBox.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(377, 106);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 15);
            this.label8.TabIndex = 8;
            this.label8.Text = "Precio:";
            // 
            // descripcionrespuestatextBox
            // 
            this.descripcionrespuestatextBox.Location = new System.Drawing.Point(427, 66);
            this.descripcionrespuestatextBox.Name = "descripcionrespuestatextBox";
            this.descripcionrespuestatextBox.Size = new System.Drawing.Size(213, 23);
            this.descripcionrespuestatextBox.TabIndex = 7;
            // 
            // descripcionsolicitudtextBox
            // 
            this.descripcionsolicitudtextBox.Location = new System.Drawing.Point(427, 26);
            this.descripcionsolicitudtextBox.Name = "descripcionsolicitudtextBox";
            this.descripcionsolicitudtextBox.Size = new System.Drawing.Size(213, 23);
            this.descripcionsolicitudtextBox.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(292, 65);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(128, 15);
            this.label7.TabIndex = 5;
            this.label7.Text = "Descripcion Respuesta:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(299, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 15);
            this.label6.TabIndex = 4;
            this.label6.Text = "Descripcion Solicitud:";
            // 
            // tiposoportetextBox
            // 
            this.tiposoportetextBox.Location = new System.Drawing.Point(97, 62);
            this.tiposoportetextBox.Name = "tiposoportetextBox";
            this.tiposoportetextBox.Size = new System.Drawing.Size(169, 23);
            this.tiposoportetextBox.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 15);
            this.label5.TabIndex = 2;
            this.label5.Text = "Tipo Soporte:";
            // 
            // clientetextBox
            // 
            this.clientetextBox.Location = new System.Drawing.Point(66, 21);
            this.clientetextBox.Name = "clientetextBox";
            this.clientetextBox.Size = new System.Drawing.Size(200, 23);
            this.clientetextBox.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Cliente:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.totaltextBox);
            this.groupBox3.Controls.Add(this.descuentotextBox);
            this.groupBox3.Controls.Add(this.impuestotextBox);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Location = new System.Drawing.Point(8, 228);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(676, 54);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // totaltextBox
            // 
            this.totaltextBox.Location = new System.Drawing.Point(513, 20);
            this.totaltextBox.Name = "totaltextBox";
            this.totaltextBox.Size = new System.Drawing.Size(100, 23);
            this.totaltextBox.TabIndex = 5;
            // 
            // descuentotextBox
            // 
            this.descuentotextBox.Location = new System.Drawing.Point(316, 20);
            this.descuentotextBox.Name = "descuentotextBox";
            this.descuentotextBox.Size = new System.Drawing.Size(100, 23);
            this.descuentotextBox.TabIndex = 4;
            // 
            // impuestotextBox
            // 
            this.impuestotextBox.Location = new System.Drawing.Point(86, 18);
            this.impuestotextBox.Name = "impuestotextBox";
            this.impuestotextBox.Size = new System.Drawing.Size(100, 23);
            this.impuestotextBox.TabIndex = 3;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(461, 23);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(35, 15);
            this.label11.TabIndex = 2;
            this.label11.Text = "Total:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(244, 23);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 15);
            this.label10.TabIndex = 1;
            this.label10.Text = "Descuento:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(21, 23);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 15);
            this.label9.TabIndex = 0;
            this.label9.Text = "Impuesto:";
            // 
            // Tickets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 333);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "Tickets";
            this.Text = "Tickets";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private Label label1;
        private GroupBox groupBox1;
        private Label label3;
        private TextBox usuariotextBox;
        private Label label2;
        private DateTimePicker fechadateTimePicker;
        private GroupBox groupBox2;
        private Label label4;
        private TextBox preciotextBox;
        private Label label8;
        private TextBox descripcionrespuestatextBox;
        private TextBox descripcionsolicitudtextBox;
        private Label label7;
        private Label label6;
        private TextBox tiposoportetextBox;
        private Label label5;
        private TextBox clientetextBox;
        private GroupBox groupBox3;
        private TextBox totaltextBox;
        private TextBox descuentotextBox;
        private TextBox impuestotextBox;
        private Label label11;
        private Label label10;
        private Label label9;
        private Button button2;
    }
}