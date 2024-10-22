namespace tic_tac_2
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
            tictac1 = new user();
            SuspendLayout();
            // 
            // tictac1
            // 
            tictac1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tictac1.BackColor = Color.FromArgb(255, 128, 128);
            tictac1.Font = new Font("Stencil", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tictac1.Location = new Point(-10, -1);
            tictac1.Margin = new Padding(6, 5, 6, 5);
            tictac1.Name = "tictac1";
            tictac1.Size = new Size(2179, 851);
            tictac1.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1639, 656);
            Controls.Add(tictac1);
            Name = "Form1";
            Text = "GAME";
            ResumeLayout(false);
        }

        #endregion

        private user tictac1;
    }
}
