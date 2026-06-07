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
            groupBox1 = new GroupBox();
            dataGridViewOders = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            summaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            statusDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            adressdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            oderBindingSource = new BindingSource(components);
            btnAddOder = new Button();
            groupBox2 = new GroupBox();
            dataGridViewFreeOders = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            freeOderBindingSource = new BindingSource(components);
            btnRemoveOder = new Button();
            ((System.ComponentModel.ISupportInitialize)personalBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)categoriBindingSource).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOders).BeginInit();
            ((System.ComponentModel.ISupportInitialize)oderBindingSource).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFreeOders).BeginInit();
            ((System.ComponentModel.ISupportInitialize)freeOderBindingSource).BeginInit();
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
            btn_OK.Font = new Font("Segoe UI", 14F);
            btn_OK.Location = new Point(515, 52);
            btn_OK.Name = "btn_OK";
            btn_OK.Size = new Size(121, 46);
            btn_OK.TabIndex = 12;
            btn_OK.Text = "OK";
            btn_OK.UseVisualStyleBackColor = true;
            btn_OK.Click += btn_OK_Click;
            // 
            // btn_cancel
            // 
            btn_cancel.DialogResult = DialogResult.Cancel;
            btn_cancel.Font = new Font("Segoe UI", 14F);
            btn_cancel.Location = new Point(642, 52);
            btn_cancel.Name = "btn_cancel";
            btn_cancel.Size = new Size(126, 46);
            btn_cancel.TabIndex = 13;
            btn_cancel.Text = "Отмена";
            btn_cancel.UseVisualStyleBackColor = true;
            btn_cancel.Click += btn_cancel_Click;
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
            // groupBox1
            // 
            groupBox1.Controls.Add(dataGridViewOders);
            groupBox1.Location = new Point(27, 254);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(780, 160);
            groupBox1.TabIndex = 16;
            groupBox1.TabStop = false;
            groupBox1.Text = "Заказы сотрудника";
            // 
            // dataGridViewOders
            // 
            dataGridViewOders.AutoGenerateColumns = false;
            dataGridViewOders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOders.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, dateDataGridViewTextBoxColumn, summaDataGridViewTextBoxColumn, statusDataGridViewTextBoxColumn, adressdDataGridViewTextBoxColumn });
            dataGridViewOders.DataSource = oderBindingSource;
            dataGridViewOders.Dock = DockStyle.Fill;
            dataGridViewOders.Location = new Point(3, 23);
            dataGridViewOders.Name = "dataGridViewOders";
            dataGridViewOders.RowHeadersWidth = 51;
            dataGridViewOders.Size = new Size(774, 134);
            dataGridViewOders.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.MinimumWidth = 6;
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.Width = 125;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            dateDataGridViewTextBoxColumn.DataPropertyName = "date";
            dateDataGridViewTextBoxColumn.HeaderText = "date";
            dateDataGridViewTextBoxColumn.MinimumWidth = 6;
            dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            dateDataGridViewTextBoxColumn.Width = 125;
            // 
            // summaDataGridViewTextBoxColumn
            // 
            summaDataGridViewTextBoxColumn.DataPropertyName = "Summa";
            summaDataGridViewTextBoxColumn.HeaderText = "Summa";
            summaDataGridViewTextBoxColumn.MinimumWidth = 6;
            summaDataGridViewTextBoxColumn.Name = "summaDataGridViewTextBoxColumn";
            summaDataGridViewTextBoxColumn.Width = 125;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            statusDataGridViewTextBoxColumn.HeaderText = "Status";
            statusDataGridViewTextBoxColumn.MinimumWidth = 6;
            statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            statusDataGridViewTextBoxColumn.Width = 125;
            // 
            // adressdDataGridViewTextBoxColumn
            // 
            adressdDataGridViewTextBoxColumn.DataPropertyName = "Adress_d";
            adressdDataGridViewTextBoxColumn.HeaderText = "Adress_d";
            adressdDataGridViewTextBoxColumn.MinimumWidth = 6;
            adressdDataGridViewTextBoxColumn.Name = "adressdDataGridViewTextBoxColumn";
            adressdDataGridViewTextBoxColumn.Width = 125;
            // 
            // oderBindingSource
            // 
            oderBindingSource.DataSource = typeof(MyEF.Entities.Oder);
            // 
            // btnAddOder
            // 
            btnAddOder.DialogResult = DialogResult.OK;
            btnAddOder.Font = new Font("Segoe UI", 14F);
            btnAddOder.Location = new Point(30, 642);
            btnAddOder.Name = "btnAddOder";
            btnAddOder.Size = new Size(149, 46);
            btnAddOder.TabIndex = 17;
            btnAddOder.Text = "Добавить ";
            btnAddOder.UseVisualStyleBackColor = true;
            btnAddOder.Click += btnAddOder_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridViewFreeOders);
            groupBox2.Location = new Point(27, 476);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(780, 160);
            groupBox2.TabIndex = 18;
            groupBox2.TabStop = false;
            groupBox2.Text = "Все свободные заказы";
            // 
            // dataGridViewFreeOders
            // 
            dataGridViewFreeOders.AutoGenerateColumns = false;
            dataGridViewFreeOders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewFreeOders.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5 });
            dataGridViewFreeOders.DataSource = freeOderBindingSource;
            dataGridViewFreeOders.Dock = DockStyle.Fill;
            dataGridViewFreeOders.Location = new Point(3, 23);
            dataGridViewFreeOders.Name = "dataGridViewFreeOders";
            dataGridViewFreeOders.RowHeadersWidth = 51;
            dataGridViewFreeOders.Size = new Size(774, 134);
            dataGridViewFreeOders.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            dataGridViewTextBoxColumn1.HeaderText = "Id";
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.DataPropertyName = "date";
            dataGridViewTextBoxColumn2.HeaderText = "date";
            dataGridViewTextBoxColumn2.MinimumWidth = 6;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.DataPropertyName = "Summa";
            dataGridViewTextBoxColumn3.HeaderText = "Summa";
            dataGridViewTextBoxColumn3.MinimumWidth = 6;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.DataPropertyName = "Status";
            dataGridViewTextBoxColumn4.HeaderText = "Status";
            dataGridViewTextBoxColumn4.MinimumWidth = 6;
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.DataPropertyName = "Adress_d";
            dataGridViewTextBoxColumn5.HeaderText = "Adress_d";
            dataGridViewTextBoxColumn5.MinimumWidth = 6;
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            dataGridViewTextBoxColumn5.Width = 125;
            // 
            // freeOderBindingSource
            // 
            freeOderBindingSource.DataSource = typeof(MyEF.Entities.Oder);
            // 
            // btnRemoveOder
            // 
            btnRemoveOder.DialogResult = DialogResult.OK;
            btnRemoveOder.Font = new Font("Segoe UI", 14F);
            btnRemoveOder.Location = new Point(30, 424);
            btnRemoveOder.Name = "btnRemoveOder";
            btnRemoveOder.Size = new Size(149, 46);
            btnRemoveOder.TabIndex = 19;
            btnRemoveOder.Text = "Удалить";
            btnRemoveOder.UseVisualStyleBackColor = true;
            btnRemoveOder.Click += btnRemoveOder_Click;
            // 
            // PersonalFormUnit
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(819, 749);
            Controls.Add(btnRemoveOder);
            Controls.Add(groupBox2);
            Controls.Add(btnAddOder);
            Controls.Add(groupBox1);
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
            FormClosing += PersonalFormUnit_FormClosing;
            ((System.ComponentModel.ISupportInitialize)personalBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)categoriBindingSource).EndInit();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewOders).EndInit();
            ((System.ComponentModel.ISupportInitialize)oderBindingSource).EndInit();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewFreeOders).EndInit();
            ((System.ComponentModel.ISupportInitialize)freeOderBindingSource).EndInit();
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
        private GroupBox groupBox1;
        private DataGridView dataGridViewOders;
        private BindingSource oderBindingSource;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn summaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn adressdDataGridViewTextBoxColumn;
        private Button btnAddOder;
        private GroupBox groupBox2;
        private DataGridView dataGridViewFreeOders;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private BindingSource freeOderBindingSource;
        private Button btnRemoveOder;
    }
}