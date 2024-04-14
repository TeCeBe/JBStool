
namespace JBS_Tool
{
    partial class downloadWindow
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
            this.currentStatus = new System.Windows.Forms.Label();
            this.currentProgressBar = new System.Windows.Forms.ProgressBar();
            this.currentLinkLabel = new System.Windows.Forms.Label();
            this.currentProgressLabel = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            this.retryButton = new System.Windows.Forms.Button();
            this.autorunCheckbox = new System.Windows.Forms.CheckBox();
            this.runButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // currentStatus
            // 
            this.currentStatus.AutoSize = true;
            this.currentStatus.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.currentStatus.Location = new System.Drawing.Point(12, 9);
            this.currentStatus.Name = "currentStatus";
            this.currentStatus.Size = new System.Drawing.Size(151, 21);
            this.currentStatus.TabIndex = 0;
            this.currentStatus.Text = "Oczekuję na zadanie";
            // 
            // currentProgressBar
            // 
            this.currentProgressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.currentProgressBar.Location = new System.Drawing.Point(12, 33);
            this.currentProgressBar.Name = "currentProgressBar";
            this.currentProgressBar.Size = new System.Drawing.Size(783, 23);
            this.currentProgressBar.TabIndex = 1;
            // 
            // currentLinkLabel
            // 
            this.currentLinkLabel.AutoSize = true;
            this.currentLinkLabel.Location = new System.Drawing.Point(12, 59);
            this.currentLinkLabel.Name = "currentLinkLabel";
            this.currentLinkLabel.Size = new System.Drawing.Size(32, 15);
            this.currentLinkLabel.TabIndex = 2;
            this.currentLinkLabel.Text = "Link:";
            // 
            // currentProgressLabel
            // 
            this.currentProgressLabel.AutoSize = true;
            this.currentProgressLabel.Location = new System.Drawing.Point(12, 74);
            this.currentProgressLabel.Name = "currentProgressLabel";
            this.currentProgressLabel.Size = new System.Drawing.Size(65, 15);
            this.currentProgressLabel.TabIndex = 3;
            this.currentProgressLabel.Text = "Postęp: 0%";
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cancelButton.Enabled = false;
            this.cancelButton.Location = new System.Drawing.Point(12, 113);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 4;
            this.cancelButton.Text = "Przerwij";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // retryButton
            // 
            this.retryButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.retryButton.Enabled = false;
            this.retryButton.Location = new System.Drawing.Point(93, 113);
            this.retryButton.Name = "retryButton";
            this.retryButton.Size = new System.Drawing.Size(75, 23);
            this.retryButton.TabIndex = 5;
            this.retryButton.Text = "Ponów";
            this.retryButton.UseVisualStyleBackColor = true;
            this.retryButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // autorunCheckbox
            // 
            this.autorunCheckbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.autorunCheckbox.AutoSize = true;
            this.autorunCheckbox.Location = new System.Drawing.Point(255, 117);
            this.autorunCheckbox.Name = "autorunCheckbox";
            this.autorunCheckbox.Size = new System.Drawing.Size(144, 19);
            this.autorunCheckbox.TabIndex = 6;
            this.autorunCheckbox.Text = "Uruchom po pobraniu";
            this.autorunCheckbox.UseVisualStyleBackColor = true;
            // 
            // runButton
            // 
            this.runButton.Enabled = false;
            this.runButton.Location = new System.Drawing.Point(174, 113);
            this.runButton.Name = "runButton";
            this.runButton.Size = new System.Drawing.Size(75, 23);
            this.runButton.TabIndex = 7;
            this.runButton.Text = "Uruchom";
            this.runButton.UseVisualStyleBackColor = true;
            this.runButton.Click += new System.EventHandler(this.runButton_Click);
            // 
            // downloadWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 148);
            this.Controls.Add(this.runButton);
            this.Controls.Add(this.autorunCheckbox);
            this.Controls.Add(this.retryButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.currentProgressLabel);
            this.Controls.Add(this.currentLinkLabel);
            this.Controls.Add(this.currentProgressBar);
            this.Controls.Add(this.currentStatus);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(823, 187);
            this.Name = "downloadWindow";
            this.Text = "Okienko pobierania";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label currentStatus;
        private System.Windows.Forms.ProgressBar currentProgressBar;
        private System.Windows.Forms.Label currentLinkLabel;
        private System.Windows.Forms.Label currentProgressLabel;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button retryButton;
        private System.Windows.Forms.CheckBox autorunCheckbox;
        private System.Windows.Forms.Button runButton;
    }
}