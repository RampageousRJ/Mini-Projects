namespace TicTacToe
{
    partial class Landing
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
            this.Welcome = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.play = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Welcome
            // 
            this.Welcome.AutoSize = true;
            this.Welcome.BackColor = System.Drawing.Color.Transparent;
            this.Welcome.Font = new System.Drawing.Font("Monocraft", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Welcome.ForeColor = System.Drawing.Color.Red;
            this.Welcome.Location = new System.Drawing.Point(104, 70);
            this.Welcome.Name = "Welcome";
            this.Welcome.Size = new System.Drawing.Size(216, 44);
            this.Welcome.TabIndex = 42;
            this.Welcome.Text = "Welcome";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Monocraft", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(41, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(350, 48);
            this.label1.TabIndex = 43;
            this.label1.Text = "Tic-Tac-Toe";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Monocraft", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(183, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 33);
            this.label2.TabIndex = 44;
            this.label2.Text = "to";
            // 
            // play
            // 
            this.play.BackColor = System.Drawing.Color.Ivory;
            this.play.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.play.Font = new System.Drawing.Font("Monocraft", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.play.ForeColor = System.Drawing.Color.Black;
            this.play.Location = new System.Drawing.Point(140, 262);
            this.play.Name = "play";
            this.play.Size = new System.Drawing.Size(150, 50);
            this.play.TabIndex = 45;
            this.play.Text = "PLAY";
            this.play.UseVisualStyleBackColor = false;
            this.play.Click += new System.EventHandler(this.play_Click);
            // 
            // Landing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TicTacToe.Properties.Resources.background1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(432, 396);
            this.Controls.Add(this.play);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Welcome);
            this.Name = "Landing";
            this.Text = "Landing";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Welcome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button play;



    }
}

