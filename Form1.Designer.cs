namespace CatchButton
{
    partial class ground
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
            RunningButton = new Button();
            SuspendLayout();
            // 
            // RunningButton
            // 
            RunningButton.BackColor = SystemColors.InactiveCaption;
            RunningButton.Font = new Font("맑은 고딕", 20F, FontStyle.Bold, GraphicsUnit.Point, 129);
            RunningButton.ForeColor = SystemColors.InactiveCaptionText;
            RunningButton.Location = new Point(215, 230);
            RunningButton.Name = "RunningButton";
            RunningButton.Size = new Size(261, 114);
            RunningButton.TabIndex = 0;
            RunningButton.Text = "나를 잡아봐";
            RunningButton.UseVisualStyleBackColor = false;
            RunningButton.MouseEnter += RunningButton_MouseEnter;
            // 
            // ground
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1270, 746);
            Controls.Add(RunningButton);
            Name = "ground";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button RunningButton;
    }
}
