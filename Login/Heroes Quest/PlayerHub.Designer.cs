namespace Heroes_Quest
{
    partial class PlayerHub
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
            PlayerNameDisplay = new Label();
            SuspendLayout();
            // 
            // PlayerNameDisplay
            // 
            PlayerNameDisplay.AutoSize = true;
            PlayerNameDisplay.Font = new Font("Castellar", 18F, FontStyle.Regular, GraphicsUnit.Point);
            PlayerNameDisplay.Location = new Point(12, 9);
            PlayerNameDisplay.Name = "PlayerNameDisplay";
            PlayerNameDisplay.Size = new Size(197, 29);
            PlayerNameDisplay.TabIndex = 0;
            PlayerNameDisplay.Text = "PlayerName";
            // 
            // PlayerHub
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(PlayerNameDisplay);
            Name = "PlayerHub";
            Text = "Form2";
            Load += PlayerHub_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label PlayerNameDisplay;
    }
}