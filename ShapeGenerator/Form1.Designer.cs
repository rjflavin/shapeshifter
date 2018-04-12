namespace ShapeGenerator
{
    partial class Form1
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.changeColorButton = new System.Windows.Forms.Button();
            this.toggleColorCheckBox = new System.Windows.Forms.CheckBox();
            this.resetButton = new System.Windows.Forms.Button();
            this.startStopButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1256, 969);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            // 
            // changeColorButton
            // 
            this.changeColorButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.changeColorButton.Location = new System.Drawing.Point(1282, 12);
            this.changeColorButton.Name = "changeColorButton";
            this.changeColorButton.Size = new System.Drawing.Size(535, 102);
            this.changeColorButton.TabIndex = 2;
            this.changeColorButton.Text = "Change Color (C)";
            this.changeColorButton.UseVisualStyleBackColor = true;
            this.changeColorButton.Click += new System.EventHandler(this.changeColorButton_Click);
            // 
            // toggleColorCheckBox
            // 
            this.toggleColorCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.toggleColorCheckBox.AutoSize = true;
            this.toggleColorCheckBox.Location = new System.Drawing.Point(1453, 301);
            this.toggleColorCheckBox.Name = "toggleColorCheckBox";
            this.toggleColorCheckBox.Size = new System.Drawing.Size(258, 36);
            this.toggleColorCheckBox.TabIndex = 3;
            this.toggleColorCheckBox.Text = "Toggle Color (T)";
            this.toggleColorCheckBox.UseVisualStyleBackColor = true;
            // 
            // resetButton
            // 
            this.resetButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.resetButton.Location = new System.Drawing.Point(1282, 120);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(535, 102);
            this.resetButton.TabIndex = 5;
            this.resetButton.Text = "Reset (R)";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // startStopButton
            // 
            this.startStopButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.startStopButton.Location = new System.Drawing.Point(1274, 776);
            this.startStopButton.Name = "startStopButton";
            this.startStopButton.Size = new System.Drawing.Size(543, 102);
            this.startStopButton.TabIndex = 6;
            this.startStopButton.Text = "Stop (Space)";
            this.startStopButton.UseVisualStyleBackColor = true;
            this.startStopButton.Click += new System.EventHandler(this.startStopButton_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(1274, 884);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(543, 97);
            this.button1.TabIndex = 7;
            this.button1.Text = "Export Image";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1829, 993);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.startStopButton);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.toggleColorCheckBox);
            this.Controls.Add(this.changeColorButton);
            this.Controls.Add(this.pictureBox1);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "ShapeShifter";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button changeColorButton;
        private System.Windows.Forms.CheckBox toggleColorCheckBox;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Button startStopButton;
        private System.Windows.Forms.Button button1;
    }
}

