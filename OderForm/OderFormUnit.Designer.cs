namespace dodoEF.OderForm
{
    partial class OderFormUnit
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
            label7 = new Label();
            btn_cancel = new Button();
            btn_OK = new Button();
            textBox5 = new TextBox();
            oderBindingSource = new BindingSource(components);
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            textBox4 = new TextBox();
            cB_Status = new ComboBox();
            textBox6 = new TextBox();
            label4 = new Label();
            groupBox1 = new GroupBox();
            dataGridView1 = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ingrDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ingrIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            fullNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            priceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            catiforiTDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            calloryDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            tovarBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)oderBindingSource).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tovarBindingSource).BeginInit();
            SuspendLayout();
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(89, 132);
            label7.Name = "label7";
            label7.Size = new Size(41, 20);
            label7.TabIndex = 28;
            label7.Text = "Дата";
            // 
            // btn_cancel
            // 
            btn_cancel.DialogResult = DialogResult.Cancel;
            btn_cancel.Location = new Point(286, 264);
            btn_cancel.Name = "btn_cancel";
            btn_cancel.Size = new Size(94, 29);
            btn_cancel.TabIndex = 27;
            btn_cancel.Text = "Отмена";
            btn_cancel.UseVisualStyleBackColor = true;
            // 
            // btn_OK
            // 
            btn_OK.DialogResult = DialogResult.OK;
            btn_OK.Location = new Point(65, 264);
            btn_OK.Name = "btn_OK";
            btn_OK.Size = new Size(94, 29);
            btn_OK.TabIndex = 26;
            btn_OK.Text = "OK";
            btn_OK.UseVisualStyleBackColor = true;
            // 
            // textBox5
            // 
            textBox5.DataBindings.Add(new Binding("Text", oderBindingSource, "Summa", true));
            textBox5.Location = new Point(136, 161);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(110, 27);
            textBox5.TabIndex = 24;
            // 
            // oderBindingSource
            // 
            oderBindingSource.DataSource = typeof(MyEF.Entities.Oder);
            // 
            // textBox3
            // 
            textBox3.DataBindings.Add(new Binding("Text", oderBindingSource, "ClietTelefon", true));
            textBox3.Location = new Point(136, 92);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(193, 27);
            textBox3.TabIndex = 23;
            // 
            // textBox2
            // 
            textBox2.DataBindings.Add(new Binding("Text", oderBindingSource, "ClietNik", true));
            textBox2.Location = new Point(136, 59);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(371, 27);
            textBox2.TabIndex = 22;
            // 
            // textBox1
            // 
            textBox1.DataBindings.Add(new Binding("Text", oderBindingSource, "Id", true));
            textBox1.Enabled = false;
            textBox1.ForeColor = SystemColors.WindowText;
            textBox1.Location = new Point(136, 26);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(40, 27);
            textBox1.TabIndex = 21;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(81, 194);
            label6.Name = "label6";
            label6.Size = new Size(52, 20);
            label6.TabIndex = 20;
            label6.Text = "Статус";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(78, 161);
            label5.Name = "label5";
            label5.Size = new Size(55, 20);
            label5.TabIndex = 19;
            label5.Text = "Сумма";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(0, 95);
            label3.Name = "label3";
            label3.Size = new Size(130, 20);
            label3.TabIndex = 18;
            label3.Text = "Телефон Клиента";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 62);
            label2.Name = "label2";
            label2.Size = new Size(97, 20);
            label2.TabIndex = 17;
            label2.Text = "Ник Клиента";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(94, 29);
            label1.Name = "label1";
            label1.Size = new Size(36, 20);
            label1.TabIndex = 16;
            label1.Text = "   ID";
            // 
            // textBox4
            // 
            textBox4.DataBindings.Add(new Binding("Text", oderBindingSource, "date", true));
            textBox4.Location = new Point(136, 128);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(143, 27);
            textBox4.TabIndex = 29;
            // 
            // cB_Status
            // 
            cB_Status.DataSource = oderBindingSource;
            cB_Status.DisplayMember = "Status";
            cB_Status.FormattingEnabled = true;
            cB_Status.Location = new Point(136, 191);
            cB_Status.Name = "cB_Status";
            cB_Status.Size = new Size(151, 28);
            cB_Status.TabIndex = 30;
            cB_Status.ValueMember = "Status";
            // 
            // textBox6
            // 
            textBox6.DataBindings.Add(new Binding("Text", oderBindingSource, "Adress_d", true));
            textBox6.Location = new Point(136, 225);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(371, 27);
            textBox6.TabIndex = 32;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(75, 228);
            label4.Name = "label4";
            label4.Size = new Size(58, 20);
            label4.TabIndex = 31;
            label4.Text = "Адресс";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Location = new Point(33, 314);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1145, 250);
            groupBox1.TabIndex = 33;
            groupBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, ingrDataGridViewTextBoxColumn, ingrIdDataGridViewTextBoxColumn, fullNameDataGridViewTextBoxColumn, priceDataGridViewTextBoxColumn, catiforiTDataGridViewTextBoxColumn, calloryDataGridViewTextBoxColumn });
            dataGridView1.DataSource = tovarBindingSource;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 23);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1139, 224);
            dataGridView1.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.MinimumWidth = 6;
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.Width = 125;
            // 
            // ingrDataGridViewTextBoxColumn
            // 
            ingrDataGridViewTextBoxColumn.DataPropertyName = "ingr";
            ingrDataGridViewTextBoxColumn.HeaderText = "ingr";
            ingrDataGridViewTextBoxColumn.MinimumWidth = 6;
            ingrDataGridViewTextBoxColumn.Name = "ingrDataGridViewTextBoxColumn";
            ingrDataGridViewTextBoxColumn.Width = 125;
            // 
            // ingrIdDataGridViewTextBoxColumn
            // 
            ingrIdDataGridViewTextBoxColumn.DataPropertyName = "ingrId";
            ingrIdDataGridViewTextBoxColumn.HeaderText = "ingrId";
            ingrIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            ingrIdDataGridViewTextBoxColumn.Name = "ingrIdDataGridViewTextBoxColumn";
            ingrIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // fullNameDataGridViewTextBoxColumn
            // 
            fullNameDataGridViewTextBoxColumn.DataPropertyName = "FullName";
            fullNameDataGridViewTextBoxColumn.HeaderText = "FullName";
            fullNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            fullNameDataGridViewTextBoxColumn.Name = "fullNameDataGridViewTextBoxColumn";
            fullNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            priceDataGridViewTextBoxColumn.HeaderText = "Price";
            priceDataGridViewTextBoxColumn.MinimumWidth = 6;
            priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            priceDataGridViewTextBoxColumn.Width = 125;
            // 
            // catiforiTDataGridViewTextBoxColumn
            // 
            catiforiTDataGridViewTextBoxColumn.DataPropertyName = "Catifori_T";
            catiforiTDataGridViewTextBoxColumn.HeaderText = "Catifori_T";
            catiforiTDataGridViewTextBoxColumn.MinimumWidth = 6;
            catiforiTDataGridViewTextBoxColumn.Name = "catiforiTDataGridViewTextBoxColumn";
            catiforiTDataGridViewTextBoxColumn.Width = 125;
            // 
            // calloryDataGridViewTextBoxColumn
            // 
            calloryDataGridViewTextBoxColumn.DataPropertyName = "Callory";
            calloryDataGridViewTextBoxColumn.HeaderText = "Callory";
            calloryDataGridViewTextBoxColumn.MinimumWidth = 6;
            calloryDataGridViewTextBoxColumn.Name = "calloryDataGridViewTextBoxColumn";
            calloryDataGridViewTextBoxColumn.Width = 125;
            // 
            // tovarBindingSource
            // 
            tovarBindingSource.DataSource = typeof(MyEF.Entities.Tovar);
            // 
            // OderFormUnit
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1205, 593);
            Controls.Add(groupBox1);
            Controls.Add(textBox6);
            Controls.Add(label4);
            Controls.Add(cB_Status);
            Controls.Add(textBox4);
            Controls.Add(label7);
            Controls.Add(btn_cancel);
            Controls.Add(btn_OK);
            Controls.Add(textBox5);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "OderFormUnit";
            Text = "Форма \"Заказ\"";
            ((System.ComponentModel.ISupportInitialize)oderBindingSource).EndInit();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)tovarBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label7;
        private Button btn_cancel;
        private Button btn_OK;
        private TextBox textBox5;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label6;
        private Label label5;
        private Label label3;
        private Label label2;
        private Label label1;
        private BindingSource oderBindingSource;
        private TextBox textBox4;
        private ComboBox cB_Status;
        private TextBox textBox6;
        private Label label4;
        private GroupBox groupBox1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn ingrDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn ingrIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fullNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn catiforiTDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn calloryDataGridViewTextBoxColumn;
        private BindingSource tovarBindingSource;
    }
}