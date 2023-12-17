namespace RandomNumberStatistics
{
    partial class RandStat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RandStat));
            tryInputBox = new TextBox();
            randNumRangedown = new TextBox();
            randNumRangeup = new TextBox();
            label1 = new Label();
            button1 = new Button();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            label4 = new Label();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // tryInputBox
            // 
            tryInputBox.Font = new Font("Calibri", 16F);
            tryInputBox.Location = new Point(50, 50);
            tryInputBox.Name = "tryInputBox";
            tryInputBox.PlaceholderText = "Input try count (1-300)";
            tryInputBox.Size = new Size(274, 34);
            tryInputBox.TabIndex = 0;
            tryInputBox.TextChanged += textBox1_TextChanged;
            // 
            // randNumRangedown
            // 
            randNumRangedown.Font = new Font("Calibri", 16F);
            randNumRangedown.Location = new Point(50, 185);
            randNumRangedown.Name = "randNumRangedown";
            randNumRangedown.PlaceholderText = "Down Range for Random Number";
            randNumRangedown.Size = new Size(329, 34);
            randNumRangedown.TabIndex = 1;
            randNumRangedown.TextChanged += randNumRangeup_TextChanged;
            // 
            // randNumRangeup
            // 
            randNumRangeup.Font = new Font("Calibri", 16F);
            randNumRangeup.Location = new Point(50, 250);
            randNumRangeup.Name = "randNumRangeup";
            randNumRangeup.PlaceholderText = "Up Range for Random Number";
            randNumRangeup.Size = new Size(329, 34);
            randNumRangeup.TabIndex = 0;
            randNumRangeup.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.BackColor = Color.Chartreuse;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("Calibri", 14F);
            label1.Location = new Point(50, 112);
            label1.Name = "label1";
            label1.Padding = new Padding(0, 10, 0, 10);
            label1.Size = new Size(329, 41);
            label1.TabIndex = 2;
            label1.Text = "Enter Random Number Range (0-1000)";
            // 
            // button1
            // 
            button1.Font = new Font("Calibri", 16F);
            button1.Location = new Point(50, 374);
            button1.Name = "button1";
            button1.Size = new Size(317, 44);
            button1.TabIndex = 3;
            button1.Text = "Generate Random Numbers";
            button1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F);
            label2.Location = new Point(-1, 11);
            label2.Name = "label2";
            label2.Padding = new Padding(0, 5, 0, 5);
            label2.Size = new Size(54, 30);
            label2.TabIndex = 4;
            label2.Text = "Empty";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 16F);
            label3.Location = new Point(50, 610);
            label3.Name = "label3";
            label3.Size = new Size(231, 52);
            label3.TabIndex = 5;
            label3.Text = "Real Probability - \r\nEstimated Probability -\r\n";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Calibri", 14F);
            textBox1.Location = new Point(50, 313);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Enter the number you want to know the probability of ";
            textBox1.Size = new Size(473, 30);
            textBox1.TabIndex = 6;
            // 
            // label4
            // 
            label4.BackColor = SystemColors.ActiveCaption;
            label4.BorderStyle = BorderStyle.FixedSingle;
            label4.Font = new Font("Microsoft Sans Serif", 12F);
            label4.Location = new Point(649, 50);
            label4.Name = "label4";
            label4.Padding = new Padding(4);
            label4.Size = new Size(512, 263);
            label4.TabIndex = 7;
            label4.Text = resources.GetString("label4.Text");
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.BackColor = Color.BlanchedAlmond;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label2);
            panel1.Location = new Point(50, 495);
            panel1.Name = "panel1";
            panel1.Size = new Size(748, 65);
            panel1.TabIndex = 8;
            // 
            // RandStat
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1264, 681);
            Controls.Add(panel1);
            Controls.Add(label4);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(tryInputBox);
            Controls.Add(randNumRangedown);
            Controls.Add(randNumRangeup);
            Name = "RandStat";
            Text = "RandStat";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion


        private TextBox tryInputBox;
        private TextBox randNumRangedown;
        private TextBox randNumRangeup;
        private Label label1;
        private Button button1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private Label label4;
        private Panel panel1;
    }
}
