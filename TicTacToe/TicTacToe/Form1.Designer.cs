namespace TicTacToe
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
            btnOne = new Button();
            btnTwo = new Button();
            btnThree = new Button();
            btnFour = new Button();
            btnFive = new Button();
            btnSix = new Button();
            btnSeven = new Button();
            btnEight = new Button();
            btnNine = new Button();
            btnNew = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnOne
            // 
            btnOne.BackColor = Color.Beige;
            btnOne.Font = new Font("Arial", 36F, FontStyle.Bold);
            btnOne.Location = new Point(101, 162);
            btnOne.Name = "btnOne";
            btnOne.Size = new Size(124, 110);
            btnOne.TabIndex = 0;
            btnOne.Tag = 0;
            btnOne.UseVisualStyleBackColor = false;
            btnOne.Click += button_Click;
            // 
            // btnTwo
            // 
            btnTwo.BackColor = Color.Beige;
            btnTwo.Font = new Font("Arial", 36F, FontStyle.Bold);
            btnTwo.Location = new Point(231, 162);
            btnTwo.Name = "btnTwo";
            btnTwo.Size = new Size(124, 110);
            btnTwo.TabIndex = 1;
            btnTwo.Tag = 1;
            btnTwo.UseVisualStyleBackColor = false;
            btnTwo.Click += button_Click;
            // 
            // btnThree
            // 
            btnThree.BackColor = Color.Beige;
            btnThree.Font = new Font("Arial", 36F, FontStyle.Bold);
            btnThree.Location = new Point(361, 162);
            btnThree.Name = "btnThree";
            btnThree.Size = new Size(124, 110);
            btnThree.TabIndex = 2;
            btnThree.Tag = 2;
            btnThree.UseVisualStyleBackColor = false;
            btnThree.Click += button_Click;
            // 
            // btnFour
            // 
            btnFour.BackColor = Color.Beige;
            btnFour.Font = new Font("Arial", 36F, FontStyle.Bold);
            btnFour.Location = new Point(101, 278);
            btnFour.Name = "btnFour";
            btnFour.Size = new Size(124, 110);
            btnFour.TabIndex = 5;
            btnFour.Tag = 3;
            btnFour.UseVisualStyleBackColor = false;
            btnFour.Click += button_Click;
            // 
            // btnFive
            // 
            btnFive.BackColor = Color.Beige;
            btnFive.Font = new Font("Arial", 36F, FontStyle.Bold);
            btnFive.Location = new Point(231, 278);
            btnFive.Name = "btnFive";
            btnFive.Size = new Size(124, 110);
            btnFive.TabIndex = 4;
            btnFive.Tag = 4;
            btnFive.UseVisualStyleBackColor = false;
            btnFive.Click += button_Click;
            // 
            // btnSix
            // 
            btnSix.BackColor = Color.Beige;
            btnSix.Font = new Font("Arial", 36F, FontStyle.Bold);
            btnSix.Location = new Point(361, 278);
            btnSix.Name = "btnSix";
            btnSix.Size = new Size(124, 110);
            btnSix.TabIndex = 3;
            btnSix.Tag = 5;
            btnSix.UseVisualStyleBackColor = false;
            btnSix.Click += button_Click;
            // 
            // btnSeven
            // 
            btnSeven.BackColor = Color.Beige;
            btnSeven.Font = new Font("Arial", 36F, FontStyle.Bold);
            btnSeven.Location = new Point(101, 394);
            btnSeven.Name = "btnSeven";
            btnSeven.Size = new Size(124, 110);
            btnSeven.TabIndex = 8;
            btnSeven.Tag = 6;
            btnSeven.UseVisualStyleBackColor = false;
            btnSeven.Click += button_Click;
            // 
            // btnEight
            // 
            btnEight.BackColor = Color.Beige;
            btnEight.Font = new Font("Arial", 36F, FontStyle.Bold);
            btnEight.Location = new Point(231, 394);
            btnEight.Name = "btnEight";
            btnEight.Size = new Size(124, 110);
            btnEight.TabIndex = 7;
            btnEight.Tag = 7;
            btnEight.UseVisualStyleBackColor = false;
            btnEight.Click += button_Click;
            // 
            // btnNine
            // 
            btnNine.BackColor = Color.Beige;
            btnNine.Font = new Font("Arial", 36F, FontStyle.Bold);
            btnNine.Location = new Point(361, 394);
            btnNine.Name = "btnNine";
            btnNine.Size = new Size(124, 110);
            btnNine.TabIndex = 6;
            btnNine.Tag = 8;
            btnNine.UseVisualStyleBackColor = false;
            btnNine.Click += button_Click;
            // 
            // btnNew
            // 
            btnNew.BackColor = Color.Plum;
            btnNew.Location = new Point(243, 575);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(112, 34);
            btnNew.TabIndex = 9;
            btnNew.Text = "New Game";
            btnNew.UseVisualStyleBackColor = false;
            btnNew.Click += resetGame_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 28F, FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.Location = new Point(156, 62);
            label1.Name = "label1";
            label1.Size = new Size(294, 74);
            label1.TabIndex = 10;
            label1.Text = "Tic Tax Toe";
            // 
            // Form1
            // 
            BackColor = Color.PaleTurquoise;
            ClientSize = new Size(600, 700);
            Controls.Add(label1);
            Controls.Add(btnOne);
            Controls.Add(btnTwo);
            Controls.Add(btnThree);
            Controls.Add(btnFour);
            Controls.Add(btnFive);
            Controls.Add(btnSix);
            Controls.Add(btnSeven);
            Controls.Add(btnEight);
            Controls.Add(btnNine);
            Controls.Add(btnNew);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tic Tac Toe";
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion

        private Button btnOne;
        private Button btnTwo;
        private Button btnThree;
        private Button btnFour;
        private Button btnFive;
        private Button btnSix;
        private Button btnSeven;
        private Button btnEight;
        private Button btnNine;
        private Button btnNew;
        private Label label1;
    }
}
