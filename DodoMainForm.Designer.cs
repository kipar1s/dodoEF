namespace dodoEF
{
    partial class DodoMainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DodoMainForm));
            toolStrip1 = new ToolStrip();
            tsB_Spravochnik = new ToolStripButton();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { tsB_Spravochnik });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 27);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStripMain";
            // 
            // tsB_Spravochnik
            // 
            tsB_Spravochnik.DisplayStyle = ToolStripItemDisplayStyle.Text;
            tsB_Spravochnik.Image = (Image)resources.GetObject("tsB_Spravochnik.Image");
            tsB_Spravochnik.ImageTransparentColor = Color.Magenta;
            tsB_Spravochnik.Name = "tsB_Spravochnik";
            tsB_Spravochnik.Size = new Size(98, 24);
            tsB_Spravochnik.Text = "Справочник";
            // 
            // DodoMainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(toolStrip1);
            IsMdiContainer = true;
            Name = "DodoMainForm";
            Text = "Додо Пиица";
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripButton tsB_Spravochnik;
    }
}
