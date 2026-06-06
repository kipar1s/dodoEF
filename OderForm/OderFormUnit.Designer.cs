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
            textBox6 = new TextBox();
            label4 = new Label();
            groupBox1 = new GroupBox();
            dataGridViewTovat = new DataGridView();
            tovarBindingSource = new BindingSource(components);
            cB_Status = new ComboBox();
            plategBindingSource = new BindingSource(components);
            listViewSposob = new ListView();
            Sposob_OP = new ColumnHeader();
            listViewStatus = new ListView();
            columnHeader1 = new ColumnHeader();
            btnRemoveTovar = new Button();
            groupBox2 = new GroupBox();
            dataGridViewAllTovars = new DataGridView();
            tovarBindingSource1 = new BindingSource(components);
            btnAddTovar = new Button();
            ((System.ComponentModel.ISupportInitialize)oderBindingSource).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTovat).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tovarBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)plategBindingSource).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAllTovars).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tovarBindingSource1).BeginInit();
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
            btn_cancel.Font = new Font("Segoe UI", 20F);
            btn_cancel.Location = new Point(766, 194);
            btn_cancel.Name = "btn_cancel";
            btn_cancel.Size = new Size(169, 98);
            btn_cancel.TabIndex = 27;
            btn_cancel.Text = "Отмена";
            btn_cancel.UseVisualStyleBackColor = true;
            // 
            // btn_OK
            // 
            btn_OK.DialogResult = DialogResult.OK;
            btn_OK.Font = new Font("Segoe UI", 20F);
            btn_OK.Location = new Point(558, 194);
            btn_OK.Name = "btn_OK";
            btn_OK.Size = new Size(153, 98);
            btn_OK.TabIndex = 26;
            btn_OK.Text = "OK";
            btn_OK.UseVisualStyleBackColor = true;
            btn_OK.Click += btn_OK_Click;
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
            groupBox1.Controls.Add(dataGridViewTovat);
            groupBox1.Location = new Point(33, 314);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(905, 250);
            groupBox1.TabIndex = 33;
            groupBox1.TabStop = false;
            groupBox1.Text = "Товары в заказе";
            // 
            // dataGridViewTovat
            // 
            dataGridViewTovat.AutoGenerateColumns = false;
            dataGridViewTovat.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTovat.DataSource = tovarBindingSource;
            dataGridViewTovat.Dock = DockStyle.Fill;
            dataGridViewTovat.Location = new Point(3, 23);
            dataGridViewTovat.Name = "dataGridViewTovat";
            dataGridViewTovat.RowHeadersWidth = 51;
            dataGridViewTovat.Size = new Size(899, 224);
            dataGridViewTovat.TabIndex = 0;
            // 
            // tovarBindingSource
            // 
            tovarBindingSource.DataSource = typeof(MyEF.Entities.Tovar);
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
            // plategBindingSource
            // 
            plategBindingSource.DataSource = typeof(MyEF.Entities.Plateg);
            // 
            // listViewSposob
            // 
            listViewSposob.CheckBoxes = true;
            listViewSposob.Columns.AddRange(new ColumnHeader[] { Sposob_OP });
            listViewSposob.FullRowSelect = true;
            listViewSposob.Location = new Point(522, 31);
            listViewSposob.MultiSelect = false;
            listViewSposob.Name = "listViewSposob";
            listViewSposob.Size = new Size(225, 157);
            listViewSposob.TabIndex = 35;
            listViewSposob.UseCompatibleStateImageBehavior = false;
            listViewSposob.UseWaitCursor = true;
            listViewSposob.View = View.Details;
            // 
            // Sposob_OP
            // 
            Sposob_OP.Text = "Выберите способ оплаты";
            Sposob_OP.Width = 220;
            // 
            // listViewStatus
            // 
            listViewStatus.CheckBoxes = true;
            listViewStatus.Columns.AddRange(new ColumnHeader[] { columnHeader1 });
            listViewStatus.FullRowSelect = true;
            listViewStatus.Location = new Point(753, 31);
            listViewStatus.MultiSelect = false;
            listViewStatus.Name = "listViewStatus";
            listViewStatus.Size = new Size(205, 157);
            listViewStatus.TabIndex = 36;
            listViewStatus.UseCompatibleStateImageBehavior = false;
            listViewStatus.UseWaitCursor = true;
            listViewStatus.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Выберите статус оплаты";
            columnHeader1.Width = 200;
            // 
            // btnRemoveTovar
            // 
            btnRemoveTovar.Font = new Font("Segoe UI", 14F);
            btnRemoveTovar.Location = new Point(33, 570);
            btnRemoveTovar.Name = "btnRemoveTovar";
            btnRemoveTovar.Size = new Size(149, 46);
            btnRemoveTovar.TabIndex = 39;
            btnRemoveTovar.Text = "Удалить";
            btnRemoveTovar.UseVisualStyleBackColor = true;
            btnRemoveTovar.Click += btnRemoveTovar_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridViewAllTovars);
            groupBox2.Location = new Point(33, 622);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(902, 235);
            groupBox2.TabIndex = 38;
            groupBox2.TabStop = false;
            groupBox2.Text = "Все доступные товары";
            // 
            // dataGridViewAllTovars
            // 
            dataGridViewAllTovars.AutoGenerateColumns = false;
            dataGridViewAllTovars.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAllTovars.DataSource = tovarBindingSource1;
            dataGridViewAllTovars.Dock = DockStyle.Fill;
            dataGridViewAllTovars.Location = new Point(3, 23);
            dataGridViewAllTovars.Name = "dataGridViewAllTovars";
            dataGridViewAllTovars.RowHeadersWidth = 51;
            dataGridViewAllTovars.Size = new Size(896, 209);
            dataGridViewAllTovars.TabIndex = 0;
            // 
            // tovarBindingSource1
            // 
            tovarBindingSource1.DataSource = typeof(MyEF.Entities.Tovar);
            // 
            // btnAddTovar
            // 
            btnAddTovar.Font = new Font("Segoe UI", 14F);
            btnAddTovar.Location = new Point(27, 863);
            btnAddTovar.Name = "btnAddTovar";
            btnAddTovar.Size = new Size(149, 46);
            btnAddTovar.TabIndex = 37;
            btnAddTovar.Text = "Добавить ";
            btnAddTovar.UseVisualStyleBackColor = true;
            btnAddTovar.Click += btnAddTovar_Click;
            // 
            // OderFormUnit
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(975, 945);
            Controls.Add(btnRemoveTovar);
            Controls.Add(groupBox2);
            Controls.Add(btnAddTovar);
            Controls.Add(listViewStatus);
            Controls.Add(listViewSposob);
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
            Load += OderFormUnit_Load;
            ((System.ComponentModel.ISupportInitialize)oderBindingSource).EndInit();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewTovat).EndInit();
            ((System.ComponentModel.ISupportInitialize)tovarBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)plategBindingSource).EndInit();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewAllTovars).EndInit();
            ((System.ComponentModel.ISupportInitialize)tovarBindingSource1).EndInit();
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
        private TextBox textBox6;
        private Label label4;
        private GroupBox groupBox1;
        private DataGridView dataGridViewTovat;
        private BindingSource tovarBindingSource;
        private ComboBox cB_Status;
        private BindingSource plategBindingSource;
        private DataGridViewTextBoxColumn oderDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn oderidDataGridViewTextBoxColumn;
        private ListView listViewSposob;
        private ColumnHeader Sposob_OP;
        private ListView listViewStatus;
        private ColumnHeader columnHeader1;
        private Button btnRemoveTovar;
        private GroupBox groupBox2;
        private DataGridView dataGridViewAllTovars;
        private BindingSource tovarBindingSource1;
        private Button btnAddTovar;
    }
}