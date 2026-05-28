namespace dodoEF.PersonalForm
{
    partial class PersonalFormUnit
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label5 = new Label();
            label6 = new Label();
            textBox1 = new TextBox();
            personalBindingSource = new BindingSource(components);
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            btn_OK = new Button();
            btn_cancel = new Button();
            label7 = new Label();
            comB_Categori = new ComboBox();
            categoriBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)personalBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)categoriBindingSource).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(68, 36);
            label1.Name = "label1";
            label1.Size = new Size(36, 20);
            label1.TabIndex = 0;
            label1.Text = "   ID";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(62, 69);
            label2.Name = "label2";
            label2.Size = new Size(42, 20);
            label2.TabIndex = 1;
            label2.Text = "ФИО";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(57, 102);
            label3.Name = "label3";
            label3.Size = new Size(47, 20);
            label3.TabIndex = 2;
            label3.Text = " Стаж";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(52, 168);
            label5.Name = "label5";
            label5.Size = new Size(52, 20);
            label5.TabIndex = 4;
            label5.Text = "Логин";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(34, 201);
            label6.Name = "label6";
            label6.Size = new Size(70, 20);
            label6.TabIndex = 5;
            label6.Text = "  Пароль";
            // 
            // textBox1
            // 
            textBox1.DataBindings.Add(new Binding("Text", personalBindingSource, "Id", true));
            textBox1.Location = new Point(112, 33);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(40, 27);
            textBox1.TabIndex = 6;
            // 
            // personalBindingSource
            // 
            personalBindingSource.DataSource = typeof(MyEF.Entities.Personal);
            // 
            // textBox2
            // 
            textBox2.DataBindings.Add(new Binding("Text", personalBindingSource, "FullName", true));
            textBox2.Location = new Point(112, 66);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(371, 27);
            textBox2.TabIndex = 7;
            // 
            // textBox3
            // 
            textBox3.DataBindings.Add(new Binding("Text", personalBindingSource, "Stage", true));
            textBox3.Location = new Point(112, 99);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(40, 27);
            textBox3.TabIndex = 8;
            // 
            // textBox5
            // 
            textBox5.DataBindings.Add(new Binding("Text", personalBindingSource, "Login", true));
            textBox5.Location = new Point(112, 168);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(271, 27);
            textBox5.TabIndex = 10;
            // 
            // textBox6
            // 
            textBox6.DataBindings.Add(new Binding("Text", personalBindingSource, "Password", true));
            textBox6.Location = new Point(112, 201);
            textBox6.Name = "textBox6";
            textBox6.PasswordChar = '*';
            textBox6.Size = new Size(271, 27);
            textBox6.TabIndex = 11;
            textBox6.UseSystemPasswordChar = true;
            // 
            // btn_OK
            // 
            btn_OK.DialogResult = DialogResult.OK;
            btn_OK.Location = new Point(59, 271);
            btn_OK.Name = "btn_OK";
            btn_OK.Size = new Size(94, 29);
            btn_OK.TabIndex = 12;
            btn_OK.Text = "OK";
            btn_OK.UseVisualStyleBackColor = true;
            // 
            // btn_cancel
            // 
            btn_cancel.DialogResult = DialogResult.Cancel;
            btn_cancel.Location = new Point(280, 271);
            btn_cancel.Name = "btn_cancel";
            btn_cancel.Size = new Size(94, 29);
            btn_cancel.TabIndex = 13;
            btn_cancel.Text = "Отмена";
            btn_cancel.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(23, 132);
            label7.Name = "label7";
            label7.Size = new Size(81, 20);
            label7.TabIndex = 14;
            label7.Text = "Категория";
            // 
            // comB_Categori
            // 
            comB_Categori.DataBindings.Add(new Binding("SelectedItem", personalBindingSource, "categori", true));
            comB_Categori.DataSource = categoriBindingSource;
            comB_Categori.DisplayMember = "Tatle";
            comB_Categori.FormattingEnabled = true;
            comB_Categori.Location = new Point(112, 132);
            comB_Categori.Name = "comB_Categori";
            comB_Categori.Size = new Size(243, 28);
            comB_Categori.TabIndex = 15;
            // 
            // categoriBindingSource
            // 
            categoriBindingSource.DataSource = typeof(MyEF.Entities.Categori);
            // 
            // PersonalFormUnit
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(504, 312);
            Controls.Add(comB_Categori);
            Controls.Add(label7);
            Controls.Add(btn_cancel);
            Controls.Add(btn_OK);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "PersonalFormUnit";
            Text = "Форма \"Сотрудник\"";
            ((System.ComponentModel.ISupportInitialize)personalBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)categoriBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label5;
        private Label label6;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox5;
        private TextBox textBox6;
        private BindingSource personalBindingSource;
        private Button btn_OK;
        private Button btn_cancel;
        private Label label7;
        private ComboBox comB_Categori;
        private BindingSource categoriBindingSource;
    }
}