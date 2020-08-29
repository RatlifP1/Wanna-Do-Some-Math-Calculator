namespace LAB3DMathApp_RatliffPaul07292020
{
    partial class CloseingMessage
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cexit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "YOU DIDN\'T FOLLOW INSTRUCTIONS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(74, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Thanks for stopping by!";
            // 
            // cexit
            // 
            this.cexit.Location = new System.Drawing.Point(77, 212);
            this.cexit.Name = "cexit";
            this.cexit.Size = new System.Drawing.Size(61, 23);
            this.cexit.TabIndex = 3;
            this.cexit.Text = "EXIT";
            this.cexit.UseVisualStyleBackColor = true;
            this.cexit.Click += new System.EventHandler(this.cexit_Click);
            // 
            // CloseingMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(250, 319);
            this.Controls.Add(this.cexit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CloseingMessage";
            this.Text = "CloseingMessage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button cexit;
    }
}