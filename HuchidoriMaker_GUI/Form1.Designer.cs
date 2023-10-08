namespace HuchidoriMaker_GUI
{
    partial class Form1
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
            button2 = new Button();
            lebel2 = new Label();
            Result = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            OutputPath = new TextBox();
            label1 = new Label();
            button3 = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // button2
            // 
            button2.Font = new Font("Yu Gothic UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(99, 63);
            button2.Name = "button2";
            button2.Size = new Size(235, 42);
            button2.TabIndex = 0;
            button2.Text = "ImageSelect";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click_1;
            // 
            // lebel2
            // 
            lebel2.AutoSize = true;
            lebel2.Font = new Font("Yu Gothic UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lebel2.Location = new Point(24, 130);
            lebel2.Name = "lebel2";
            lebel2.Size = new Size(79, 37);
            lebel2.TabIndex = 1;
            lebel2.Text = "Input";
            // 
            // Result
            // 
            Result.AutoSize = true;
            Result.Font = new Font("Yu Gothic UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            Result.Location = new Point(12, 183);
            Result.Name = "Result";
            Result.Size = new Size(89, 37);
            Result.TabIndex = 2;
            Result.Text = "Result";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Yu Gothic UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(12, 236);
            label3.Name = "label3";
            label3.Size = new Size(101, 37);
            label3.TabIndex = 3;
            label3.Text = "Output";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Yu Gothic UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(119, 142);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(235, 25);
            textBox1.TabIndex = 4;
            // 
            // OutputPath
            // 
            OutputPath.Font = new Font("Yu Gothic UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            OutputPath.Location = new Point(119, 248);
            OutputPath.Name = "OutputPath";
            OutputPath.ReadOnly = true;
            OutputPath.Size = new Size(235, 25);
            OutputPath.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(342, 66);
            label1.Name = "label1";
            label1.Size = new Size(150, 37);
            label1.TabIndex = 6;
            label1.Text = "HuchiColor";
            // 
            // button3
            // 
            button3.Font = new Font("Yu Gothic UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(498, 61);
            button3.Name = "button3";
            button3.Size = new Size(166, 42);
            button3.TabIndex = 7;
            button3.Text = "ColorSelect";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click_1;
            // 
            // button1
            // 
            button1.Font = new Font("Yu Gothic UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(498, 130);
            button1.Name = "button1";
            button1.Size = new Size(155, 130);
            button1.TabIndex = 8;
            button1.Text = "Huchidori";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 313);
            Controls.Add(button1);
            Controls.Add(button3);
            Controls.Add(label1);
            Controls.Add(OutputPath);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(Result);
            Controls.Add(lebel2);
            Controls.Add(button2);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button2;
        private Label lebel2;
        private Label Result;
        private Label label3;
        private TextBox textBox1;
        private TextBox OutputPath;
        private Label label1;
        private Button button3;
        private Button button1;
    }
}