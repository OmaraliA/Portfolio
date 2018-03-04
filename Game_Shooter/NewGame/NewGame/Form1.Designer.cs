namespace NewGame
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.level_tb = new System.Windows.Forms.TextBox();
            this.hits_tb = new System.Windows.Forms.TextBox();
            this.score_tb = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.textBox_Hits = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox_Score = new System.Windows.Forms.TextBox();
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.label9 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 2;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 5000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(403, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pause";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            this.label1.MouseEnter += new System.EventHandler(this.label2_MouseEnter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Bookman Old Style", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label2.Location = new System.Drawing.Point(410, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Quit";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            this.label2.MouseEnter += new System.EventHandler(this.label2_MouseEnter);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Bookman Old Style", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(395, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Resume";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            this.label4.MouseEnter += new System.EventHandler(this.label2_MouseEnter);
            // 
            // level_tb
            // 
            this.level_tb.Enabled = false;
            this.level_tb.Location = new System.Drawing.Point(166, 60);
            this.level_tb.Name = "level_tb";
            this.level_tb.ReadOnly = true;
            this.level_tb.Size = new System.Drawing.Size(31, 20);
            this.level_tb.TabIndex = 5;
            // 
            // hits_tb
            // 
            this.hits_tb.Enabled = false;
            this.hits_tb.Location = new System.Drawing.Point(166, 90);
            this.hits_tb.Name = "hits_tb";
            this.hits_tb.ReadOnly = true;
            this.hits_tb.Size = new System.Drawing.Size(31, 20);
            this.hits_tb.TabIndex = 6;
            // 
            // score_tb
            // 
            this.score_tb.Enabled = false;
            this.score_tb.Location = new System.Drawing.Point(166, 123);
            this.score_tb.Name = "score_tb";
            this.score_tb.ReadOnly = true;
            this.score_tb.Size = new System.Drawing.Size(31, 20);
            this.score_tb.TabIndex = 7;
            this.score_tb.Text = "0";
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Red;
            this.label6.Font = new System.Drawing.Font("Bookman Old Style", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.ForestGreen;
            this.label6.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label6.Location = new System.Drawing.Point(307, 187);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(310, 53);
            this.label6.TabIndex = 8;
            this.label6.Text = "Game Over!";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(340, -50);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 200);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseEnter += new System.EventHandler(this.pictureBox1_MouseEnter);
            this.pictureBox1.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Bookman Old Style", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(384, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 24);
            this.label3.TabIndex = 10;
            this.label3.Text = "Restart";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.Click += new System.EventHandler(this.label3_Click_1);
            this.label3.MouseEnter += new System.EventHandler(this.pictureBox1_MouseEnter);
            this.label3.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            // 
            // label7
            // 
            this.label7.AutoEllipsis = true;
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Bookman Old Style", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(395, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 24);
            this.label7.TabIndex = 11;
            this.label7.Text = "Start";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label7.Click += new System.EventHandler(this.label7_Click);
            this.label7.MouseEnter += new System.EventHandler(this.pictureBox1_MouseEnter);
            this.label7.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            // 
            // label5
            // 
            this.label5.AutoEllipsis = true;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Bookman Old Style", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(584, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 24);
            this.label5.TabIndex = 12;
            this.label5.Text = "Options";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox_Hits
            // 
            this.textBox_Hits.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_Hits.Location = new System.Drawing.Point(353, 292);
            this.textBox_Hits.Margin = new System.Windows.Forms.Padding(4, 3, 3, 3);
            this.textBox_Hits.Name = "textBox_Hits";
            this.textBox_Hits.Size = new System.Drawing.Size(189, 26);
            this.textBox_Hits.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Aqua;
            this.label8.Font = new System.Drawing.Font("Bookman Old Style", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label8.Location = new System.Drawing.Point(340, 253);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(218, 36);
            this.label8.TabIndex = 14;
            this.label8.Text = "Your Result";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textBox_Score
            // 
            this.textBox_Score.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_Score.Location = new System.Drawing.Point(353, 324);
            this.textBox_Score.Margin = new System.Windows.Forms.Padding(4, 3, 3, 3);
            this.textBox_Score.Name = "textBox_Score";
            this.textBox_Score.Size = new System.Drawing.Size(189, 26);
            this.textBox_Score.TabIndex = 15;
            // 
            // timer3
            // 
            this.timer3.Enabled = true;
            this.timer3.Interval = 1;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Aqua;
            this.label9.Font = new System.Drawing.Font("Bookman Old Style", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label9.Location = new System.Drawing.Point(334, 353);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(218, 36);
            this.label9.TabIndex = 16;
            this.label9.Text = "Your name";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(351, 392);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 3, 3, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(189, 26);
            this.textBox1.TabIndex = 17;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(353, 424);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(187, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "Show ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 545);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBox_Score);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox_Hits);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.score_tb);
            this.Controls.Add(this.hits_tb);
            this.Controls.Add(this.level_tb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Shooter";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick_1);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox level_tb;
        private System.Windows.Forms.TextBox hits_tb;
        private System.Windows.Forms.TextBox score_tb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.TextBox textBox_Hits;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox_Score;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
    }
}

