namespace dodoEF.ClientForm
{
    partial class CLientUnitForm
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
            groupBox1 = new GroupBox();
            dataGridView1 = new DataGridView();
            textBox6 = new TextBox();
            label4 = new Label();
            textBox4 = new TextBox();
            label7 = new Label();
            btn_cancel = new Button();
            btn_OK = new Button();
            textBox5 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            oderBindingSource = new BindingSource(components);
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            date = new DataGridViewTextBoxColumn();
            summaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            statusDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            adressdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            plategSTDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            Plateg_SP = new DataGridViewTextBoxColumn();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)oderBindingSource).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Location = new Point(52, 240);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1056, 250);
            groupBox1.TabIndex = 50;
            groupBox1.TabStop = false;
            groupBox1.Text = "Заказы клиента";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, date, summaDataGridViewTextBoxColumn, statusDataGridViewTextBoxColumn, adressdDataGridViewTextBoxColumn, plategSTDataGridViewTextBoxColumn, Plateg_SP });
            dataGridView1.DataSource = oderBindingSource;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 23);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1050, 224);
            dataGridView1.TabIndex = 0;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(155, 123);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(371, 27);
            textBox6.TabIndex = 49;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(94, 126);
            label4.Name = "label4";
            label4.Size = new Size(58, 20);
            label4.TabIndex = 48;
            label4.Text = "Адресс";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(155, 156);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(143, 27);
            textBox4.TabIndex = 46;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(108, 160);
            label7.Name = "label7";
            label7.Size = new Size(52, 20);
            label7.TabIndex = 45;
            label7.Text = "Логин";
            // 
            // btn_cancel
            // 
            btn_cancel.DialogResult = DialogResult.Cancel;
            btn_cancel.Font = new Font("Segoe UI", 20F);
            btn_cancel.Location = new Point(821, 118);
            btn_cancel.Name = "btn_cancel";
            btn_cancel.Size = new Size(169, 98);
            btn_cancel.TabIndex = 44;
            btn_cancel.Text = "Отмена";
            btn_cancel.UseVisualStyleBackColor = true;
            // 
            // btn_OK
            // 
            btn_OK.DialogResult = DialogResult.OK;
            btn_OK.Font = new Font("Segoe UI", 20F);
            btn_OK.Location = new Point(623, 118);
            btn_OK.Name = "btn_OK";
            btn_OK.Size = new Size(153, 98);
            btn_OK.TabIndex = 43;
            btn_OK.Text = "OK";
            btn_OK.UseVisualStyleBackColor = true;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(155, 189);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(132, 27);
            textBox5.TabIndex = 42;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(155, 89);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(193, 27);
            textBox3.TabIndex = 41;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(155, 56);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(371, 27);
            textBox2.TabIndex = 40;
            // 
            // textBox1
            // 
            textBox1.Enabled = false;
            textBox1.ForeColor = SystemColors.WindowText;
            textBox1.Location = new Point(155, 23);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(40, 27);
            textBox1.TabIndex = 39;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(97, 189);
            label5.Name = "label5";
            label5.Size = new Size(62, 20);
            label5.TabIndex = 37;
            label5.Text = "Пароль";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(19, 92);
            label3.Name = "label3";
            label3.Size = new Size(130, 20);
            label3.TabIndex = 36;
            label3.Text = "Телефон Клиента";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(52, 59);
            label2.Name = "label2";
            label2.Size = new Size(97, 20);
            label2.TabIndex = 35;
            label2.Text = "Ник Клиента";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(113, 26);
            label1.Name = "label1";
            label1.Size = new Size(36, 20);
            label1.TabIndex = 34;
            label1.Text = "   ID";
            // 
            // oderBindingSource
            // 
            oderBindingSource.DataSource = typeof(MyEF.Entities.Oder);
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.MinimumWidth = 6;
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.ReadOnly = true;
            idDataGridViewTextBoxColumn.Width = 125;
            // 
            // date
            // 
            date.DataPropertyName = "date";
            date.HeaderText = "Дата";
            date.MinimumWidth = 6;
            date.Name = "date";
            date.Width = 125;
            // 
            // summaDataGridViewTextBoxColumn
            // 
            summaDataGridViewTextBoxColumn.DataPropertyName = "Summa";
            summaDataGridViewTextBoxColumn.HeaderText = "Сумма заказа";
            summaDataGridViewTextBoxColumn.MinimumWidth = 6;
            summaDataGridViewTextBoxColumn.Name = "summaDataGridViewTextBoxColumn";
            summaDataGridViewTextBoxColumn.Width = 125;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            statusDataGridViewTextBoxColumn.HeaderText = "Статус заказа";
            statusDataGridViewTextBoxColumn.MinimumWidth = 6;
            statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            statusDataGridViewTextBoxColumn.Width = 125;
            // 
            // adressdDataGridViewTextBoxColumn
            // 
            adressdDataGridViewTextBoxColumn.DataPropertyName = "Adress_d";
            adressdDataGridViewTextBoxColumn.HeaderText = "Адресс";
            adressdDataGridViewTextBoxColumn.MinimumWidth = 6;
            adressdDataGridViewTextBoxColumn.Name = "adressdDataGridViewTextBoxColumn";
            adressdDataGridViewTextBoxColumn.Width = 125;
            // 
            // plategSTDataGridViewTextBoxColumn
            // 
            plategSTDataGridViewTextBoxColumn.DataPropertyName = "Plateg_ST";
            plategSTDataGridViewTextBoxColumn.HeaderText = "Статус платежа";
            plategSTDataGridViewTextBoxColumn.MinimumWidth = 6;
            plategSTDataGridViewTextBoxColumn.Name = "plategSTDataGridViewTextBoxColumn";
            plategSTDataGridViewTextBoxColumn.Width = 125;
            // 
            // Plateg_SP
            // 
            Plateg_SP.DataPropertyName = "Plateg_SP";
            Plateg_SP.HeaderText = "Способ платежа";
            Plateg_SP.MinimumWidth = 6;
            Plateg_SP.Name = "Plateg_SP";
            Plateg_SP.Width = 125;
            // 
            // CLientUnitForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1108, 515);
            Controls.Add(groupBox1);
            Controls.Add(textBox6);
            Controls.Add(label4);
            Controls.Add(textBox4);
            Controls.Add(label7);
            Controls.Add(btn_cancel);
            Controls.Add(btn_OK);
            Controls.Add(textBox5);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "CLientUnitForm";
            Text = "Форма \"Клиент\"";
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)oderBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private DataGridView dataGridView1;
        private TextBox textBox6;
        private Label label4;
        private TextBox textBox4;
        private Label label7;
        private Button btn_cancel;
        private Button btn_OK;
        private TextBox textBox5;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label5;
        private Label label3;
        private Label label2;
        private Label label1;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn date;
        private DataGridViewTextBoxColumn summaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn adressdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn plategSTDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn Plateg_SP;
        private BindingSource oderBindingSource;
    }
}