
namespace GameJump
{
    partial class MainGame
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnBall = new System.Windows.Forms.Button();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.lblTime = new System.Windows.Forms.Label();
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btnPlayer
            // 
            this.btnPlayer.Location = new System.Drawing.Point(243, 285);
            this.btnPlayer.Name = "btnPlayer";
            this.btnPlayer.Size = new System.Drawing.Size(150, 21);
            this.btnPlayer.TabIndex = 0;
            this.btnPlayer.UseVisualStyleBackColor = true;
            this.btnPlayer.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnPlayer_KeyDown);
            this.btnPlayer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btnPlayer_KeyPress);
            this.btnPlayer.KeyUp += new System.Windows.Forms.KeyEventHandler(this.btnPlayer_KeyUp);
            this.btnPlayer.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnPlayer_MouseDown);
            this.btnPlayer.MouseHover += new System.EventHandler(this.btnPlayer_MouseHover);
            this.btnPlayer.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnPlayer_MouseUp);
            // 
            // btnBall
            // 
            this.btnBall.Location = new System.Drawing.Point(314, 74);
            this.btnBall.Name = "btnBall";
            this.btnBall.Size = new System.Drawing.Size(20, 19);
            this.btnBall.TabIndex = 1;
            this.btnBall.UseVisualStyleBackColor = true;
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(32, 24);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(35, 13);
            this.lblTime.TabIndex = 2;
            this.lblTime.Text = "label1";
            // 
            // timer3
            // 
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // MainGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 318);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.btnBall);
            this.Controls.Add(this.btnPlayer);
            this.Name = "MainGame";
            this.Text = "MainGame";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPlayer;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnBall;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Timer timer3;
    }
}