namespace WinFormsSAPP
{
    partial class InterfazSAPP
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
            groupBox1 = new GroupBox();
            label1 = new Label();
            groupBox3 = new GroupBox();
            buttonRegistrarTipoAnimal = new Button();
            label15 = new Label();
            textBoxTipoAnimal = new TextBox();
            label14 = new Label();
            groupBox2 = new GroupBox();
            label4 = new Label();
            comboBoxTiposDeAnimal = new ComboBox();
            buttonRegistrarRaza = new Button();
            label2 = new Label();
            textBoxNuevaRaza = new TextBox();
            label3 = new Label();
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.BackColor = Color.DeepSkyBlue;
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(-2, -10);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(996, 80);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(457, 34);
            label1.Name = "label1";
            label1.Size = new Size(61, 28);
            label1.TabIndex = 0;
            label1.Text = "SAPP";
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.White;
            groupBox3.Controls.Add(buttonRegistrarTipoAnimal);
            groupBox3.Controls.Add(label15);
            groupBox3.Controls.Add(textBoxTipoAnimal);
            groupBox3.Controls.Add(label14);
            groupBox3.Location = new Point(9, 80);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(308, 183);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            // 
            // buttonRegistrarTipoAnimal
            // 
            buttonRegistrarTipoAnimal.BackColor = Color.DeepSkyBlue;
            buttonRegistrarTipoAnimal.Cursor = Cursors.Hand;
            buttonRegistrarTipoAnimal.FlatAppearance.BorderSize = 0;
            buttonRegistrarTipoAnimal.FlatAppearance.MouseDownBackColor = Color.DarkGray;
            buttonRegistrarTipoAnimal.FlatAppearance.MouseOverBackColor = Color.CadetBlue;
            buttonRegistrarTipoAnimal.FlatStyle = FlatStyle.Flat;
            buttonRegistrarTipoAnimal.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            buttonRegistrarTipoAnimal.ForeColor = Color.White;
            buttonRegistrarTipoAnimal.Location = new Point(67, 133);
            buttonRegistrarTipoAnimal.Name = "buttonRegistrarTipoAnimal";
            buttonRegistrarTipoAnimal.Size = new Size(174, 34);
            buttonRegistrarTipoAnimal.TabIndex = 24;
            buttonRegistrarTipoAnimal.Text = "Registrar";
            buttonRegistrarTipoAnimal.UseVisualStyleBackColor = false;
            buttonRegistrarTipoAnimal.Click += buttonRegistrarTipoAnimal_Click;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label15.Location = new Point(15, 60);
            label15.Name = "label15";
            label15.Size = new Size(280, 20);
            label15.TabIndex = 21;
            label15.Text = "Ingrese el tipo de animal para registrar";
            // 
            // textBoxTipoAnimal
            // 
            textBoxTipoAnimal.Location = new Point(15, 83);
            textBoxTipoAnimal.Multiline = true;
            textBoxTipoAnimal.Name = "textBoxTipoAnimal";
            textBoxTipoAnimal.Size = new Size(280, 34);
            textBoxTipoAnimal.TabIndex = 11;
            // 
            // label14
            // 
            label14.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label14.Location = new Point(45, 23);
            label14.Name = "label14";
            label14.Size = new Size(215, 20);
            label14.TabIndex = 1;
            label14.Text = "Insertar nuevo tipo de animal";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.White;
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(comboBoxTiposDeAnimal);
            groupBox2.Controls.Add(buttonRegistrarRaza);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(textBoxNuevaRaza);
            groupBox2.Controls.Add(label3);
            groupBox2.Location = new Point(361, 80);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(619, 183);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.Location = new Point(320, 60);
            label4.Name = "label4";
            label4.Size = new Size(156, 20);
            label4.TabIndex = 26;
            label4.Text = "Ingrese la nueva raza";
            // 
            // comboBoxTiposDeAnimal
            // 
            comboBoxTiposDeAnimal.FormattingEnabled = true;
            comboBoxTiposDeAnimal.Location = new Point(19, 89);
            comboBoxTiposDeAnimal.Name = "comboBoxTiposDeAnimal";
            comboBoxTiposDeAnimal.Size = new Size(280, 28);
            comboBoxTiposDeAnimal.TabIndex = 25;
            // 
            // buttonRegistrarRaza
            // 
            buttonRegistrarRaza.BackColor = Color.DeepSkyBlue;
            buttonRegistrarRaza.Cursor = Cursors.Hand;
            buttonRegistrarRaza.FlatAppearance.BorderSize = 0;
            buttonRegistrarRaza.FlatAppearance.MouseDownBackColor = Color.DarkGray;
            buttonRegistrarRaza.FlatAppearance.MouseOverBackColor = Color.CadetBlue;
            buttonRegistrarRaza.FlatStyle = FlatStyle.Flat;
            buttonRegistrarRaza.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            buttonRegistrarRaza.ForeColor = Color.White;
            buttonRegistrarRaza.Location = new Point(225, 133);
            buttonRegistrarRaza.Name = "buttonRegistrarRaza";
            buttonRegistrarRaza.Size = new Size(174, 34);
            buttonRegistrarRaza.TabIndex = 24;
            buttonRegistrarRaza.Text = "Registrar";
            buttonRegistrarRaza.UseVisualStyleBackColor = false;
            buttonRegistrarRaza.Click += buttonRegistrarRaza_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(15, 60);
            label2.Name = "label2";
            label2.Size = new Size(207, 20);
            label2.TabIndex = 21;
            label2.Text = "Seleccione un tipo de animal";
            // 
            // textBoxNuevaRaza
            // 
            textBoxNuevaRaza.Location = new Point(323, 83);
            textBoxNuevaRaza.Multiline = true;
            textBoxNuevaRaza.Name = "textBoxNuevaRaza";
            textBoxNuevaRaza.Size = new Size(280, 34);
            textBoxNuevaRaza.TabIndex = 11;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(204, 23);
            label3.Name = "label3";
            label3.Size = new Size(215, 20);
            label3.TabIndex = 1;
            label3.Text = "Insertar nueva raza de animal";
            // 
            // InterfazSAPP
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(993, 659);
            Controls.Add(groupBox2);
            Controls.Add(groupBox3);
            Controls.Add(groupBox1);
            Name = "InterfazSAPP";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SAPP";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private GroupBox groupBox3;
        private Label label14;
        private Button buttonRegistrarTipoAnimal;
        private Label label15;
        private TextBox textBoxTipoAnimal;
        private GroupBox groupBox2;
        private Button buttonRegistrarRaza;
        private Label label2;
        private TextBox textBoxNuevaRaza;
        private Label label3;
        private Label label4;
        private ComboBox comboBoxTiposDeAnimal;
    }
}
