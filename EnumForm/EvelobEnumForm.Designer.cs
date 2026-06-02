namespace dodoEF.EnumForm
{
    partial class EvelobEnumForm
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
            dataGridView1 = new DataGridView();
            evelobilitileBindingSource = new BindingSource(components);
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            pizziriaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            fullNamePDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            reitKDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            enumOderDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            enumEvelDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            procentDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)evelobilitileBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, pizziriaDataGridViewTextBoxColumn, fullNamePDataGridViewTextBoxColumn, reitKDDataGridViewTextBoxColumn, enumOderDataGridViewTextBoxColumn, enumEvelDataGridViewTextBoxColumn, procentDataGridViewTextBoxColumn });
            dataGridView1.DataSource = evelobilitileBindingSource;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(935, 450);
            dataGridView1.TabIndex = 0;
            // 
            // evelobilitileBindingSource
            // 
            evelobilitileBindingSource.DataSource = typeof(MyEF.Entities.Evelobilitile);
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.MinimumWidth = 6;
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.Width = 125;
            // 
            // pizziriaDataGridViewTextBoxColumn
            // 
            pizziriaDataGridViewTextBoxColumn.DataPropertyName = "Pizziria";
            pizziriaDataGridViewTextBoxColumn.HeaderText = "Pizziria";
            pizziriaDataGridViewTextBoxColumn.MinimumWidth = 6;
            pizziriaDataGridViewTextBoxColumn.Name = "pizziriaDataGridViewTextBoxColumn";
            pizziriaDataGridViewTextBoxColumn.Width = 125;
            // 
            // fullNamePDataGridViewTextBoxColumn
            // 
            fullNamePDataGridViewTextBoxColumn.DataPropertyName = "FullName_P";
            fullNamePDataGridViewTextBoxColumn.HeaderText = "FullName_P";
            fullNamePDataGridViewTextBoxColumn.MinimumWidth = 6;
            fullNamePDataGridViewTextBoxColumn.Name = "fullNamePDataGridViewTextBoxColumn";
            fullNamePDataGridViewTextBoxColumn.Width = 125;
            // 
            // reitKDDataGridViewTextBoxColumn
            // 
            reitKDDataGridViewTextBoxColumn.DataPropertyName = "Reit_K_D";
            reitKDDataGridViewTextBoxColumn.HeaderText = "Reit_K_D";
            reitKDDataGridViewTextBoxColumn.MinimumWidth = 6;
            reitKDDataGridViewTextBoxColumn.Name = "reitKDDataGridViewTextBoxColumn";
            reitKDDataGridViewTextBoxColumn.Width = 125;
            // 
            // enumOderDataGridViewTextBoxColumn
            // 
            enumOderDataGridViewTextBoxColumn.DataPropertyName = "Enum_Oder";
            enumOderDataGridViewTextBoxColumn.HeaderText = "Enum_Oder";
            enumOderDataGridViewTextBoxColumn.MinimumWidth = 6;
            enumOderDataGridViewTextBoxColumn.Name = "enumOderDataGridViewTextBoxColumn";
            enumOderDataGridViewTextBoxColumn.Width = 125;
            // 
            // enumEvelDataGridViewTextBoxColumn
            // 
            enumEvelDataGridViewTextBoxColumn.DataPropertyName = "Enum_Evel";
            enumEvelDataGridViewTextBoxColumn.HeaderText = "Enum_Evel";
            enumEvelDataGridViewTextBoxColumn.MinimumWidth = 6;
            enumEvelDataGridViewTextBoxColumn.Name = "enumEvelDataGridViewTextBoxColumn";
            enumEvelDataGridViewTextBoxColumn.Width = 125;
            // 
            // procentDataGridViewTextBoxColumn
            // 
            procentDataGridViewTextBoxColumn.DataPropertyName = "Procent";
            procentDataGridViewTextBoxColumn.HeaderText = "Procent";
            procentDataGridViewTextBoxColumn.MinimumWidth = 6;
            procentDataGridViewTextBoxColumn.Name = "procentDataGridViewTextBoxColumn";
            procentDataGridViewTextBoxColumn.Width = 125;
            // 
            // EvelobEnumForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(935, 450);
            Controls.Add(dataGridView1);
            Name = "EvelobEnumForm";
            Text = "Перечисление \"Оцениваемости\"";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)evelobilitileBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn pizziriaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fullNamePDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn reitKDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn enumOderDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn enumEvelDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn procentDataGridViewTextBoxColumn;
        private BindingSource evelobilitileBindingSource;
    }
}