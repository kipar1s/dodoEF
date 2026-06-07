namespace dodoEF.TovarForm
{
    partial class TovarUnitForm
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
            btnСancel = new Button();
            btnOK = new Button();
            textBoxCatifori = new TextBox();
            textBoxFullName = new TextBox();
            textBox1 = new TextBox();
            tovarBindingSource = new BindingSource(components);
            label5 = new Label();
            label2 = new Label();
            label1 = new Label();
            textBoxPrice = new TextBox();
            label3 = new Label();
            textBoxCallory = new TextBox();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)tovarBindingSource).BeginInit();
            SuspendLayout();
            // 
            // btnСancel
            // 
            btnСancel.DialogResult = DialogResult.Cancel;
            btnСancel.Font = new Font("Segoe UI", 14F);
            btnСancel.Location = new Point(194, 242);
            btnСancel.Name = "btnСancel";
            btnСancel.Size = new Size(126, 46);
            btnСancel.TabIndex = 41;
            btnСancel.Text = "Отмена";
            btnСancel.UseVisualStyleBackColor = true;
            btnСancel.Click += btnСancel_Click;
            // 
            // btnOK
            // 
            btnOK.DialogResult = DialogResult.OK;
            btnOK.Font = new Font("Segoe UI", 14F);
            btnOK.Location = new Point(67, 242);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(121, 46);
            btnOK.TabIndex = 40;
            btnOK.Text = "OK";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // textBoxCatifori
            // 
            textBoxCatifori.DataBindings.Add(new Binding("Text", tovarBindingSource, "Catifori_T", true));
            textBoxCatifori.Location = new Point(115, 140);
            textBoxCatifori.Name = "textBoxCatifori";
            textBoxCatifori.Size = new Size(164, 27);
            textBoxCatifori.TabIndex = 39;
            // 
            // textBoxFullName
            // 
            textBoxFullName.DataBindings.Add(new Binding("Text", tovarBindingSource, "FullName", true));
            textBoxFullName.Location = new Point(115, 64);
            textBoxFullName.Name = "textBoxFullName";
            textBoxFullName.Size = new Size(371, 27);
            textBoxFullName.TabIndex = 38;
            // 
            // textBox1
            // 
            textBox1.DataBindings.Add(new Binding("Text", tovarBindingSource, "Id", true));
            textBox1.Location = new Point(115, 26);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(40, 27);
            textBox1.TabIndex = 37;
            // 
            // tovarBindingSource
            // 
            tovarBindingSource.DataSource = typeof(MyEF.Entities.Tovar);
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(22, 140);
            label5.Name = "label5";
            label5.Size = new Size(81, 20);
            label5.TabIndex = 36;
            label5.Text = "Категория";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 67);
            label2.Name = "label2";
            label2.Size = new Size(77, 20);
            label2.TabIndex = 35;
            label2.Text = "Название";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(67, 29);
            label1.Name = "label1";
            label1.Size = new Size(36, 20);
            label1.TabIndex = 34;
            label1.Text = "   ID";
            // 
            // textBoxPrice
            // 
            textBoxPrice.DataBindings.Add(new Binding("Text", tovarBindingSource, "Price", true));
            textBoxPrice.Location = new Point(115, 102);
            textBoxPrice.Name = "textBoxPrice";
            textBoxPrice.Size = new Size(164, 27);
            textBoxPrice.TabIndex = 43;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(58, 102);
            label3.Name = "label3";
            label3.Size = new Size(45, 20);
            label3.TabIndex = 42;
            label3.Text = "Цена";
            // 
            // textBoxCallory
            // 
            textBoxCallory.DataBindings.Add(new Binding("Text", tovarBindingSource, "Callory", true));
            textBoxCallory.Location = new Point(115, 178);
            textBoxCallory.Name = "textBoxCallory";
            textBoxCallory.Size = new Size(164, 27);
            textBoxCallory.TabIndex = 45;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(33, 181);
            label4.Name = "label4";
            label4.Size = new Size(70, 20);
            label4.TabIndex = 44;
            label4.Text = "Калории";
            // 
            // TovarUnitForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(512, 319);
            Controls.Add(textBoxCallory);
            Controls.Add(label4);
            Controls.Add(textBoxPrice);
            Controls.Add(label3);
            Controls.Add(btnСancel);
            Controls.Add(btnOK);
            Controls.Add(textBoxCatifori);
            Controls.Add(textBoxFullName);
            Controls.Add(textBox1);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "TovarUnitForm";
            Text = "Форма Товар";
            Load += TovarUnitForm_Load;
            ((System.ComponentModel.ISupportInitialize)tovarBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnСancel;
        private Button btnOK;
        private TextBox textBoxCatifori;
        private TextBox textBoxFullName;
        private TextBox textBox1;
        private Label label5;
        private Label label2;
        private Label label1;
        private TextBox textBoxPrice;
        private Label label3;
        private TextBox textBoxCallory;
        private Label label4;
        private BindingSource tovarBindingSource;
    }
}