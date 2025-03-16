namespace PrimeNumberCalculator
{
    partial class Form1
    {
       
        private System.ComponentModel.IContainer components = null;
        
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

        private void InitializeComponent()
        {
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            listBox1 = new ListBox();
            listBox2 = new ListBox();

            this.Load += new System.EventHandler(this.Form1_Load);

            SuspendLayout();

            textBox1.Location = new Point(194, 45);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 31);
            textBox1.TabIndex = 0;

            textBox2.Location = new Point(414, 45);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(150, 31);
            textBox2.TabIndex = 1;

            button1.Location = new Point(194, 102);
            button1.Name = "button1";
            button1.Size = new Size(150, 50);
            button1.TabIndex = 2;
            button1.Text = "Calculate 1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += new EventHandler(button1_Click);  

            button2.Location = new Point(414, 102);
            button2.Name = "button2";
            button2.Size = new Size(150, 50);
            button2.TabIndex = 3;
            button2.Text = "Calculate 2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += new EventHandler(button2_Click);  

            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 25;
            listBox1.Location = new Point(194, 180);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(150, 150);
            listBox1.TabIndex = 4;

            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 25;
            listBox2.Location = new Point(414, 180);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(150, 150);
            listBox2.TabIndex = 5;

            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listBox2);
            Controls.Add(listBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Prime Number Calculator";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private Button button1;
        private Button button2;
        private ListBox listBox1;
        private ListBox listBox2;
    }
}

