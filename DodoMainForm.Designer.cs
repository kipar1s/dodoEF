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
            menuStrip1 = new MenuStrip();
            справочникToolStripMenuItem = new ToolStripMenuItem();
            сотрудникиToolStripMenuItem = new ToolStripMenuItem();
            заказToolStripMenuItem = new ToolStripMenuItem();
            клиентToolStripMenuItem = new ToolStripMenuItem();
            товарToolStripMenuItem = new ToolStripMenuItem();
            перечисленияToolStripMenuItem = new ToolStripMenuItem();
            категорииToolStripMenuItem = new ToolStripMenuItem();
            оцениваемостьToolStripMenuItem = new ToolStripMenuItem();
            ингридиентыToolStripMenuItem = new ToolStripMenuItem();
            платежToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { справочникToolStripMenuItem, перечисленияToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1254, 28);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // справочникToolStripMenuItem
            // 
            справочникToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { сотрудникиToolStripMenuItem, заказToolStripMenuItem, клиентToolStripMenuItem, товарToolStripMenuItem });
            справочникToolStripMenuItem.Name = "справочникToolStripMenuItem";
            справочникToolStripMenuItem.Size = new Size(108, 24);
            справочникToolStripMenuItem.Text = "Справочник";
            // 
            // сотрудникиToolStripMenuItem
            // 
            сотрудникиToolStripMenuItem.Name = "сотрудникиToolStripMenuItem";
            сотрудникиToolStripMenuItem.Size = new Size(224, 26);
            сотрудникиToolStripMenuItem.Text = "Сотрудники";
            сотрудникиToolStripMenuItem.Click += сотрудникиToolStripMenuItem_Click;
            // 
            // заказToolStripMenuItem
            // 
            заказToolStripMenuItem.Name = "заказToolStripMenuItem";
            заказToolStripMenuItem.Size = new Size(224, 26);
            заказToolStripMenuItem.Text = "Заказ";
            заказToolStripMenuItem.Click += заказToolStripMenuItem_Click;
            // 
            // клиентToolStripMenuItem
            // 
            клиентToolStripMenuItem.Name = "клиентToolStripMenuItem";
            клиентToolStripMenuItem.Size = new Size(224, 26);
            клиентToolStripMenuItem.Text = "Клиент";
            клиентToolStripMenuItem.Click += клиентToolStripMenuItem_Click;
            // 
            // перечисленияToolStripMenuItem
            // 
            перечисленияToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { категорииToolStripMenuItem, оцениваемостьToolStripMenuItem, ингридиентыToolStripMenuItem, платежToolStripMenuItem });
            перечисленияToolStripMenuItem.Name = "перечисленияToolStripMenuItem";
            перечисленияToolStripMenuItem.Size = new Size(125, 24);
            перечисленияToolStripMenuItem.Text = "Перечисления";
            // 
            // категорииToolStripMenuItem
            // 
            категорииToolStripMenuItem.Name = "категорииToolStripMenuItem";
            категорииToolStripMenuItem.Size = new Size(203, 26);
            категорииToolStripMenuItem.Text = "Категории";
            категорииToolStripMenuItem.Click += категорииToolStripMenuItem_Click;
            // 
            // оцениваемостьToolStripMenuItem
            // 
            оцениваемостьToolStripMenuItem.Name = "оцениваемостьToolStripMenuItem";
            оцениваемостьToolStripMenuItem.Size = new Size(203, 26);
            оцениваемостьToolStripMenuItem.Text = "Оцениваемость";
            оцениваемостьToolStripMenuItem.Click += оцениваемостьToolStripMenuItem_Click;
            // 
            // ингридиентыToolStripMenuItem
            // 
            ингридиентыToolStripMenuItem.Name = "ингридиентыToolStripMenuItem";
            ингридиентыToolStripMenuItem.Size = new Size(203, 26);
            ингридиентыToolStripMenuItem.Text = "Ингридиенты";
            ингридиентыToolStripMenuItem.Click += ингридиентыToolStripMenuItem_Click;
            // 
            // платежToolStripMenuItem
            // 
            платежToolStripMenuItem.Name = "платежToolStripMenuItem";
            платежToolStripMenuItem.Size = new Size(203, 26);
            платежToolStripMenuItem.Text = "Платеж";
            платежToolStripMenuItem.Click += платежToolStripMenuItem_Click;
            // 
            // товарToolStripMenuItem
            // 
            товарToolStripMenuItem.Name = "товарToolStripMenuItem";
            товарToolStripMenuItem.Size = new Size(224, 26);
            товарToolStripMenuItem.Text = "Товар";
            товарToolStripMenuItem.Click += товарToolStripMenuItem_Click;
            // 
            // DodoMainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1254, 617);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "DodoMainForm";
            Text = "Додо Пиица";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem справочникToolStripMenuItem;
        private ToolStripMenuItem сотрудникиToolStripMenuItem;
        private ToolStripMenuItem заказToolStripMenuItem;
        private ToolStripMenuItem клиентToolStripMenuItem;
        private ToolStripMenuItem товарToolStripMenuItem;
        private ToolStripMenuItem перечисленияToolStripMenuItem;
        private ToolStripMenuItem категорииToolStripMenuItem;
        private ToolStripMenuItem оцениваемостьToolStripMenuItem;
        private ToolStripMenuItem ингридиентыToolStripMenuItem;
        private ToolStripMenuItem платежToolStripMenuItem;
    }
}
