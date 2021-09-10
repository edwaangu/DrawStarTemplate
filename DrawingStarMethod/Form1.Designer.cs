namespace DrawingStarMethod
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.drawButton = new System.Windows.Forms.Button();
            this.xLabel = new System.Windows.Forms.Label();
            this.yLabel = new System.Windows.Forms.Label();
            this.sizeLabel = new System.Windows.Forms.Label();
            this.xInput = new System.Windows.Forms.TextBox();
            this.yInput = new System.Windows.Forms.TextBox();
            this.sizeInput = new System.Windows.Forms.TextBox();
            this.fillButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // drawButton
            // 
            this.drawButton.Location = new System.Drawing.Point(331, 74);
            this.drawButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.drawButton.Name = "drawButton";
            this.drawButton.Size = new System.Drawing.Size(57, 25);
            this.drawButton.TabIndex = 0;
            this.drawButton.Text = "Draw";
            this.drawButton.UseVisualStyleBackColor = true;
            this.drawButton.Click += new System.EventHandler(this.drawButton_Click);
            // 
            // xLabel
            // 
            this.xLabel.AutoSize = true;
            this.xLabel.Location = new System.Drawing.Point(314, 13);
            this.xLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.xLabel.Name = "xLabel";
            this.xLabel.Size = new System.Drawing.Size(14, 13);
            this.xLabel.TabIndex = 1;
            this.xLabel.Text = "X";
            // 
            // yLabel
            // 
            this.yLabel.AutoSize = true;
            this.yLabel.Location = new System.Drawing.Point(314, 35);
            this.yLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.yLabel.Name = "yLabel";
            this.yLabel.Size = new System.Drawing.Size(14, 13);
            this.yLabel.TabIndex = 2;
            this.yLabel.Text = "Y";
            // 
            // sizeLabel
            // 
            this.sizeLabel.AutoSize = true;
            this.sizeLabel.Location = new System.Drawing.Point(235, 56);
            this.sizeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.sizeLabel.Name = "sizeLabel";
            this.sizeLabel.Size = new System.Drawing.Size(92, 13);
            this.sizeLabel.TabIndex = 3;
            this.sizeLabel.Text = "Size (pixel square)";
            // 
            // xInput
            // 
            this.xInput.Location = new System.Drawing.Point(331, 11);
            this.xInput.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.xInput.Name = "xInput";
            this.xInput.Size = new System.Drawing.Size(58, 20);
            this.xInput.TabIndex = 4;
            // 
            // yInput
            // 
            this.yInput.Location = new System.Drawing.Point(331, 32);
            this.yInput.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.yInput.Name = "yInput";
            this.yInput.Size = new System.Drawing.Size(58, 20);
            this.yInput.TabIndex = 5;
            // 
            // sizeInput
            // 
            this.sizeInput.Location = new System.Drawing.Point(331, 53);
            this.sizeInput.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.sizeInput.Name = "sizeInput";
            this.sizeInput.Size = new System.Drawing.Size(58, 20);
            this.sizeInput.TabIndex = 6;
            // 
            // fillButton
            // 
            this.fillButton.Location = new System.Drawing.Point(331, 103);
            this.fillButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.fillButton.Name = "fillButton";
            this.fillButton.Size = new System.Drawing.Size(57, 25);
            this.fillButton.TabIndex = 7;
            this.fillButton.Text = "Fill";
            this.fillButton.UseVisualStyleBackColor = true;
            this.fillButton.Click += new System.EventHandler(this.fillButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.DarkKhaki;
            this.ClientSize = new System.Drawing.Size(400, 400);
            this.Controls.Add(this.fillButton);
            this.Controls.Add(this.sizeInput);
            this.Controls.Add(this.yInput);
            this.Controls.Add(this.xInput);
            this.Controls.Add(this.sizeLabel);
            this.Controls.Add(this.yLabel);
            this.Controls.Add(this.xLabel);
            this.Controls.Add(this.drawButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DrawStar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button drawButton;
        private System.Windows.Forms.Label xLabel;
        private System.Windows.Forms.Label yLabel;
        private System.Windows.Forms.Label sizeLabel;
        private System.Windows.Forms.TextBox xInput;
        private System.Windows.Forms.TextBox yInput;
        private System.Windows.Forms.TextBox sizeInput;
        private System.Windows.Forms.Button fillButton;
    }
}

