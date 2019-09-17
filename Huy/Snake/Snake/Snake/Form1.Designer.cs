namespace SnakeProject
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelScore = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelSpeed = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelLength = new System.Windows.Forms.ToolStripStatusLabel();
            this.newgame = new System.Windows.Forms.Label();
            this.High = new System.Windows.Forms.Label();
            this.Exit_btn = new System.Windows.Forms.Label();
            this.level1 = new System.Windows.Forms.Label();
            this.level2 = new System.Windows.Forms.Label();
            this.btn_About = new System.Windows.Forms.Label();
            this.lbSnake = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.statusStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 150;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.DarkGray;
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabelScore,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabelSpeed,
            this.toolStripStatusLabel3,
            this.toolStripStatusLabelLength});
            this.statusStrip1.Location = new System.Drawing.Point(0, 582);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 14, 0);
            this.statusStrip1.Size = new System.Drawing.Size(602, 37);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(79, 32);
            this.toolStripStatusLabel1.Text = "Score:";
            // 
            // toolStripStatusLabelScore
            // 
            this.toolStripStatusLabelScore.Name = "toolStripStatusLabelScore";
            this.toolStripStatusLabelScore.Size = new System.Drawing.Size(28, 32);
            this.toolStripStatusLabelScore.Text = "0";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(87, 32);
            this.toolStripStatusLabel2.Text = "Speed:";
            // 
            // toolStripStatusLabelSpeed
            // 
            this.toolStripStatusLabelSpeed.Name = "toolStripStatusLabelSpeed";
            this.toolStripStatusLabelSpeed.Size = new System.Drawing.Size(28, 32);
            this.toolStripStatusLabelSpeed.Text = "0";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(94, 32);
            this.toolStripStatusLabel3.Text = "Length:";
            // 
            // toolStripStatusLabelLength
            // 
            this.toolStripStatusLabelLength.Name = "toolStripStatusLabelLength";
            this.toolStripStatusLabelLength.Size = new System.Drawing.Size(28, 32);
            this.toolStripStatusLabelLength.Text = "0";
            // 
            // newgame
            // 
            this.newgame.AutoSize = true;
            this.newgame.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.newgame.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.newgame.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newgame.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.newgame.Location = new System.Drawing.Point(204, 206);
            this.newgame.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.newgame.Name = "newgame";
            this.newgame.Size = new System.Drawing.Size(198, 49);
            this.newgame.TabIndex = 1;
            this.newgame.Text = "NEW GAME";
            this.newgame.Click += new System.EventHandler(this.newgame_Click);
            // 
            // High
            // 
            this.High.AutoSize = true;
            this.High.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.High.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.High.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.High.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.High.Location = new System.Drawing.Point(204, 274);
            this.High.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.High.Name = "High";
            this.High.Size = new System.Drawing.Size(242, 49);
            this.High.TabIndex = 2;
            this.High.Text = "HIGH SCORE";
            this.High.Click += new System.EventHandler(this.High_Click);
            // 
            // Exit_btn
            // 
            this.Exit_btn.AutoSize = true;
            this.Exit_btn.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.Exit_btn.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Exit_btn.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit_btn.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Exit_btn.Location = new System.Drawing.Point(204, 408);
            this.Exit_btn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Exit_btn.Name = "Exit_btn";
            this.Exit_btn.Size = new System.Drawing.Size(110, 49);
            this.Exit_btn.TabIndex = 3;
            this.Exit_btn.Text = "Exit";
            this.Exit_btn.Click += new System.EventHandler(this.Exit_btn_Click);
            // 
            // level1
            // 
            this.level1.AutoSize = true;
            this.level1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.level1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.level1.Cursor = System.Windows.Forms.Cursors.Default;
            this.level1.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.level1.Location = new System.Drawing.Point(204, 225);
            this.level1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.level1.Name = "level1";
            this.level1.Size = new System.Drawing.Size(110, 49);
            this.level1.TabIndex = 4;
            this.level1.Text = "HARD";
            this.level1.Click += new System.EventHandler(this.level1_Click);
            // 
            // level2
            // 
            this.level2.AutoSize = true;
            this.level2.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.level2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.level2.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.level2.Location = new System.Drawing.Point(204, 310);
            this.level2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.level2.Name = "level2";
            this.level2.Size = new System.Drawing.Size(154, 49);
            this.level2.TabIndex = 5;
            this.level2.Text = "HARDER";
            this.level2.Click += new System.EventHandler(this.level2_Click);
            // 
            // btn_About
            // 
            this.btn_About.AutoSize = true;
            this.btn_About.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.btn_About.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.btn_About.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_About.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_About.Location = new System.Drawing.Point(204, 343);
            this.btn_About.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.btn_About.Name = "btn_About";
            this.btn_About.Size = new System.Drawing.Size(132, 49);
            this.btn_About.TabIndex = 6;
            this.btn_About.Text = "About";
            this.btn_About.Click += new System.EventHandler(this.btn_About_Click);
            // 
            // lbSnake
            // 
            this.lbSnake.BackColor = System.Drawing.Color.Transparent;
            this.lbSnake.Font = new System.Drawing.Font("Gabriola", 45F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSnake.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.lbSnake.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbSnake.Location = new System.Drawing.Point(6, -18);
            this.lbSnake.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbSnake.Name = "lbSnake";
            this.lbSnake.Size = new System.Drawing.Size(440, 199);
            this.lbSnake.TabIndex = 7;
            this.lbSnake.Text = "Snake";
            // 
            // panel1
            // 
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.lbSnake);
            this.panel1.Controls.Add(this.btn_About);
            this.panel1.Controls.Add(this.level2);
            this.panel1.Controls.Add(this.newgame);
            this.panel1.Controls.Add(this.level1);
            this.panel1.Controls.Add(this.High);
            this.panel1.Controls.Add(this.Exit_btn);
            this.panel1.Location = new System.Drawing.Point(0, -6);
            this.panel1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(602, 582);
            this.panel1.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(602, 619);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Snake";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelScore;
        private System.Windows.Forms.Label newgame;
        private System.Windows.Forms.Label High;
        private System.Windows.Forms.Label Exit_btn;
        private System.Windows.Forms.Label level1;
        private System.Windows.Forms.Label level2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelSpeed;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelLength;
        private System.Windows.Forms.Label btn_About;
        private System.Windows.Forms.Label lbSnake;
        private System.Windows.Forms.Panel panel1;
    }
}

