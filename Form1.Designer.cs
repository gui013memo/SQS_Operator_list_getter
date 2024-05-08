namespace SQS_Operator_list_getter
{
    partial class mainForm
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
            getOperatorListButton = new Button();
            openOutputDirectoryButton = new Button();
            consoleTextBox = new TextBox();
            SuspendLayout();
            // 
            // getOperatorListButton
            // 
            getOperatorListButton.BackColor = Color.LightGreen;
            getOperatorListButton.Location = new Point(12, 369);
            getOperatorListButton.Name = "getOperatorListButton";
            getOperatorListButton.Size = new Size(178, 69);
            getOperatorListButton.TabIndex = 0;
            getOperatorListButton.Text = "Get operator list";
            getOperatorListButton.UseVisualStyleBackColor = false;
            // 
            // openOutputDirectoryButton
            // 
            openOutputDirectoryButton.Location = new Point(210, 369);
            openOutputDirectoryButton.Name = "openOutputDirectoryButton";
            openOutputDirectoryButton.Size = new Size(184, 69);
            openOutputDirectoryButton.TabIndex = 1;
            openOutputDirectoryButton.Text = "Open output directory";
            openOutputDirectoryButton.UseVisualStyleBackColor = true;
            // 
            // consoleTextBox
            // 
            consoleTextBox.Location = new Point(12, 12);
            consoleTextBox.Multiline = true;
            consoleTextBox.Name = "consoleTextBox";
            consoleTextBox.Size = new Size(382, 351);
            consoleTextBox.TabIndex = 2;
            // 
            // mainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(406, 450);
            Controls.Add(consoleTextBox);
            Controls.Add(openOutputDirectoryButton);
            Controls.Add(getOperatorListButton);
            Name = "mainForm";
            Text = "SQS Operator List Getter - v1.0";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button getOperatorListButton;
        private Button openOutputDirectoryButton;
        private TextBox consoleTextBox;
    }
}
