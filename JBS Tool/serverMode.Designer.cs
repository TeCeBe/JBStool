
namespace JBS_Tool
{
    partial class serverMode
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
            ipTextBox = new System.Windows.Forms.TextBox();
            uriTextBox = new System.Windows.Forms.TextBox();
            logTextBox = new System.Windows.Forms.RichTextBox();
            label4 = new System.Windows.Forms.Label();
            actionBox = new System.Windows.Forms.GroupBox();
            linkLabel2 = new System.Windows.Forms.LinkLabel();
            dhcpButton = new System.Windows.Forms.Button();
            staticNoGwButton = new System.Windows.Forms.Button();
            staticButton = new System.Windows.Forms.Button();
            checkBox1 = new System.Windows.Forms.CheckBox();
            shutdownButton = new System.Windows.Forms.Button();
            label2 = new System.Windows.Forms.Label();
            commandTextBox = new System.Windows.Forms.TextBox();
            button10 = new System.Windows.Forms.Button();
            button9 = new System.Windows.Forms.Button();
            button4 = new System.Windows.Forms.Button();
            button3 = new System.Windows.Forms.Button();
            linkLabel1 = new System.Windows.Forms.LinkLabel();
            runServerButton = new System.Windows.Forms.Button();
            stopServerButton = new System.Windows.Forms.Button();
            linkLabel3 = new System.Windows.Forms.LinkLabel();
            saveLogDialog = new System.Windows.Forms.SaveFileDialog();
            actionBox.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(12, 9);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(78, 15);
            label1.TabIndex = 0;
            label1.Text = "Twój adres IP:";
            // 
            // ipTextBox
            // 
            ipTextBox.Location = new System.Drawing.Point(96, 6);
            ipTextBox.Name = "ipTextBox";
            ipTextBox.ReadOnly = true;
            ipTextBox.Size = new System.Drawing.Size(256, 23);
            ipTextBox.TabIndex = 1;
            // 
            // uriTextBox
            // 
            uriTextBox.Location = new System.Drawing.Point(318, 138);
            uriTextBox.Name = "uriTextBox";
            uriTextBox.Size = new System.Drawing.Size(306, 23);
            uriTextBox.TabIndex = 8;
            // 
            // logTextBox
            // 
            logTextBox.Location = new System.Drawing.Point(18, 35);
            logTextBox.Name = "logTextBox";
            logTextBox.Size = new System.Drawing.Size(966, 299);
            logTextBox.TabIndex = 9;
            logTextBox.Text = "";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(318, 113);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(28, 15);
            label4.TabIndex = 10;
            label4.Text = "URL";
            // 
            // actionBox
            // 
            actionBox.Controls.Add(linkLabel2);
            actionBox.Controls.Add(dhcpButton);
            actionBox.Controls.Add(staticNoGwButton);
            actionBox.Controls.Add(staticButton);
            actionBox.Controls.Add(checkBox1);
            actionBox.Controls.Add(shutdownButton);
            actionBox.Controls.Add(label2);
            actionBox.Controls.Add(commandTextBox);
            actionBox.Controls.Add(button10);
            actionBox.Controls.Add(button9);
            actionBox.Controls.Add(label4);
            actionBox.Controls.Add(uriTextBox);
            actionBox.Controls.Add(button4);
            actionBox.Controls.Add(button3);
            actionBox.Enabled = false;
            actionBox.Location = new System.Drawing.Point(12, 340);
            actionBox.Name = "actionBox";
            actionBox.Size = new System.Drawing.Size(972, 191);
            actionBox.TabIndex = 11;
            actionBox.TabStop = false;
            actionBox.Text = "Akcje";
            // 
            // linkLabel2
            // 
            linkLabel2.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            linkLabel2.AutoSize = true;
            linkLabel2.Location = new System.Drawing.Point(630, 164);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new System.Drawing.Size(206, 15);
            linkLabel2.TabIndex = 18;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Pomoc dotycząca powyższych funkcji";
            linkLabel2.LinkClicked += linkLabel2_LinkClicked;
            // 
            // dhcpButton
            // 
            dhcpButton.Enabled = false;
            dhcpButton.Location = new System.Drawing.Point(630, 138);
            dhcpButton.Name = "dhcpButton";
            dhcpButton.Size = new System.Drawing.Size(302, 23);
            dhcpButton.TabIndex = 17;
            dhcpButton.Text = "Włącz DHCP";
            dhcpButton.UseVisualStyleBackColor = true;
            dhcpButton.Click += dhcpButton_Click;
            // 
            // staticNoGwButton
            // 
            staticNoGwButton.Enabled = false;
            staticNoGwButton.Location = new System.Drawing.Point(630, 109);
            staticNoGwButton.Name = "staticNoGwButton";
            staticNoGwButton.Size = new System.Drawing.Size(302, 23);
            staticNoGwButton.TabIndex = 16;
            staticNoGwButton.Text = "Ustaw statyczny adres bez komunikacji";
            staticNoGwButton.UseVisualStyleBackColor = true;
            staticNoGwButton.Click += staticNoGwButton_Click;
            // 
            // staticButton
            // 
            staticButton.Enabled = false;
            staticButton.Location = new System.Drawing.Point(630, 80);
            staticButton.Name = "staticButton";
            staticButton.Size = new System.Drawing.Size(302, 23);
            staticButton.TabIndex = 15;
            staticButton.Text = "Wyłącz DHCP i ustaw statyczny adres";
            staticButton.UseVisualStyleBackColor = true;
            staticButton.Click += staticButton_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new System.Drawing.Point(630, 25);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new System.Drawing.Size(148, 19);
            checkBox1.TabIndex = 14;
            checkBox1.Text = "Odblokuj opcje poniżej";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged_1;
            // 
            // shutdownButton
            // 
            shutdownButton.Enabled = false;
            shutdownButton.Location = new System.Drawing.Point(630, 51);
            shutdownButton.Name = "shutdownButton";
            shutdownButton.Size = new System.Drawing.Size(302, 23);
            shutdownButton.TabIndex = 13;
            shutdownButton.Text = "Wyślij komendę wyłączenia komputera";
            shutdownButton.UseVisualStyleBackColor = true;
            shutdownButton.Click += shutdownButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(6, 113);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(58, 15);
            label2.TabIndex = 12;
            label2.Text = "Polecenie";
            // 
            // commandTextBox
            // 
            commandTextBox.Location = new System.Drawing.Point(6, 138);
            commandTextBox.Name = "commandTextBox";
            commandTextBox.Size = new System.Drawing.Size(306, 23);
            commandTextBox.TabIndex = 11;
            // 
            // button10
            // 
            button10.Location = new System.Drawing.Point(6, 82);
            button10.Name = "button10";
            button10.Size = new System.Drawing.Size(306, 23);
            button10.TabIndex = 10;
            button10.Text = "Wyślij polecenie (cmd)";
            button10.UseVisualStyleBackColor = true;
            button10.Click += button10_Click;
            // 
            // button9
            // 
            button9.Location = new System.Drawing.Point(6, 51);
            button9.Name = "button9";
            button9.Size = new System.Drawing.Size(306, 23);
            button9.TabIndex = 8;
            button9.Text = "Test komunikacji";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // button4
            // 
            button4.Location = new System.Drawing.Point(318, 80);
            button4.Name = "button4";
            button4.Size = new System.Drawing.Size(306, 23);
            button4.TabIndex = 1;
            button4.Text = "Wyślij komendę wyłączenia przeglądarki";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Location = new System.Drawing.Point(318, 51);
            button3.Name = "button3";
            button3.Size = new System.Drawing.Size(306, 23);
            button3.TabIndex = 0;
            button3.Text = "Wyślij komendę włączenia przeglądarki wraz z URL";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new System.Drawing.Point(647, 9);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new System.Drawing.Size(45, 15);
            linkLabel1.TabIndex = 7;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Pomoc";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // runServerButton
            // 
            runServerButton.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            runServerButton.Location = new System.Drawing.Point(698, 5);
            runServerButton.Name = "runServerButton";
            runServerButton.Size = new System.Drawing.Size(140, 23);
            runServerButton.TabIndex = 12;
            runServerButton.Text = "Uruchom serwer";
            runServerButton.UseVisualStyleBackColor = true;
            runServerButton.Click += button11_Click;
            // 
            // stopServerButton
            // 
            stopServerButton.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            stopServerButton.Location = new System.Drawing.Point(844, 5);
            stopServerButton.Name = "stopServerButton";
            stopServerButton.Size = new System.Drawing.Size(140, 23);
            stopServerButton.TabIndex = 13;
            stopServerButton.Text = "Zatrzymaj serwer";
            stopServerButton.UseVisualStyleBackColor = true;
            stopServerButton.Click += button12_Click;
            // 
            // linkLabel3
            // 
            linkLabel3.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            linkLabel3.AutoSize = true;
            linkLabel3.Location = new System.Drawing.Point(532, 9);
            linkLabel3.Name = "linkLabel3";
            linkLabel3.Size = new System.Drawing.Size(109, 15);
            linkLabel3.TabIndex = 14;
            linkLabel3.TabStop = true;
            linkLabel3.Text = "Zapisz logi do pliku";
            linkLabel3.LinkClicked += linkLabel3_LinkClicked;
            // 
            // saveLogDialog
            // 
            saveLogDialog.Filter = "pliki txt|*.txt";
            saveLogDialog.Title = "Zapisz log";
            // 
            // serverMode
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(996, 543);
            Controls.Add(linkLabel3);
            Controls.Add(stopServerButton);
            Controls.Add(runServerButton);
            Controls.Add(actionBox);
            Controls.Add(logTextBox);
            Controls.Add(linkLabel1);
            Controls.Add(ipTextBox);
            Controls.Add(label1);
            Name = "serverMode";
            Text = "Tryb serwera";
            Load += serverMode_Load;
            actionBox.ResumeLayout(false);
            actionBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ipTextBox;
        private System.Windows.Forms.TextBox uriTextBox;
        private System.Windows.Forms.RichTextBox logTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox actionBox;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button runServerButton;
        private System.Windows.Forms.Button stopServerButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox commandTextBox;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.Button dhcpButton;
        private System.Windows.Forms.Button staticNoGwButton;
        private System.Windows.Forms.Button staticButton;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button shutdownButton;
        private System.Windows.Forms.LinkLabel linkLabel3;
        private System.Windows.Forms.SaveFileDialog saveLogDialog;
    }
}