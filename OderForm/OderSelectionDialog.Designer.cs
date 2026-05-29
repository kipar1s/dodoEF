namespace dodoEF.OderForm
{
    partial class OderSelectionDialog
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
            btn_Cancel = new Button();
            btn_OK = new Button();
            label1 = new Label();
            comboBox1 = new ComboBox();
            clientBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)clientBindingSource).BeginInit();
            SuspendLayout();
            // 
            // btn_Cancel
            // 
            btn_Cancel.DialogResult = DialogResult.Cancel;
            btn_Cancel.Font = new Font("Segoe UI", 12F);
            btn_Cancel.Location = new Point(257, 123);
            btn_Cancel.Name = "btn_Cancel";
            btn_Cancel.Size = new Size(112, 40);
            btn_Cancel.TabIndex = 7;
            btn_Cancel.Text = "Отмена";
            btn_Cancel.UseVisualStyleBackColor = true;
            // 
            // btn_OK
            // 
            btn_OK.DialogResult = DialogResult.OK;
            btn_OK.Font = new Font("Segoe UI", 12F);
            btn_OK.Location = new Point(68, 123);
            btn_OK.Name = "btn_OK";
            btn_OK.Size = new Size(112, 40);
            btn_OK.TabIndex = 6;
            btn_OK.Text = "ОК";
            btn_OK.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F);
            label1.Location = new Point(105, 26);
            label1.Name = "label1";
            label1.Size = new Size(246, 37);
            label1.TabIndex = 5;
            label1.Text = "Выберите Клиента";
            // 
            // comboBox1
            // 
            comboBox1.DataSource = clientBindingSource;
            comboBox1.DisplayMember = "FullName";
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(22, 79);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(413, 28);
            comboBox1.TabIndex = 4;
            comboBox1.ValueMember = "Id";
            // 
            // clientBindingSource
            // 
            clientBindingSource.DataSource = typeof(MyEF.Entities.Client);
            // 
            // OderSelectionDialog
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(470, 206);
            Controls.Add(btn_Cancel);
            Controls.Add(btn_OK);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Name = "OderSelectionDialog";
            ((System.ComponentModel.ISupportInitialize)clientBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_Cancel;
        private Button btn_OK;
        private Label label1;
        private ComboBox comboBox1;
        private BindingSource clientBindingSource;
    }
}