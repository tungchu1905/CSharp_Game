
namespace PongGame
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
            this.btnPlayer = new System.Windows.Forms.Button();
            this.btnComputer = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnBall = new System.Windows.Forms.Button();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.timer4 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btnPlayer
            // 
            this.btnPlayer.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnPlayer.Location = new System.Drawing.Point(12, 102);
            this.btnPlayer.Name = "btnPlayer";
            this.btnPlayer.Size = new System.Drawing.Size(27, 118);
            this.btnPlayer.TabIndex = 0;
            this.btnPlayer.UseVisualStyleBackColor = false;
            this.btnPlayer.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnPlayer_KeyDown);
            this.btnPlayer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btnPlayer_KeyPress);
            this.btnPlayer.KeyUp += new System.Windows.Forms.KeyEventHandler(this.btnPlayer_KeyUp);
            this.btnPlayer.Move += new System.EventHandler(this.btnPlayer_Move);
            // 
            // btnComputer
            // 
            this.btnComputer.BackColor = System.Drawing.Color.DarkRed;
            this.btnComputer.Location = new System.Drawing.Point(506, 102);
            this.btnComputer.Name = "btnComputer";
            this.btnComputer.Size = new System.Drawing.Size(27, 118);
            this.btnComputer.TabIndex = 1;
            this.btnComputer.UseVisualStyleBackColor = false;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(194, 277);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(150, 64);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnBall
            // 
            this.btnBall.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBall.Location = new System.Drawing.Point(258, 150);
            this.btnBall.Name = "btnBall";
            this.btnBall.Size = new System.Drawing.Size(23, 23);
            this.btnBall.TabIndex = 3;
            this.btnBall.UseVisualStyleBackColor = false;
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(251, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(271, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(10, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = ":";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(288, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 236);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Click Button Here First";
            // 
            // timer4
            // 
            this.timer4.Interval = 1000;
            this.timer4.Tick += new System.EventHandler(this.timer4_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 399);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBall);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnComputer);
            this.Controls.Add(this.btnPlayer);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPlayer;
        private System.Windows.Forms.Button btnComputer;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnBall;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer timer4;
    }
}

