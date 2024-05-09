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
            menuStrip1 = new MenuStrip();
            optionsToolStripMenuItem = new ToolStripMenuItem();
            configureDirectoryToolStripMenuItem = new ToolStripMenuItem();
            sourceToolStripMenuItem = new ToolStripMenuItem();
            outputToolStripMenuItem = new ToolStripMenuItem();
            checkCurrentDirToolStripMenuItem = new ToolStripMenuItem();
            clearConsoleToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
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
            getOperatorListButton.Click += getOperatorListButton_Click;
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
            consoleTextBox.Location = new Point(12, 43);
            consoleTextBox.Multiline = true;
            consoleTextBox.Name = "consoleTextBox";
            consoleTextBox.Size = new Size(382, 320);
            consoleTextBox.TabIndex = 2;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { optionsToolStripMenuItem, aboutToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(406, 28);
            menuStrip1.TabIndex = 3;
            menuStrip1.Text = "menuStrip1";
            // 
            // optionsToolStripMenuItem
            // 
            optionsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { configureDirectoryToolStripMenuItem, checkCurrentDirToolStripMenuItem, clearConsoleToolStripMenuItem });
            optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            optionsToolStripMenuItem.Size = new Size(75, 24);
            optionsToolStripMenuItem.Text = "Options";
            // 
            // configureDirectoryToolStripMenuItem
            // 
            configureDirectoryToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { sourceToolStripMenuItem, outputToolStripMenuItem });
            configureDirectoryToolStripMenuItem.Name = "configureDirectoryToolStripMenuItem";
            configureDirectoryToolStripMenuItem.Size = new Size(244, 26);
            configureDirectoryToolStripMenuItem.Text = "Configure directory";
            // 
            // sourceToolStripMenuItem
            // 
            sourceToolStripMenuItem.Name = "sourceToolStripMenuItem";
            sourceToolStripMenuItem.Size = new Size(224, 26);
            sourceToolStripMenuItem.Text = "Source";
            sourceToolStripMenuItem.Click += sourceToolStripMenuItem_Click;
            // 
            // outputToolStripMenuItem
            // 
            outputToolStripMenuItem.Name = "outputToolStripMenuItem";
            outputToolStripMenuItem.Size = new Size(224, 26);
            outputToolStripMenuItem.Text = "Output";
            outputToolStripMenuItem.Click += outputToolStripMenuItem_Click;
            // 
            // checkCurrentDirToolStripMenuItem
            // 
            checkCurrentDirToolStripMenuItem.Name = "checkCurrentDirToolStripMenuItem";
            checkCurrentDirToolStripMenuItem.Size = new Size(244, 26);
            checkCurrentDirToolStripMenuItem.Text = "Check current directory";
            checkCurrentDirToolStripMenuItem.Click += checkCurrentDirToolStripMenuItem_Click;
            // 
            // clearConsoleToolStripMenuItem
            // 
            clearConsoleToolStripMenuItem.Name = "clearConsoleToolStripMenuItem";
            clearConsoleToolStripMenuItem.Size = new Size(244, 26);
            clearConsoleToolStripMenuItem.Text = "Clear Console";
            clearConsoleToolStripMenuItem.Click += clearConsoleToolStripMenuItem_Click;
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(64, 24);
            aboutToolStripMenuItem.Text = "About";
            aboutToolStripMenuItem.Click += aboutToolStripMenuItem_Click;
            // 
            // mainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(406, 450);
            Controls.Add(consoleTextBox);
            Controls.Add(openOutputDirectoryButton);
            Controls.Add(getOperatorListButton);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "mainForm";
            Text = "SQS Operator List Getter - v1.0";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button getOperatorListButton;
        private Button openOutputDirectoryButton;
        private TextBox consoleTextBox;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem optionsToolStripMenuItem;
        private ToolStripMenuItem configureDirectoryToolStripMenuItem;
        private ToolStripMenuItem checkCurrentDirToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStripMenuItem clearConsoleToolStripMenuItem;
        private ToolStripMenuItem sourceToolStripMenuItem;
        private ToolStripMenuItem outputToolStripMenuItem;
    }
}
