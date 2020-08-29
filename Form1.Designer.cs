namespace LAB3DMathApp_RatliffPaul07292020
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.expressionName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.mathB1 = new System.Windows.Forms.TextBox();
            this.mathB2 = new System.Windows.Forms.TextBox();
            this.calculate = new System.Windows.Forms.Button();
            this.exitB = new System.Windows.Forms.Button();
            this.result = new System.Windows.Forms.TextBox();
            this.expEntry = new System.Windows.Forms.TextBox();
            this.formula = new System.Windows.Forms.TextBox();
            this.correct = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Gold;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(101, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(591, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "WANNA DO SOME MATH";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Gold;
            this.label2.Location = new System.Drawing.Point(218, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "ADD A MATHMATICAL EXPRESSION";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Gold;
            this.label3.Location = new System.Drawing.Point(218, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(302, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "ENTER: ADD, SUBTRACT, DIVIDE, OR MULTIPLY IN CAPS";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Gold;
            this.label4.Location = new System.Drawing.Point(218, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(376, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "IF YOU ADDED AN EXPRESSION YOU CAN NOW INPUT TWO NUMBERS";
            // 
            // expressionName
            // 
            this.expressionName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.expressionName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expressionName.Location = new System.Drawing.Point(239, 167);
            this.expressionName.Name = "expressionName";
            this.expressionName.Size = new System.Drawing.Size(111, 26);
            this.expressionName.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Gold;
            this.label5.Location = new System.Drawing.Point(218, 231);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(329, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "FAILING TO WRITE IN THE EXPRESSION WILL END PROGRAM";
            // 
            // mathB1
            // 
            this.mathB1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.mathB1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mathB1.Location = new System.Drawing.Point(370, 337);
            this.mathB1.Name = "mathB1";
            this.mathB1.Size = new System.Drawing.Size(67, 26);
            this.mathB1.TabIndex = 6;
            // 
            // mathB2
            // 
            this.mathB2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.mathB2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mathB2.Location = new System.Drawing.Point(221, 337);
            this.mathB2.Name = "mathB2";
            this.mathB2.Size = new System.Drawing.Size(67, 26);
            this.mathB2.TabIndex = 7;
            // 
            // calculate
            // 
            this.calculate.BackColor = System.Drawing.Color.Lime;
            this.calculate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.calculate.Location = new System.Drawing.Point(351, 409);
            this.calculate.Name = "calculate";
            this.calculate.Size = new System.Drawing.Size(95, 23);
            this.calculate.TabIndex = 8;
            this.calculate.Text = "CALCULATE";
            this.calculate.UseVisualStyleBackColor = false;
            this.calculate.Click += new System.EventHandler(this.calculate_Click);
            // 
            // exitB
            // 
            this.exitB.BackColor = System.Drawing.Color.Red;
            this.exitB.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.exitB.Location = new System.Drawing.Point(415, 167);
            this.exitB.Name = "exitB";
            this.exitB.Size = new System.Drawing.Size(75, 23);
            this.exitB.TabIndex = 9;
            this.exitB.Text = "EXIT";
            this.exitB.UseVisualStyleBackColor = false;
            this.exitB.Click += new System.EventHandler(this.exitB_Click);
            // 
            // result
            // 
            this.result.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.result.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.result.Location = new System.Drawing.Point(175, 496);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(326, 26);
            this.result.TabIndex = 10;
            this.result.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // expEntry
            // 
            this.expEntry.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.expEntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expEntry.Location = new System.Drawing.Point(306, 406);
            this.expEntry.Name = "expEntry";
            this.expEntry.Size = new System.Drawing.Size(21, 26);
            this.expEntry.TabIndex = 11;
            this.expEntry.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // formula
            // 
            this.formula.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.formula.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.formula.Location = new System.Drawing.Point(175, 451);
            this.formula.Name = "formula";
            this.formula.Size = new System.Drawing.Size(326, 26);
            this.formula.TabIndex = 12;
            this.formula.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // correct
            // 
            this.correct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.correct.ForeColor = System.Drawing.SystemColors.WindowText;
            this.correct.Location = new System.Drawing.Point(442, 629);
            this.correct.Name = "correct";
            this.correct.Size = new System.Drawing.Size(320, 20);
            this.correct.TabIndex = 13;
            this.correct.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(194, 301);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "1ST WHOLE NUMBER";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(340, 301);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "2ND WHOLE NUMBER";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(236, 381);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(169, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "YOUR SELECTED EXPRESSION";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(269, 435);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "YOUR FORMULA";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(278, 480);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "YOUR RESULT";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(548, 604);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(106, 13);
            this.label11.TabIndex = 19;
            this.label11.Text = "MESSAGE CENTER";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(800, 661);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.correct);
            this.Controls.Add(this.formula);
            this.Controls.Add(this.expEntry);
            this.Controls.Add(this.result);
            this.Controls.Add(this.exitB);
            this.Controls.Add(this.calculate);
            this.Controls.Add(this.mathB2);
            this.Controls.Add(this.mathB1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.expressionName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox expressionName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox mathB1;
        private System.Windows.Forms.TextBox mathB2;
        private System.Windows.Forms.Button calculate;
        private System.Windows.Forms.Button exitB;
        private System.Windows.Forms.TextBox result;
        private System.Windows.Forms.TextBox expEntry;
        private System.Windows.Forms.TextBox formula;
        private System.Windows.Forms.TextBox correct;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
    }
}

