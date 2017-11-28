namespace How_become_milioner
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.Start = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.играToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.начатьИгруToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.остановитьИгруToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выйтиИзИгрыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.администраторскийРежимToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.создатьВопросToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.редактироватьВопросToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьВопросToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.подсказкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label1.Location = new System.Drawing.Point(-3, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(794, 565);
            this.label1.TabIndex = 0;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Start
            // 
            this.Start.Location = new System.Drawing.Point(318, 214);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(186, 54);
            this.Start.TabIndex = 1;
            this.Start.Text = "Новая игра";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(318, 327);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(186, 54);
            this.Exit.TabIndex = 2;
            this.Exit.Text = "Выход";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.играToolStripMenuItem,
            this.администраторскийРежимToolStripMenuItem,
            this.оПрограммеToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(791, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // играToolStripMenuItem
            // 
            this.играToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.начатьИгруToolStripMenuItem,
            this.остановитьИгруToolStripMenuItem,
            this.выйтиИзИгрыToolStripMenuItem});
            this.играToolStripMenuItem.Name = "играToolStripMenuItem";
            this.играToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.играToolStripMenuItem.Text = "Игра";
            // 
            // начатьИгруToolStripMenuItem
            // 
            this.начатьИгруToolStripMenuItem.Name = "начатьИгруToolStripMenuItem";
            this.начатьИгруToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.начатьИгруToolStripMenuItem.Text = "Начать игру";
            this.начатьИгруToolStripMenuItem.Click += new System.EventHandler(this.начатьИгруToolStripMenuItem_Click);
            // 
            // остановитьИгруToolStripMenuItem
            // 
            this.остановитьИгруToolStripMenuItem.Name = "остановитьИгруToolStripMenuItem";
            this.остановитьИгруToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.остановитьИгруToolStripMenuItem.Text = "Остановить игру";
            // 
            // выйтиИзИгрыToolStripMenuItem
            // 
            this.выйтиИзИгрыToolStripMenuItem.Name = "выйтиИзИгрыToolStripMenuItem";
            this.выйтиИзИгрыToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.выйтиИзИгрыToolStripMenuItem.Text = "Выйти из игры";
            // 
            // администраторскийРежимToolStripMenuItem
            // 
            this.администраторскийРежимToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.создатьВопросToolStripMenuItem,
            this.редактироватьВопросToolStripMenuItem,
            this.удалитьВопросToolStripMenuItem});
            this.администраторскийРежимToolStripMenuItem.Name = "администраторскийРежимToolStripMenuItem";
            this.администраторскийРежимToolStripMenuItem.Size = new System.Drawing.Size(173, 20);
            this.администраторскийРежимToolStripMenuItem.Text = "Администраторский режим";
            // 
            // создатьВопросToolStripMenuItem
            // 
            this.создатьВопросToolStripMenuItem.Name = "создатьВопросToolStripMenuItem";
            this.создатьВопросToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.создатьВопросToolStripMenuItem.Text = "Создать вопрос";
            this.создатьВопросToolStripMenuItem.Click += new System.EventHandler(this.создатьВопросToolStripMenuItem_Click);
            // 
            // редактироватьВопросToolStripMenuItem
            // 
            this.редактироватьВопросToolStripMenuItem.Name = "редактироватьВопросToolStripMenuItem";
            this.редактироватьВопросToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.редактироватьВопросToolStripMenuItem.Text = "Редактировать вопрос";
            // 
            // удалитьВопросToolStripMenuItem
            // 
            this.удалитьВопросToolStripMenuItem.Name = "удалитьВопросToolStripMenuItem";
            this.удалитьВопросToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.удалитьВопросToolStripMenuItem.Text = "Удалить вопрос";
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.подсказкаToolStripMenuItem});
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            // 
            // подсказкаToolStripMenuItem
            // 
            this.подсказкаToolStripMenuItem.Name = "подсказкаToolStripMenuItem";
            this.подсказкаToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.подсказкаToolStripMenuItem.Text = "Подсказка";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(791, 588);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem играToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem начатьИгруToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem остановитьИгруToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выйтиИзИгрыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem администраторскийРежимToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem создатьВопросToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem редактироватьВопросToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьВопросToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem подсказкаToolStripMenuItem;
    }
}

