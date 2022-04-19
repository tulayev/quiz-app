namespace QuizAppUI
{
    partial class AddQuestions
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
            this.questionTB = new System.Windows.Forms.TextBox();
            this.optATB = new System.Windows.Forms.TextBox();
            this.optBTB = new System.Windows.Forms.TextBox();
            this.optCTB = new System.Windows.Forms.TextBox();
            this.optDTB = new System.Windows.Forms.TextBox();
            this.closeBtn = new System.Windows.Forms.Button();
            this.errorsLabel = new System.Windows.Forms.Label();
            this.questionLabel = new System.Windows.Forms.Label();
            this.optALabel = new System.Windows.Forms.Label();
            this.optBLabel = new System.Windows.Forms.Label();
            this.optCLabel = new System.Windows.Forms.Label();
            this.optDLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.okBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // questionTB
            // 
            this.questionTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.questionTB.Location = new System.Drawing.Point(122, 55);
            this.questionTB.Multiline = true;
            this.questionTB.Name = "questionTB";
            this.questionTB.Size = new System.Drawing.Size(764, 86);
            this.questionTB.TabIndex = 0;
            // 
            // optATB
            // 
            this.optATB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.optATB.Location = new System.Drawing.Point(122, 160);
            this.optATB.Name = "optATB";
            this.optATB.Size = new System.Drawing.Size(764, 29);
            this.optATB.TabIndex = 1;
            // 
            // optBTB
            // 
            this.optBTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.optBTB.Location = new System.Drawing.Point(122, 208);
            this.optBTB.Name = "optBTB";
            this.optBTB.Size = new System.Drawing.Size(764, 29);
            this.optBTB.TabIndex = 2;
            // 
            // optCTB
            // 
            this.optCTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.optCTB.Location = new System.Drawing.Point(122, 257);
            this.optCTB.Name = "optCTB";
            this.optCTB.Size = new System.Drawing.Size(764, 29);
            this.optCTB.TabIndex = 3;
            // 
            // optDTB
            // 
            this.optDTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.optDTB.Location = new System.Drawing.Point(122, 311);
            this.optDTB.Name = "optDTB";
            this.optDTB.Size = new System.Drawing.Size(764, 29);
            this.optDTB.TabIndex = 4;
            // 
            // closeBtn
            // 
            this.closeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.closeBtn.Location = new System.Drawing.Point(648, 416);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(116, 41);
            this.closeBtn.TabIndex = 7;
            this.closeBtn.Text = "Закрыть";
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // errorsLabel
            // 
            this.errorsLabel.AutoSize = true;
            this.errorsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.errorsLabel.ForeColor = System.Drawing.Color.Red;
            this.errorsLabel.Location = new System.Drawing.Point(8, 423);
            this.errorsLabel.Name = "errorsLabel";
            this.errorsLabel.Size = new System.Drawing.Size(0, 24);
            this.errorsLabel.TabIndex = 8;
            // 
            // questionLabel
            // 
            this.questionLabel.AutoSize = true;
            this.questionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.questionLabel.Location = new System.Drawing.Point(8, 86);
            this.questionLabel.Name = "questionLabel";
            this.questionLabel.Size = new System.Drawing.Size(81, 24);
            this.questionLabel.TabIndex = 11;
            this.questionLabel.Text = "Вопрос:";
            // 
            // optALabel
            // 
            this.optALabel.AutoSize = true;
            this.optALabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.optALabel.Location = new System.Drawing.Point(8, 163);
            this.optALabel.Name = "optALabel";
            this.optALabel.Size = new System.Drawing.Size(108, 24);
            this.optALabel.TabIndex = 12;
            this.optALabel.Text = "Вариант A:";
            // 
            // optBLabel
            // 
            this.optBLabel.AutoSize = true;
            this.optBLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.optBLabel.Location = new System.Drawing.Point(8, 211);
            this.optBLabel.Name = "optBLabel";
            this.optBLabel.Size = new System.Drawing.Size(107, 24);
            this.optBLabel.TabIndex = 13;
            this.optBLabel.Text = "Вариант B:";
            // 
            // optCLabel
            // 
            this.optCLabel.AutoSize = true;
            this.optCLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.optCLabel.Location = new System.Drawing.Point(8, 262);
            this.optCLabel.Name = "optCLabel";
            this.optCLabel.Size = new System.Drawing.Size(108, 24);
            this.optCLabel.TabIndex = 14;
            this.optCLabel.Text = "Вариант C:";
            // 
            // optDLabel
            // 
            this.optDLabel.AutoSize = true;
            this.optDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.optDLabel.Location = new System.Drawing.Point(8, 314);
            this.optDLabel.Name = "optDLabel";
            this.optDLabel.Size = new System.Drawing.Size(108, 24);
            this.optDLabel.TabIndex = 15;
            this.optDLabel.Text = "Вариант D:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 514);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(955, 26);
            this.panel2.TabIndex = 17;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(955, 26);
            this.panel3.TabIndex = 18;
            // 
            // okBtn
            // 
            this.okBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.okBtn.Location = new System.Drawing.Point(770, 416);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(116, 41);
            this.okBtn.TabIndex = 19;
            this.okBtn.Text = "Ok";
            this.okBtn.UseVisualStyleBackColor = true;
            this.okBtn.Click += new System.EventHandler(this.okBtn_Click);
            // 
            // AddQuestions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 540);
            this.Controls.Add(this.okBtn);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.errorsLabel);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.optDTB);
            this.Controls.Add(this.optCTB);
            this.Controls.Add(this.optBTB);
            this.Controls.Add(this.optATB);
            this.Controls.Add(this.questionTB);
            this.Controls.Add(this.questionLabel);
            this.Controls.Add(this.optALabel);
            this.Controls.Add(this.optBLabel);
            this.Controls.Add(this.optCLabel);
            this.Controls.Add(this.optDLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddQuestions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddQuestions";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox questionTB;
        private System.Windows.Forms.TextBox optATB;
        private System.Windows.Forms.TextBox optBTB;
        private System.Windows.Forms.TextBox optCTB;
        private System.Windows.Forms.TextBox optDTB;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Label errorsLabel;
        private System.Windows.Forms.Label questionLabel;
        private System.Windows.Forms.Label optALabel;
        private System.Windows.Forms.Label optBLabel;
        private System.Windows.Forms.Label optCLabel;
        private System.Windows.Forms.Label optDLabel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button okBtn;
    }
}