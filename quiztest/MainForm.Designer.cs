namespace quiztest
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.questionLabel = new System.Windows.Forms.Label();
            this.confirmBtn = new System.Windows.Forms.Button();
            this.nextBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.управлениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитВопросToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.изменитьВопросToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьВопросToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel3 = new System.Windows.Forms.Panel();
            this.optPanel = new System.Windows.Forms.Panel();
            this.timerLabel = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.qstnNumLabel = new System.Windows.Forms.Label();
            this.установитьТаймерToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timerSetPanel = new System.Windows.Forms.Panel();
            this.timerTB = new System.Windows.Forms.TextBox();
            this.setTimerBtn = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.timerSetPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // questionLabel
            // 
            this.questionLabel.AutoSize = true;
            this.questionLabel.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.questionLabel.Location = new System.Drawing.Point(28, 57);
            this.questionLabel.Name = "questionLabel";
            this.questionLabel.Size = new System.Drawing.Size(179, 23);
            this.questionLabel.TabIndex = 0;
            this.questionLabel.Text = "Столица России?";
            // 
            // confirmBtn
            // 
            this.confirmBtn.FlatAppearance.BorderSize = 0;
            this.confirmBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.confirmBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.confirmBtn.Image = ((System.Drawing.Image)(resources.GetObject("confirmBtn.Image")));
            this.confirmBtn.Location = new System.Drawing.Point(793, 394);
            this.confirmBtn.Name = "confirmBtn";
            this.confirmBtn.Size = new System.Drawing.Size(85, 67);
            this.confirmBtn.TabIndex = 2;
            this.confirmBtn.UseVisualStyleBackColor = true;
            this.confirmBtn.Click += new System.EventHandler(this.confirmBtn_Click);
            // 
            // nextBtn
            // 
            this.nextBtn.FlatAppearance.BorderSize = 0;
            this.nextBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nextBtn.Image = ((System.Drawing.Image)(resources.GetObject("nextBtn.Image")));
            this.nextBtn.Location = new System.Drawing.Point(32, 407);
            this.nextBtn.Name = "nextBtn";
            this.nextBtn.Size = new System.Drawing.Size(95, 43);
            this.nextBtn.TabIndex = 10;
            this.nextBtn.UseVisualStyleBackColor = true;
            this.nextBtn.Click += new System.EventHandler(this.nextBtn_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(208)))), ((int)(((byte)(63)))));
            this.panel2.Controls.Add(this.menuStrip);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(955, 28);
            this.panel2.TabIndex = 12;
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(208)))), ((int)(((byte)(63)))));
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.управлениеToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(6, 4, 0, 2);
            this.menuStrip.Size = new System.Drawing.Size(955, 25);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выходToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 19);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // управлениеToolStripMenuItem
            // 
            this.управлениеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитВопросToolStripMenuItem,
            this.изменитьВопросToolStripMenuItem,
            this.удалитьВопросToolStripMenuItem,
            this.установитьТаймерToolStripMenuItem});
            this.управлениеToolStripMenuItem.Name = "управлениеToolStripMenuItem";
            this.управлениеToolStripMenuItem.Size = new System.Drawing.Size(85, 19);
            this.управлениеToolStripMenuItem.Text = "Управление";
            // 
            // добавитВопросToolStripMenuItem
            // 
            this.добавитВопросToolStripMenuItem.Name = "добавитВопросToolStripMenuItem";
            this.добавитВопросToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.добавитВопросToolStripMenuItem.Text = "Добавит вопрос";
            this.добавитВопросToolStripMenuItem.Click += new System.EventHandler(this.добавитВопросToolStripMenuItem_Click);
            // 
            // изменитьВопросToolStripMenuItem
            // 
            this.изменитьВопросToolStripMenuItem.Name = "изменитьВопросToolStripMenuItem";
            this.изменитьВопросToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.изменитьВопросToolStripMenuItem.Text = "Изменить вопрос";
            this.изменитьВопросToolStripMenuItem.Click += new System.EventHandler(this.изменитьВопросToolStripMenuItem_Click);
            // 
            // удалитьВопросToolStripMenuItem
            // 
            this.удалитьВопросToolStripMenuItem.Name = "удалитьВопросToolStripMenuItem";
            this.удалитьВопросToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.удалитьВопросToolStripMenuItem.Text = "Удалить вопрос";
            this.удалитьВопросToolStripMenuItem.Click += new System.EventHandler(this.удалитьВопросToolStripMenuItem_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 515);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(955, 25);
            this.panel3.TabIndex = 13;
            // 
            // optPanel
            // 
            this.optPanel.Location = new System.Drawing.Point(32, 164);
            this.optPanel.Name = "optPanel";
            this.optPanel.Size = new System.Drawing.Size(911, 180);
            this.optPanel.TabIndex = 17;
            // 
            // timerLabel
            // 
            this.timerLabel.AutoSize = true;
            this.timerLabel.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.timerLabel.Location = new System.Drawing.Point(760, 94);
            this.timerLabel.Name = "timerLabel";
            this.timerLabel.Size = new System.Drawing.Size(69, 23);
            this.timerLabel.TabIndex = 18;
            this.timerLabel.Text = "label1";
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // qstnNumLabel
            // 
            this.qstnNumLabel.AutoSize = true;
            this.qstnNumLabel.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.qstnNumLabel.Location = new System.Drawing.Point(760, 57);
            this.qstnNumLabel.Name = "qstnNumLabel";
            this.qstnNumLabel.Size = new System.Drawing.Size(69, 23);
            this.qstnNumLabel.TabIndex = 19;
            this.qstnNumLabel.Text = "label1";
            // 
            // установитьТаймерToolStripMenuItem
            // 
            this.установитьТаймерToolStripMenuItem.Name = "установитьТаймерToolStripMenuItem";
            this.установитьТаймерToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.установитьТаймерToolStripMenuItem.Text = "Установить таймер";
            this.установитьТаймерToolStripMenuItem.Click += new System.EventHandler(this.установитьТаймерToolStripMenuItem_Click);
            // 
            // timerSetPanel
            // 
            this.timerSetPanel.Controls.Add(this.setTimerBtn);
            this.timerSetPanel.Controls.Add(this.timerTB);
            this.timerSetPanel.Location = new System.Drawing.Point(388, 377);
            this.timerSetPanel.Name = "timerSetPanel";
            this.timerSetPanel.Size = new System.Drawing.Size(200, 100);
            this.timerSetPanel.TabIndex = 20;
            this.timerSetPanel.Visible = false;
            // 
            // timerTB
            // 
            this.timerTB.Location = new System.Drawing.Point(80, 17);
            this.timerTB.Name = "timerTB";
            this.timerTB.Size = new System.Drawing.Size(48, 20);
            this.timerTB.TabIndex = 0;
            // 
            // setTimerBtn
            // 
            this.setTimerBtn.Location = new System.Drawing.Point(80, 61);
            this.setTimerBtn.Name = "setTimerBtn";
            this.setTimerBtn.Size = new System.Drawing.Size(48, 23);
            this.setTimerBtn.TabIndex = 1;
            this.setTimerBtn.Text = "Ok";
            this.setTimerBtn.UseVisualStyleBackColor = true;
            this.setTimerBtn.Click += new System.EventHandler(this.setTimerBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(955, 540);
            this.Controls.Add(this.timerSetPanel);
            this.Controls.Add(this.qstnNumLabel);
            this.Controls.Add(this.timerLabel);
            this.Controls.Add(this.optPanel);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.nextBtn);
            this.Controls.Add(this.confirmBtn);
            this.Controls.Add(this.questionLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.timerSetPanel.ResumeLayout(false);
            this.timerSetPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label questionLabel;
        private System.Windows.Forms.Button confirmBtn;
        private System.Windows.Forms.Button nextBtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem управлениеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитВопросToolStripMenuItem;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ToolStripMenuItem изменитьВопросToolStripMenuItem;
        private System.Windows.Forms.Panel optPanel;
        private System.Windows.Forms.Label timerLabel;
        private System.Windows.Forms.ToolStripMenuItem удалитьВопросToolStripMenuItem;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label qstnNumLabel;
        private System.Windows.Forms.ToolStripMenuItem установитьТаймерToolStripMenuItem;
        private System.Windows.Forms.Panel timerSetPanel;
        private System.Windows.Forms.TextBox timerTB;
        private System.Windows.Forms.Button setTimerBtn;
    }
}

