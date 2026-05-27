namespace dodoEF.PersonalForm
{
    partial class PersonalListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PersonalListForm));
            toolStrip1 = new ToolStrip();
            tsB_Create = new ToolStripButton();
            tsB_Edit = new ToolStripButton();
            tsB_Delite = new ToolStripButton();
            dataGridView1 = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            fullNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            stageDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            categorDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            loginDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            passwordDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            personalBindingSource = new BindingSource(components);
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)personalBindingSource).BeginInit();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { tsB_Create, tsB_Edit, tsB_Delite });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 27);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // tsB_Create
            // 
            tsB_Create.DisplayStyle = ToolStripItemDisplayStyle.Text;
            tsB_Create.Image = (Image)resources.GetObject("tsB_Create.Image");
            tsB_Create.ImageTransparentColor = Color.Magenta;
            tsB_Create.Name = "tsB_Create";
            tsB_Create.Size = new Size(68, 24);
            tsB_Create.Text = "Создать";
            tsB_Create.Click += tsB_Create_Click;
            // 
            // tsB_Edit
            // 
            tsB_Edit.DisplayStyle = ToolStripItemDisplayStyle.Text;
            tsB_Edit.Image = (Image)resources.GetObject("tsB_Edit.Image");
            tsB_Edit.ImageTransparentColor = Color.Magenta;
            tsB_Edit.Name = "tsB_Edit";
            tsB_Edit.Size = new Size(115, 24);
            tsB_Edit.Text = "Редактировать";
            // 
            // tsB_Delite
            // 
            tsB_Delite.DisplayStyle = ToolStripItemDisplayStyle.Text;
            tsB_Delite.Image = (Image)resources.GetObject("tsB_Delite.Image");
            tsB_Delite.ImageTransparentColor = Color.Magenta;
            tsB_Delite.Name = "tsB_Delite";
            tsB_Delite.Size = new Size(69, 24);
            tsB_Delite.Text = "Удалить";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, fullNameDataGridViewTextBoxColumn, stageDataGridViewTextBoxColumn, categorDataGridViewTextBoxColumn, loginDataGridViewTextBoxColumn, passwordDataGridViewTextBoxColumn });
            dataGridView1.DataSource = personalBindingSource;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 27);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(800, 423);
            dataGridView1.TabIndex = 1;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.MinimumWidth = 6;
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.Width = 125;
            // 
            // fullNameDataGridViewTextBoxColumn
            // 
            fullNameDataGridViewTextBoxColumn.DataPropertyName = "FullName";
            fullNameDataGridViewTextBoxColumn.HeaderText = "FullName";
            fullNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            fullNameDataGridViewTextBoxColumn.Name = "fullNameDataGridViewTextBoxColumn";
            fullNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // stageDataGridViewTextBoxColumn
            // 
            stageDataGridViewTextBoxColumn.DataPropertyName = "Stage";
            stageDataGridViewTextBoxColumn.HeaderText = "Stage";
            stageDataGridViewTextBoxColumn.MinimumWidth = 6;
            stageDataGridViewTextBoxColumn.Name = "stageDataGridViewTextBoxColumn";
            stageDataGridViewTextBoxColumn.Width = 125;
            // 
            // categorDataGridViewTextBoxColumn
            // 
            categorDataGridViewTextBoxColumn.DataPropertyName = "Categor";
            categorDataGridViewTextBoxColumn.HeaderText = "Categor";
            categorDataGridViewTextBoxColumn.MinimumWidth = 6;
            categorDataGridViewTextBoxColumn.Name = "categorDataGridViewTextBoxColumn";
            categorDataGridViewTextBoxColumn.Width = 125;
            // 
            // loginDataGridViewTextBoxColumn
            // 
            loginDataGridViewTextBoxColumn.DataPropertyName = "Login";
            loginDataGridViewTextBoxColumn.HeaderText = "Login";
            loginDataGridViewTextBoxColumn.MinimumWidth = 6;
            loginDataGridViewTextBoxColumn.Name = "loginDataGridViewTextBoxColumn";
            loginDataGridViewTextBoxColumn.Width = 125;
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            passwordDataGridViewTextBoxColumn.DataPropertyName = "Password";
            passwordDataGridViewTextBoxColumn.HeaderText = "Password";
            passwordDataGridViewTextBoxColumn.MinimumWidth = 6;
            passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            passwordDataGridViewTextBoxColumn.Width = 125;
            // 
            // personalBindingSource
            // 
            personalBindingSource.DataSource = typeof(MyEF.Entities.Personal);
            // 
            // PersonalListForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(toolStrip1);
            Name = "PersonalListForm";
            Text = "Справочник \"Пользователи\"";
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)personalBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripButton tsB_Create;
        private ToolStripButton tsB_Edit;
        private ToolStripButton tsB_Delite;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fullNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn stageDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn categorDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn loginDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private BindingSource personalBindingSource;
    }
}