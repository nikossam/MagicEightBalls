namespace MagicEightBalls
{
    partial class magicEightBall
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(magicEightBall));
            this.answerLabel = new System.Windows.Forms.Label();
            this.tellMeButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // answerLabel
            // 
            this.answerLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.answerLabel.Location = new System.Drawing.Point(378, 206);
            this.answerLabel.Name = "answerLabel";
            this.answerLabel.Size = new System.Drawing.Size(130, 40);
            this.answerLabel.TabIndex = 0;
            this.answerLabel.Text = "Magic Eight Ball";
            this.answerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tellMeButton
            // 
            this.tellMeButton.BackColor = System.Drawing.Color.Black;
            this.tellMeButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tellMeButton.ForeColor = System.Drawing.Color.Red;
            this.tellMeButton.Location = new System.Drawing.Point(2, 503);
            this.tellMeButton.Name = "tellMeButton";
            this.tellMeButton.Size = new System.Drawing.Size(247, 51);
            this.tellMeButton.TabIndex = 1;
            this.tellMeButton.Text = "Tell me!";
            this.tellMeButton.UseVisualStyleBackColor = false;
            this.tellMeButton.Click += new System.EventHandler(this.tellMeButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(2, 462);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(247, 35);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "Ask your Question...";
            // 
            // magicEightBall
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(892, 566);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.tellMeButton);
            this.Controls.Add(this.answerLabel);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "magicEightBall";
            this.Text = "Magic Eight Ball";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label answerLabel;
        private Button tellMeButton;
        private TextBox textBox1;
    }
}