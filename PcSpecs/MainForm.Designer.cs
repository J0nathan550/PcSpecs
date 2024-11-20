namespace PcSpecs
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
            copyToClipboardButton = new Button();
            infoTextBox = new TextBox();
            SuspendLayout();
            // 
            // copyToClipboardButton
            // 
            copyToClipboardButton.Dock = DockStyle.Bottom;
            copyToClipboardButton.Location = new Point(0, 238);
            copyToClipboardButton.Name = "copyToClipboardButton";
            copyToClipboardButton.Size = new Size(284, 23);
            copyToClipboardButton.TabIndex = 6;
            copyToClipboardButton.Text = "Copy information to clipboard...";
            copyToClipboardButton.UseVisualStyleBackColor = true;
            copyToClipboardButton.Click += copyToClipboardButton_Click;
            // 
            // infoTextBox
            // 
            infoTextBox.AcceptsReturn = true;
            infoTextBox.AcceptsTab = true;
            infoTextBox.Dock = DockStyle.Fill;
            infoTextBox.Location = new Point(0, 0);
            infoTextBox.Multiline = true;
            infoTextBox.Name = "infoTextBox";
            infoTextBox.ReadOnly = true;
            infoTextBox.ScrollBars = ScrollBars.Both;
            infoTextBox.Size = new Size(284, 238);
            infoTextBox.TabIndex = 7;
            // 
            // MainForm
            // 
            BackColor = Color.White;
            ClientSize = new Size(284, 261);
            Controls.Add(infoTextBox);
            Controls.Add(copyToClipboardButton);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PcSpecs";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button copyToClipboardButton;
        private TextBox infoTextBox;
    }
}
