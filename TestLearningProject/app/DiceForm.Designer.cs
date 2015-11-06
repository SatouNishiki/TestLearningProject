namespace TestLearningProject.app
{
    partial class DiceForm
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
            this.drawPictureBox = new System.Windows.Forms.PictureBox();
            this.diceButton = new System.Windows.Forms.Button();
            this.diceFallTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.drawPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // drawPictureBox
            // 
            this.drawPictureBox.BackColor = System.Drawing.Color.LightCyan;
            this.drawPictureBox.Location = new System.Drawing.Point(12, 12);
            this.drawPictureBox.Name = "drawPictureBox";
            this.drawPictureBox.Size = new System.Drawing.Size(306, 274);
            this.drawPictureBox.TabIndex = 0;
            this.drawPictureBox.TabStop = false;
            // 
            // diceButton
            // 
            this.diceButton.Location = new System.Drawing.Point(324, 263);
            this.diceButton.Name = "diceButton";
            this.diceButton.Size = new System.Drawing.Size(75, 23);
            this.diceButton.TabIndex = 1;
            this.diceButton.Text = "射出";
            this.diceButton.UseVisualStyleBackColor = true;
            this.diceButton.Click += new System.EventHandler(this.diceButton_Click);
            // 
            // diceFallTimer
            // 
            this.diceFallTimer.Enabled = true;
            this.diceFallTimer.Tick += new System.EventHandler(this.diceFallTimer_Tick);
            // 
            // DiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 302);
            this.Controls.Add(this.diceButton);
            this.Controls.Add(this.drawPictureBox);
            this.Name = "DiceForm";
            this.Text = "ダイスを出すよ";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DiceForm_FormClosed);
            this.Load += new System.EventHandler(this.DiceForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.drawPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox drawPictureBox;
        private System.Windows.Forms.Button diceButton;
        private System.Windows.Forms.Timer diceFallTimer;
    }
}