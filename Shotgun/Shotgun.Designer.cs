namespace Shotgun
{
    partial class Shotgun
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
            imgLeftMoveCase = new PictureBox();
            imgRightMoveCase = new PictureBox();
            btnMoveCase1 = new Button();
            btnMoveCase2 = new Button();
            btnMoveCase3 = new Button();
            lblPlayer1_Name = new Label();
            lblPlayer2_Name = new Label();
            lblPlayer1_Bullets = new Label();
            lblPlayer2_Bullets = new Label();
            ((System.ComponentModel.ISupportInitialize)imgLeftMoveCase).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imgRightMoveCase).BeginInit();
            SuspendLayout();
            // 
            // imgLeftMoveCase
            // 
            imgLeftMoveCase.Location = new Point(12, 12);
            imgLeftMoveCase.Name = "imgLeftMoveCase";
            imgLeftMoveCase.Size = new Size(350, 350);
            imgLeftMoveCase.TabIndex = 0;
            imgLeftMoveCase.TabStop = false;
            // 
            // imgRightMoveCase
            // 
            imgRightMoveCase.Location = new Point(368, 12);
            imgRightMoveCase.Name = "imgRightMoveCase";
            imgRightMoveCase.Size = new Size(350, 350);
            imgRightMoveCase.TabIndex = 1;
            imgRightMoveCase.TabStop = false;
            // 
            // btnMoveCase1
            // 
            btnMoveCase1.Location = new Point(12, 368);
            btnMoveCase1.Name = "btnMoveCase1";
            btnMoveCase1.Size = new Size(112, 70);
            btnMoveCase1.TabIndex = 2;
            btnMoveCase1.Text = "Block";
            btnMoveCase1.UseVisualStyleBackColor = true;
            btnMoveCase1.Click += btnMoveCase1_Click;
            // 
            // btnMoveCase2
            // 
            btnMoveCase2.Location = new Point(132, 368);
            btnMoveCase2.Name = "btnMoveCase2";
            btnMoveCase2.Size = new Size(112, 70);
            btnMoveCase2.TabIndex = 3;
            btnMoveCase2.Text = "Reload";
            btnMoveCase2.UseVisualStyleBackColor = true;
            btnMoveCase2.Click += btnMoveCase2_Click;
            // 
            // btnMoveCase3
            // 
            btnMoveCase3.Location = new Point(250, 368);
            btnMoveCase3.Name = "btnMoveCase3";
            btnMoveCase3.Size = new Size(112, 70);
            btnMoveCase3.TabIndex = 4;
            btnMoveCase3.Text = "Shoot";
            btnMoveCase3.UseVisualStyleBackColor = true;
            btnMoveCase3.Click += btnMoveCase3_Click;
            // 
            // lblPlayer1_Name
            // 
            lblPlayer1_Name.AutoSize = true;
            lblPlayer1_Name.BackColor = Color.Transparent;
            lblPlayer1_Name.Font = new Font("Impact", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPlayer1_Name.Location = new Point(12, 12);
            lblPlayer1_Name.Name = "lblPlayer1_Name";
            lblPlayer1_Name.Size = new Size(0, 35);
            lblPlayer1_Name.TabIndex = 5;
            // 
            // lblPlayer2_Name
            // 
            lblPlayer2_Name.AutoSize = true;
            lblPlayer2_Name.BackColor = Color.Transparent;
            lblPlayer2_Name.Font = new Font("Impact", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPlayer2_Name.Location = new Point(368, 12);
            lblPlayer2_Name.Name = "lblPlayer2_Name";
            lblPlayer2_Name.Size = new Size(0, 35);
            lblPlayer2_Name.TabIndex = 6;
            // 
            // lblPlayer1_Bullets
            // 
            lblPlayer1_Bullets.AutoSize = true;
            lblPlayer1_Bullets.BackColor = Color.Transparent;
            lblPlayer1_Bullets.Font = new Font("Impact", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPlayer1_Bullets.Location = new Point(12, 327);
            lblPlayer1_Bullets.Name = "lblPlayer1_Bullets";
            lblPlayer1_Bullets.Size = new Size(0, 35);
            lblPlayer1_Bullets.TabIndex = 7;
            // 
            // lblPlayer2_Bullets
            // 
            lblPlayer2_Bullets.AutoSize = true;
            lblPlayer2_Bullets.BackColor = Color.Transparent;
            lblPlayer2_Bullets.Font = new Font("Impact", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPlayer2_Bullets.Location = new Point(368, 327);
            lblPlayer2_Bullets.Name = "lblPlayer2_Bullets";
            lblPlayer2_Bullets.Size = new Size(0, 35);
            lblPlayer2_Bullets.TabIndex = 8;
            // 
            // Shotgun
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(728, 450);
            Controls.Add(lblPlayer2_Bullets);
            Controls.Add(lblPlayer1_Bullets);
            Controls.Add(lblPlayer2_Name);
            Controls.Add(lblPlayer1_Name);
            Controls.Add(btnMoveCase3);
            Controls.Add(btnMoveCase2);
            Controls.Add(btnMoveCase1);
            Controls.Add(imgRightMoveCase);
            Controls.Add(imgLeftMoveCase);
            MaximizeBox = false;
            Name = "Shotgun";
            Text = "Shotgun";
            ((System.ComponentModel.ISupportInitialize)imgLeftMoveCase).EndInit();
            ((System.ComponentModel.ISupportInitialize)imgRightMoveCase).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox imgLeftMoveCase;
        private PictureBox imgRightMoveCase;
        private Button btnMoveCase1;
        private Button btnMoveCase2;
        private Button btnMoveCase3;
        private Label lblPlayer1_Name;
        private Label lblPlayer2_Name;
        private Label lblPlayer1_Bullets;
        private Label lblPlayer2_Bullets;
    }
}
