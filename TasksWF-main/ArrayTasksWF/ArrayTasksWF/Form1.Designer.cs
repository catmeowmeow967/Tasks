namespace ArrayTasksWF
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Button btnTask1;
        private System.Windows.Forms.Button btnTask2;
        private System.Windows.Forms.Button btnTask3;
        private System.Windows.Forms.Button btnTask4;
        private System.Windows.Forms.Button btnTask5;
        private System.Windows.Forms.Button btnTask6;
        private System.Windows.Forms.RichTextBox output;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.btnTask1 = new System.Windows.Forms.Button();
            this.btnTask2 = new System.Windows.Forms.Button();
            this.btnTask3 = new System.Windows.Forms.Button();
            this.btnTask4 = new System.Windows.Forms.Button();
            this.btnTask5 = new System.Windows.Forms.Button();
            this.btnTask6 = new System.Windows.Forms.Button();
            this.output = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnTask1
            // 
            this.btnTask1.Location = new System.Drawing.Point(12, 12);
            this.btnTask1.Name = "btnTask1";
            this.btnTask1.Size = new System.Drawing.Size(120, 40);
            this.btnTask1.TabIndex = 0;
            this.btnTask1.Text = "Задача 1";
            this.btnTask1.UseVisualStyleBackColor = true;
            this.btnTask1.Click += new System.EventHandler(this.btnTask1_Click);
            // 
            // btnTask2
            // 
            this.btnTask2.Location = new System.Drawing.Point(150, 12);
            this.btnTask2.Name = "btnTask2";
            this.btnTask2.Size = new System.Drawing.Size(120, 40);
            this.btnTask2.TabIndex = 1;
            this.btnTask2.Text = "Задача 2";
            this.btnTask2.UseVisualStyleBackColor = true;
            this.btnTask2.Click += new System.EventHandler(this.btnTask2_Click);
            // 
            // btnTask3
            // 
            this.btnTask3.Location = new System.Drawing.Point(290, 12);
            this.btnTask3.Name = "btnTask3";
            this.btnTask3.Size = new System.Drawing.Size(120, 40);
            this.btnTask3.TabIndex = 2;
            this.btnTask3.Text = "Задача 3";
            this.btnTask3.UseVisualStyleBackColor = true;
            this.btnTask3.Click += new System.EventHandler(this.btnTask3_Click);
            // 
            // btnTask4
            // 
            this.btnTask4.Location = new System.Drawing.Point(430, 12);
            this.btnTask4.Name = "btnTask4";
            this.btnTask4.Size = new System.Drawing.Size(120, 40);
            this.btnTask4.TabIndex = 3;
            this.btnTask4.Text = "Задача 4";
            this.btnTask4.UseVisualStyleBackColor = true;
            this.btnTask4.Click += new System.EventHandler(this.btnTask4_Click);
            // 
            // btnTask5
            // 
            this.btnTask5.Location = new System.Drawing.Point(570, 12);
            this.btnTask5.Name = "btnTask5";
            this.btnTask5.Size = new System.Drawing.Size(120, 40);
            this.btnTask5.TabIndex = 4;
            this.btnTask5.Text = "Задача 5";
            this.btnTask5.UseVisualStyleBackColor = true;
            this.btnTask5.Click += new System.EventHandler(this.btnTask5_Click);
            // 
            // btnTask6
            // 
            this.btnTask6.Location = new System.Drawing.Point(710, 12);
            this.btnTask6.Name = "btnTask6";
            this.btnTask6.Size = new System.Drawing.Size(120, 40);
            this.btnTask6.TabIndex = 5;
            this.btnTask6.Text = "Задача 6";
            this.btnTask6.UseVisualStyleBackColor = true;
            this.btnTask6.Click += new System.EventHandler(this.btnTask6_Click);
            // 
            // output
            // 
            this.output.Location = new System.Drawing.Point(12, 70);
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(818, 368);
            this.output.TabIndex = 6;
            this.output.Text = "";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(842, 450);
            this.Controls.Add(this.output);
            this.Controls.Add(this.btnTask6);
            this.Controls.Add(this.btnTask5);
            this.Controls.Add(this.btnTask4);
            this.Controls.Add(this.btnTask3);
            this.Controls.Add(this.btnTask2);
            this.Controls.Add(this.btnTask1);
            this.Name = "Form1";
            this.Text = "Массивы - 6 задач";
            this.ResumeLayout(false);
        }
    }
}