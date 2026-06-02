namespace dodoEF.EnumForm
{
    partial class PlategEnumForm
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
            plategBindingSource = new BindingSource(components);
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            statusPLDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            sposobPLDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            oderDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)plategBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, statusPLDataGridViewTextBoxColumn, sposobPLDataGridViewTextBoxColumn, oderDataGridViewTextBoxColumn });
            dataGridView1.DataSource = plategBindingSource;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(557, 450);
            dataGridView1.TabIndex = 0;
            // 
            // plategBindingSource
            // 
            plategBindingSource.DataSource = typeof(MyEF.Entities.Plateg);
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.MinimumWidth = 6;
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.Width = 125;
            // 
            // statusPLDataGridViewTextBoxColumn
            // 
            statusPLDataGridViewTextBoxColumn.DataPropertyName = "Status_PL";
            statusPLDataGridViewTextBoxColumn.HeaderText = "Status_PL";
            statusPLDataGridViewTextBoxColumn.MinimumWidth = 6;
            statusPLDataGridViewTextBoxColumn.Name = "statusPLDataGridViewTextBoxColumn";
            statusPLDataGridViewTextBoxColumn.Width = 125;
            // 
            // sposobPLDataGridViewTextBoxColumn
            // 
            sposobPLDataGridViewTextBoxColumn.DataPropertyName = "Sposob_PL";
            sposobPLDataGridViewTextBoxColumn.HeaderText = "Sposob_PL";
            sposobPLDataGridViewTextBoxColumn.MinimumWidth = 6;
            sposobPLDataGridViewTextBoxColumn.Name = "sposobPLDataGridViewTextBoxColumn";
            sposobPLDataGridViewTextBoxColumn.Width = 125;
            // 
            // oderDataGridViewTextBoxColumn
            // 
            oderDataGridViewTextBoxColumn.DataPropertyName = "Oder";
            oderDataGridViewTextBoxColumn.HeaderText = "Oder";
            oderDataGridViewTextBoxColumn.MinimumWidth = 6;
            oderDataGridViewTextBoxColumn.Name = "oderDataGridViewTextBoxColumn";
            oderDataGridViewTextBoxColumn.Width = 125;
            // 
            // PlategEnumForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(557, 450);
            Controls.Add(dataGridView1);
            Name = "PlategEnumForm";
            Text = "Перечисление \"Платеж\"";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)plategBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn statusPLDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn sposobPLDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn oderDataGridViewTextBoxColumn;
        private BindingSource plategBindingSource;
    }
}