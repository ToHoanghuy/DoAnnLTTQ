






namespace PuzzleGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            button8 = new Button();
            button7 = new Button();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            StartGame = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(button8);
            panel1.Controls.Add(button7);
            panel1.Controls.Add(button6);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(216, 216);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // button8
            // 
            button8.Location = new Point(72, 144);
            button8.Margin = new Padding(2);
            button8.Name = "button8";
            button8.Size = new Size(72, 72);
            button8.TabIndex = 7;
            button8.Text = "button8";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button1_Click;
            // 
            // button7
            // 
            button7.Location = new Point(0, 144);
            button7.Margin = new Padding(2);
            button7.Name = "button7";
            button7.Size = new Size(72, 72);
            button7.TabIndex = 6;
            button7.Text = "button7";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button1_Click;
            // 
            // button6
            // 
            button6.Location = new Point(144, 72);
            button6.Margin = new Padding(2);
            button6.Name = "button6";
            button6.Size = new Size(72, 72);
            button6.TabIndex = 5;
            button6.Text = "button6";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button1_Click;
            // 
            // button5
            // 
            button5.Location = new Point(72, 72);
            button5.Margin = new Padding(2);
            button5.Name = "button5";
            button5.Size = new Size(72, 72);
            button5.TabIndex = 4;
            button5.Text = "button5";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button1_Click;
            // 
            // button4
            // 
            button4.Location = new Point(0, 72);
            button4.Margin = new Padding(2);
            button4.Name = "button4";
            button4.Size = new Size(72, 72);
            button4.TabIndex = 3;
            button4.Text = "button4";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button1_Click;
            // 
            // button3
            // 
            button3.Location = new Point(144, 0);
            button3.Margin = new Padding(2);
            button3.Name = "button3";
            button3.Size = new Size(72, 72);
            button3.TabIndex = 2;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(72, 0);
            button2.Margin = new Padding(2);
            button2.Name = "button2";
            button2.Size = new Size(72, 72);
            button2.TabIndex = 1;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button1_Click;
            // 
            // button1
            // 
            button1.Location = new Point(0, 0);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(72, 72);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // StartGame
            // 
            StartGame.Location = new Point(52, 255);
            StartGame.Margin = new Padding(2);
            StartGame.Name = "StartGame";
            StartGame.Size = new Size(105, 27);
            StartGame.TabIndex = 4;
            StartGame.Text = "start game";
            StartGame.UseVisualStyleBackColor = true;
            StartGame.Click += button10_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 453);
            Controls.Add(StartGame);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2);
            Name = "Form1";
            Text = "Puzzle Game";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button8;
        private Button button7;
        private Button button6;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private Button StartGame;
        private Button button9;
    }
}