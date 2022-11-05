namespace Login
{
    partial class Login
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.aceptarbutton = new System.Windows.Forms.Button();
            this.cancelarbutton = new System.Windows.Forms.Button();
            this.usuariotextBox = new System.Windows.Forms.TextBox();
            this.clavetextBox = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Clave: ";
            // 
            // aceptarbutton
            // 
            this.aceptarbutton.Location = new System.Drawing.Point(48, 120);
            this.aceptarbutton.Name = "aceptarbutton";
            this.aceptarbutton.Size = new System.Drawing.Size(79, 38);
            this.aceptarbutton.TabIndex = 2;
            this.aceptarbutton.Text = "Aceptar";
            this.aceptarbutton.UseVisualStyleBackColor = true;
            this.aceptarbutton.Click += new System.EventHandler(this.aceptarbutton_Click);
            // 
            // cancelarbutton
            // 
            this.cancelarbutton.Location = new System.Drawing.Point(164, 120);
            this.cancelarbutton.Name = "cancelarbutton";
            this.cancelarbutton.Size = new System.Drawing.Size(82, 38);
            this.cancelarbutton.TabIndex = 3;
            this.cancelarbutton.Text = "Cancelar";
            this.cancelarbutton.UseVisualStyleBackColor = true;
            this.cancelarbutton.Click += new System.EventHandler(this.cancelarbutton_Click);
            // 
            // usuariotextBox
            // 
            this.usuariotextBox.Location = new System.Drawing.Point(98, 33);
            this.usuariotextBox.Name = "usuariotextBox";
            this.usuariotextBox.Size = new System.Drawing.Size(148, 23);
            this.usuariotextBox.TabIndex = 4;
            // 
            // clavetextBox
            // 
            this.clavetextBox.Location = new System.Drawing.Point(98, 73);
            this.clavetextBox.Name = "clavetextBox";
            this.clavetextBox.Size = new System.Drawing.Size(148, 23);
            this.clavetextBox.TabIndex = 5;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 191);
            this.Controls.Add(this.clavetextBox);
            this.Controls.Add(this.usuariotextBox);
            this.Controls.Add(this.cancelarbutton);
            this.Controls.Add(this.aceptarbutton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Login";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Button aceptarbutton;
        private Button cancelarbutton;
        private TextBox usuariotextBox;
        private TextBox clavetextBox;
        private ErrorProvider errorProvider1;
    }
}