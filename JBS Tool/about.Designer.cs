
namespace JBS_Tool
{
    partial class about
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
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            checkVersionButton = new System.Windows.Forms.Button();
            versionOutput = new System.Windows.Forms.Label();
            linkLabel1 = new System.Windows.Forms.LinkLabel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(12, 9);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(482, 45);
            label1.TabIndex = 0;
            label1.Text = "JBS Tool v1.0";
            label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(12, 54);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(482, 69);
            label2.TabIndex = 1;
            label2.Text = "Aplikacja tylko do użytku wewnętrznego JBS Komputery\r\n\r\nWszelkie prawa zastrzeżone";
            label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // checkVersionButton
            // 
            checkVersionButton.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            checkVersionButton.Location = new System.Drawing.Point(161, 126);
            checkVersionButton.Name = "checkVersionButton";
            checkVersionButton.Size = new System.Drawing.Size(185, 23);
            checkVersionButton.TabIndex = 2;
            checkVersionButton.Text = "Sprawdź dostępność aktualizacji";
            checkVersionButton.UseVisualStyleBackColor = true;
            checkVersionButton.Click += checkVersionButton_Click;
            // 
            // versionOutput
            // 
            versionOutput.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            versionOutput.Location = new System.Drawing.Point(12, 152);
            versionOutput.Name = "versionOutput";
            versionOutput.Size = new System.Drawing.Size(482, 15);
            versionOutput.TabIndex = 3;
            versionOutput.Text = "Masz najnowszą wersję aplikacji";
            versionOutput.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // linkLabel1
            // 
            linkLabel1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            linkLabel1.Location = new System.Drawing.Point(12, 167);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new System.Drawing.Size(482, 15);
            linkLabel1.TabIndex = 4;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Pobierz aktualizację w przeglądarce";
            linkLabel1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            linkLabel1.Visible = false;
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // about
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(506, 205);
            Controls.Add(linkLabel1);
            Controls.Add(versionOutput);
            Controls.Add(checkVersionButton);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "about";
            Text = "O aplikacji";
            TopMost = true;
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button checkVersionButton;
        private System.Windows.Forms.Label versionOutput;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}