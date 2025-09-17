namespace inClassProject1
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
            this.helloLabel = new System.Windows.Forms.Label();
            this.goodByeLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // helloLabel
            // 
            this.helloLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.helloLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helloLabel.Location = new System.Drawing.Point(168, 177);
            this.helloLabel.Name = "helloLabel";
            this.helloLabel.Size = new System.Drawing.Size(100, 38);
            this.helloLabel.TabIndex = 0;
            this.helloLabel.Text = "Hello";
            this.helloLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.helloLabel.MouseHover += new System.EventHandler(this.helloLabel_MouseHover);
            // 
            // goodByeLabel
            // 
            this.goodByeLabel.AutoSize = true;
            this.goodByeLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.goodByeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goodByeLabel.Location = new System.Drawing.Point(366, 177);
            this.goodByeLabel.Name = "goodByeLabel";
            this.goodByeLabel.Size = new System.Drawing.Size(139, 38);
            this.goodByeLabel.TabIndex = 1;
            this.goodByeLabel.Text = "Goodbye";
            this.goodByeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.goodByeLabel.MouseHover += new System.EventHandler(this.goodByeLabel_MouseHover);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 554);
            this.Controls.Add(this.goodByeLabel);
            this.Controls.Add(this.helloLabel);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label helloLabel;
        private System.Windows.Forms.Label goodByeLabel;
    }
}

