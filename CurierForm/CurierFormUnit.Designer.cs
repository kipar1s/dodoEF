namespace dodoEF.CurierForm
{
    partial class CurierFormUnit
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
            components = new System.ComponentModel.Container();
            comboBoxCategori = new ComboBox();
            categoriBindingSource = new BindingSource(components);
            label7 = new Label();
            textBoxPassword = new TextBox();
            textBoxLogin = new TextBox();
            textBoxStage = new TextBox();
            textBoxFullName = new TextBox();
            textBox1 = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            textBoxNumCar = new TextBox();
            textBoxNumVY = new TextBox();
            label4 = new Label();
            label8 = new Label();
            btnСancel = new Button();
            btnOK = new Button();
            ((System.ComponentModel.ISupportInitialize)categoriBindingSource).BeginInit();
            SuspendLayout();
            // 
            // comboBoxCategori
            // 
            comboBoxCategori.DataSource = categoriBindingSource;
            comboBoxCategori.DisplayMember = "Tatle";
            comboBoxCategori.FormattingEnabled = true;
            comboBoxCategori.Location = new Point(139, 108);
            comboBoxCategori.Name = "comboBoxCategori";
            comboBoxCategori.Size = new Size(243, 28);
            comboBoxCategori.TabIndex = 27;
            comboBoxCategori.ValueMember = "Id";
            // 
            // categoriBindingSource
            // 
            categoriBindingSource.DataSource = typeof(MyEF.Entities.Categori);
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(50, 108);
            label7.Name = "label7";
            label7.Size = new Size(81, 20);
            label7.TabIndex = 26;
            label7.Text = "Категория";
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(139, 177);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.PasswordChar = '*';
            textBoxPassword.Size = new Size(164, 27);
            textBoxPassword.TabIndex = 25;
            textBoxPassword.UseSystemPasswordChar = true;
            // 
            // textBoxLogin
            // 
            textBoxLogin.Location = new Point(139, 144);
            textBoxLogin.Name = "textBoxLogin";
            textBoxLogin.Size = new Size(164, 27);
            textBoxLogin.TabIndex = 24;
            // 
            // textBoxStage
            // 
            textBoxStage.Location = new Point(139, 75);
            textBoxStage.Name = "textBoxStage";
            textBoxStage.Size = new Size(40, 27);
            textBoxStage.TabIndex = 23;
            // 
            // textBoxFullName
            // 
            textBoxFullName.Location = new Point(139, 42);
            textBoxFullName.Name = "textBoxFullName";
            textBoxFullName.Size = new Size(371, 27);
            textBoxFullName.TabIndex = 22;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(139, 9);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(40, 27);
            textBox1.TabIndex = 21;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(61, 177);
            label6.Name = "label6";
            label6.Size = new Size(70, 20);
            label6.TabIndex = 20;
            label6.Text = "  Пароль";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(79, 144);
            label5.Name = "label5";
            label5.Size = new Size(52, 20);
            label5.TabIndex = 19;
            label5.Text = "Логин";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(84, 78);
            label3.Name = "label3";
            label3.Size = new Size(47, 20);
            label3.TabIndex = 18;
            label3.Text = " Стаж";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(89, 45);
            label2.Name = "label2";
            label2.Size = new Size(42, 20);
            label2.TabIndex = 17;
            label2.Text = "ФИО";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(95, 12);
            label1.Name = "label1";
            label1.Size = new Size(36, 20);
            label1.TabIndex = 16;
            label1.Text = "   ID";
            // 
            // textBoxNumCar
            // 
            textBoxNumCar.Location = new Point(139, 241);
            textBoxNumCar.Name = "textBoxNumCar";
            textBoxNumCar.PasswordChar = '*';
            textBoxNumCar.Size = new Size(164, 27);
            textBoxNumCar.TabIndex = 31;
            // 
            // textBoxNumVY
            // 
            textBoxNumVY.Location = new Point(139, 208);
            textBoxNumVY.Name = "textBoxNumVY";
            textBoxNumVY.Size = new Size(164, 27);
            textBoxNumVY.TabIndex = 30;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 241);
            label4.Name = "label4";
            label4.Size = new Size(121, 20);
            label4.TabIndex = 29;
            label4.Text = "Номер машины";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(53, 208);
            label8.Name = "label8";
            label8.Size = new Size(79, 20);
            label8.TabIndex = 28;
            label8.Text = "Номер ВУ";
            // 
            // btnСancel
            // 
            btnСancel.DialogResult = DialogResult.Cancel;
            btnСancel.Font = new Font("Segoe UI", 14F);
            btnСancel.Location = new Point(177, 308);
            btnСancel.Name = "btnСancel";
            btnСancel.Size = new Size(126, 46);
            btnСancel.TabIndex = 33;
            btnСancel.Text = "Отмена";
            btnСancel.UseVisualStyleBackColor = true;
            btnСancel.Click += btnСancel_Click;
            // 
            // btnOK
            // 
            btnOK.DialogResult = DialogResult.OK;
            btnOK.Font = new Font("Segoe UI", 14F);
            btnOK.Location = new Point(50, 308);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(121, 46);
            btnOK.TabIndex = 32;
            btnOK.Text = "OK";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // CurierFormUnit
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnСancel);
            Controls.Add(btnOK);
            Controls.Add(textBoxNumCar);
            Controls.Add(textBoxNumVY);
            Controls.Add(label4);
            Controls.Add(label8);
            Controls.Add(comboBoxCategori);
            Controls.Add(label7);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxLogin);
            Controls.Add(textBoxStage);
            Controls.Add(textBoxFullName);
            Controls.Add(textBox1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "CurierFormUnit";
            Text = "Форма Курьера";
            Load += CurierFormUnit_Load;
            ((System.ComponentModel.ISupportInitialize)categoriBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxCategori;
        private Label label7;
        private TextBox textBoxPassword;
        private TextBox textBoxLogin;
        private TextBox textBoxStage;
        private TextBox textBoxFullName;
        private TextBox textBox1;
        private Label label6;
        private Label label5;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox textBoxNumCar;
        private TextBox textBoxNumVY;
        private Label label4;
        private Label label8;
        private BindingSource categoriBindingSource;
        private Button btnСancel;
        private Button btnOK;
    }
}