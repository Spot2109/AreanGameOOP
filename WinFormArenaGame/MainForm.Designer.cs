namespace WinFormArenaGame
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            btnNewGame = new Button();
            tbKnight = new TextBox();
            tbAssassin = new TextBox();
            imgFight = new PictureBox();
            lbWinner = new Label();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)imgFight).BeginInit();
            SuspendLayout();
            // 
            // btnNewGame
            // 
            btnNewGame.Location = new Point(844, 79);
            btnNewGame.Margin = new Padding(4, 4, 4, 4);
            btnNewGame.Name = "btnNewGame";
            btnNewGame.Size = new Size(118, 36);
            btnNewGame.TabIndex = 0;
            btnNewGame.Text = "New Game";
            btnNewGame.UseVisualStyleBackColor = true;
            btnNewGame.Click += btnNewGame_Click;
            // 
            // tbKnight
            // 
            tbKnight.Location = new Point(29, 44);
            tbKnight.Margin = new Padding(4, 4, 4, 4);
            tbKnight.Multiline = true;
            tbKnight.Name = "tbKnight";
            tbKnight.Size = new Size(699, 545);
            tbKnight.TabIndex = 1;
            // 
            // tbAssassin
            // 
            tbAssassin.Location = new Point(1099, 55);
            tbAssassin.Margin = new Padding(4, 4, 4, 4);
            tbAssassin.Multiline = true;
            tbAssassin.Name = "tbAssassin";
            tbAssassin.Size = new Size(699, 545);
            tbAssassin.TabIndex = 2;
            // 
            // imgFight
            // 
            imgFight.Enabled = false;
            imgFight.Image = (Image)resources.GetObject("imgFight.Image");
            imgFight.Location = new Point(789, 315);
            imgFight.Margin = new Padding(4, 4, 4, 4);
            imgFight.Name = "imgFight";
            imgFight.Size = new Size(258, 168);
            imgFight.TabIndex = 3;
            imgFight.TabStop = false;
            imgFight.Click += imgFight_Click;
            // 
            // lbWinner
            // 
            lbWinner.Location = new Point(789, 151);
            lbWinner.Margin = new Padding(4, 0, 4, 0);
            lbWinner.Name = "lbWinner";
            lbWinner.Size = new Size(258, 111);
            lbWinner.TabIndex = 4;
            lbWinner.Visible = false;
            lbWinner.Click += lbWinner_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(1099, 22);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(83, 25);
            label1.TabIndex = 5;
            label1.Text = "Assassin:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 11);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(67, 25);
            label2.TabIndex = 6;
            label2.Text = "Knight:";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1830, 630);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lbWinner);
            Controls.Add(imgFight);
            Controls.Add(tbAssassin);
            Controls.Add(tbKnight);
            Controls.Add(btnNewGame);
            Margin = new Padding(4, 4, 4, 4);
            Name = "MainForm";
            Text = "Arena Game";
            ((System.ComponentModel.ISupportInitialize)imgFight).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnNewGame;
        private TextBox tbKnight;
        private TextBox tbAssassin;
        private PictureBox imgFight;
        private Label lbWinner;
        private Label label1;
        private Label label2;
    }
}