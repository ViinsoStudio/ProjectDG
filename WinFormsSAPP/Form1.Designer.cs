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
            groupBox2 = new GroupBox();
            buttonUserRegister = new Button();
            label13 = new Label();
            textBoxPhone = new TextBox();
            label12 = new Label();
            textBoxEmail = new TextBox();
            label11 = new Label();
            textBoxCityMun = new TextBox();
            label10 = new Label();
            textBoxDepStaPro = new TextBox();
            label9 = new Label();
            textBoxCountry = new TextBox();
            label8 = new Label();
            textBoxIdentificationDocumentNumber = new TextBox();
            label7 = new Label();
            textBoxIdentificationTypeDocumentId = new TextBox();
            label6 = new Label();
            textBoxMiddleLastName = new TextBox();
            label5 = new Label();
            textBoxLastName = new TextBox();
            label4 = new Label();
            textBoxMiddleName = new TextBox();
            label3 = new Label();
            textBoxFirstName = new TextBox();
            label2 = new Label();
            groupBox1.SuspendLayout();
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
            groupBox1.Size = new Size(1139, 80);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Enter += groupBox1_Enter;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(528, 34);
            label1.Name = "label1";
            label1.Size = new Size(61, 28);
            label1.TabIndex = 0;
            label1.Text = "SAPP";
            label1.Click += label1_Click;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            groupBox2.BackColor = Color.White;
            groupBox2.Controls.Add(buttonUserRegister);
            groupBox2.Controls.Add(label13);
            groupBox2.Controls.Add(textBoxPhone);
            groupBox2.Controls.Add(label12);
            groupBox2.Controls.Add(textBoxEmail);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(textBoxCityMun);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(textBoxDepStaPro);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(textBoxCountry);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(textBoxIdentificationDocumentNumber);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(textBoxIdentificationTypeDocumentId);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(textBoxMiddleLastName);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(textBoxLastName);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(textBoxMiddleName);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(textBoxFirstName);
            groupBox2.Controls.Add(label2);
            groupBox2.Location = new Point(8, 80);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(410, 567);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Enter += groupBox2_Enter;
            // 
            // buttonUserRegister
            // 
            buttonUserRegister.BackColor = Color.DeepSkyBlue;
            buttonUserRegister.Cursor = Cursors.Hand;
            buttonUserRegister.FlatAppearance.BorderSize = 0;
            buttonUserRegister.FlatAppearance.MouseDownBackColor = Color.DarkGray;
            buttonUserRegister.FlatAppearance.MouseOverBackColor = Color.CadetBlue;
            buttonUserRegister.FlatStyle = FlatStyle.Flat;
            buttonUserRegister.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            buttonUserRegister.ForeColor = Color.White;
            buttonUserRegister.Location = new Point(214, 527);
            buttonUserRegister.Name = "buttonUserRegister";
            buttonUserRegister.Size = new Size(174, 34);
            buttonUserRegister.TabIndex = 23;
            buttonUserRegister.Text = "Registrar";
            buttonUserRegister.UseVisualStyleBackColor = false;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label13.Location = new Point(13, 501);
            label13.Name = "label13";
            label13.Size = new Size(57, 20);
            label13.TabIndex = 22;
            label13.Text = "Celular";
            // 
            // textBoxPhone
            // 
            textBoxPhone.Location = new Point(10, 527);
            textBoxPhone.Multiline = true;
            textBoxPhone.Name = "textBoxPhone";
            textBoxPhone.Size = new Size(174, 34);
            textBoxPhone.TabIndex = 11;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label12.Location = new Point(217, 414);
            label12.Name = "label12";
            label12.Size = new Size(47, 20);
            label12.TabIndex = 20;
            label12.Text = "Email";
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(214, 440);
            textBoxEmail.Multiline = true;
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(174, 34);
            textBoxEmail.TabIndex = 10;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label11.Location = new Point(13, 414);
            label11.Name = "label11";
            label11.Size = new Size(133, 20);
            label11.TabIndex = 18;
            label11.Text = "Ciudad/Municipio";
            // 
            // textBoxCityMun
            // 
            textBoxCityMun.Location = new Point(10, 440);
            textBoxCityMun.Multiline = true;
            textBoxCityMun.Name = "textBoxCityMun";
            textBoxCityMun.Size = new Size(174, 34);
            textBoxCityMun.TabIndex = 9;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label10.Location = new Point(217, 330);
            label10.Name = "label10";
            label10.Size = new Size(96, 20);
            label10.TabIndex = 16;
            label10.Text = "Dep/Est/Pro";
            // 
            // textBoxDepStaPro
            // 
            textBoxDepStaPro.Location = new Point(214, 356);
            textBoxDepStaPro.Multiline = true;
            textBoxDepStaPro.Name = "textBoxDepStaPro";
            textBoxDepStaPro.Size = new Size(174, 34);
            textBoxDepStaPro.TabIndex = 8;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label9.Location = new Point(16, 330);
            label9.Name = "label9";
            label9.Size = new Size(37, 20);
            label9.TabIndex = 14;
            label9.Text = "País";
            // 
            // textBoxCountry
            // 
            textBoxCountry.Location = new Point(13, 356);
            textBoxCountry.Multiline = true;
            textBoxCountry.Name = "textBoxCountry";
            textBoxCountry.Size = new Size(174, 34);
            textBoxCountry.TabIndex = 7;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label8.Location = new Point(220, 241);
            label8.Name = "label8";
            label8.Size = new Size(174, 20);
            label8.TabIndex = 12;
            label8.Text = "Número de Documento";
            // 
            // textBoxIdentificationDocumentNumber
            // 
            textBoxIdentificationDocumentNumber.Location = new Point(217, 267);
            textBoxIdentificationDocumentNumber.Multiline = true;
            textBoxIdentificationDocumentNumber.Name = "textBoxIdentificationDocumentNumber";
            textBoxIdentificationDocumentNumber.Size = new Size(174, 34);
            textBoxIdentificationDocumentNumber.TabIndex = 6;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label7.Location = new Point(16, 241);
            label7.Name = "label7";
            label7.Size = new Size(147, 20);
            label7.TabIndex = 10;
            label7.Text = "Tipo de Documento";
            label7.Click += label7_Click;
            // 
            // textBoxIdentificationTypeDocumentId
            // 
            textBoxIdentificationTypeDocumentId.Location = new Point(13, 267);
            textBoxIdentificationTypeDocumentId.Multiline = true;
            textBoxIdentificationTypeDocumentId.Name = "textBoxIdentificationTypeDocumentId";
            textBoxIdentificationTypeDocumentId.Size = new Size(174, 34);
            textBoxIdentificationTypeDocumentId.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label6.Location = new Point(220, 152);
            label6.Name = "label6";
            label6.Size = new Size(132, 20);
            label6.TabIndex = 8;
            label6.Text = "Segundo Apellido";
            // 
            // textBoxMiddleLastName
            // 
            textBoxMiddleLastName.Location = new Point(217, 178);
            textBoxMiddleLastName.Multiline = true;
            textBoxMiddleLastName.Name = "textBoxMiddleLastName";
            textBoxMiddleLastName.Size = new Size(174, 34);
            textBoxMiddleLastName.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label5.Location = new Point(19, 152);
            label5.Name = "label5";
            label5.Size = new Size(118, 20);
            label5.TabIndex = 6;
            label5.Text = "Primer Apellido";
            // 
            // textBoxLastName
            // 
            textBoxLastName.Location = new Point(16, 178);
            textBoxLastName.Multiline = true;
            textBoxLastName.Name = "textBoxLastName";
            textBoxLastName.Size = new Size(174, 34);
            textBoxLastName.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.Location = new Point(220, 57);
            label4.Name = "label4";
            label4.Size = new Size(132, 20);
            label4.TabIndex = 4;
            label4.Text = "Segundo Nombre";
            label4.Click += label4_Click;
            // 
            // textBoxMiddleName
            // 
            textBoxMiddleName.Location = new Point(217, 83);
            textBoxMiddleName.Multiline = true;
            textBoxMiddleName.Name = "textBoxMiddleName";
            textBoxMiddleName.Size = new Size(174, 34);
            textBoxMiddleName.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(19, 57);
            label3.Name = "label3";
            label3.Size = new Size(118, 20);
            label3.TabIndex = 2;
            label3.Text = "Primer Nombre";
            // 
            // textBoxFirstName
            // 
            textBoxFirstName.Location = new Point(16, 83);
            textBoxFirstName.Multiline = true;
            textBoxFirstName.Name = "textBoxFirstName";
            textBoxFirstName.Size = new Size(174, 34);
            textBoxFirstName.TabIndex = 1;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(122, 23);
            label2.Name = "label2";
            label2.Size = new Size(154, 20);
            label2.TabIndex = 0;
            label2.Text = "Registro de Usuarios";
            // 
            // InterfazSAPP
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1136, 659);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "InterfazSAPP";
            Text = "SAPP";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private GroupBox groupBox2;
        private Label label2;
        private Label label3;
        private TextBox textBoxFirstName;
        private Label label11;
        private TextBox textBoxCityMun;
        private Label label10;
        private TextBox textBoxDepStaPro;
        private Label label9;
        private TextBox textBoxCountry;
        private Label label8;
        private TextBox textBoxIdentificationDocumentNumber;
        private Label label7;
        private TextBox textBoxIdentificationTypeDocumentId;
        private Label label6;
        private TextBox textBoxMiddleLastName;
        private Label label5;
        private TextBox textBoxLastName;
        private Label label4;
        private TextBox textBoxMiddleName;
        private Label label13;
        private TextBox textBoxPhone;
        private Label label12;
        private TextBox textBoxEmail;
        private Button buttonUserRegister;
    }
}
