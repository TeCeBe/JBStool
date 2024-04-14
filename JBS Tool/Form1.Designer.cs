
namespace JBS_Tool
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
            winInfo = new System.Windows.Forms.Label();
            supportInfo = new System.Windows.Forms.Label();
            tabControl1 = new System.Windows.Forms.TabControl();
            tabPage1 = new System.Windows.Forms.TabPage();
            groupBox2 = new System.Windows.Forms.GroupBox();
            button4 = new System.Windows.Forms.Button();
            button3 = new System.Windows.Forms.Button();
            button2 = new System.Windows.Forms.Button();
            niniteGroupbox = new System.Windows.Forms.GroupBox();
            linkLabel2 = new System.Windows.Forms.LinkLabel();
            autorunNinite = new System.Windows.Forms.CheckBox();
            button1 = new System.Windows.Forms.Button();
            niniteMainList = new System.Windows.Forms.CheckedListBox();
            tabPage2 = new System.Windows.Forms.TabPage();
            button7 = new System.Windows.Forms.Button();
            button6 = new System.Windows.Forms.Button();
            button5 = new System.Windows.Forms.Button();
            checkBox2 = new System.Windows.Forms.CheckBox();
            textBox5 = new System.Windows.Forms.TextBox();
            label6 = new System.Windows.Forms.Label();
            textBox4 = new System.Windows.Forms.TextBox();
            label5 = new System.Windows.Forms.Label();
            textBox3 = new System.Windows.Forms.TextBox();
            label4 = new System.Windows.Forms.Label();
            textBox2 = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            textBox1 = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            listBox1 = new System.Windows.Forms.ListBox();
            linkLabel1 = new System.Windows.Forms.LinkLabel();
            linkLabel3 = new System.Windows.Forms.LinkLabel();
            linkLabel4 = new System.Windows.Forms.LinkLabel();
            linkLabel5 = new System.Windows.Forms.LinkLabel();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            groupBox2.SuspendLayout();
            niniteGroupbox.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // winInfo
            // 
            winInfo.AutoSize = true;
            winInfo.Location = new System.Drawing.Point(12, 9);
            winInfo.Name = "winInfo";
            winInfo.Size = new System.Drawing.Size(235, 15);
            winInfo.TabIndex = 0;
            winInfo.Text = "Twoja wersja systemu Windows: Windows ?";
            // 
            // supportInfo
            // 
            supportInfo.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            supportInfo.AutoSize = true;
            supportInfo.ForeColor = System.Drawing.Color.Red;
            supportInfo.Location = new System.Drawing.Point(374, 9);
            supportInfo.Name = "supportInfo";
            supportInfo.Size = new System.Drawing.Size(130, 15);
            supportInfo.TabIndex = 1;
            supportInfo.Text = "Niewspierany Windows";
            // 
            // tabControl1
            // 
            tabControl1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new System.Drawing.Point(0, 27);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new System.Drawing.Size(800, 427);
            tabControl1.TabIndex = 3;
            tabControl1.SelectedIndexChanged += tabControl1_SelectedIndexChanged;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(groupBox2);
            tabPage1.Controls.Add(niniteGroupbox);
            tabPage1.Location = new System.Drawing.Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new System.Windows.Forms.Padding(3);
            tabPage1.Size = new System.Drawing.Size(792, 399);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Start";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            groupBox2.Controls.Add(button4);
            groupBox2.Controls.Add(button3);
            groupBox2.Controls.Add(button2);
            groupBox2.Location = new System.Drawing.Point(272, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new System.Drawing.Size(512, 393);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Na skróty";
            // 
            // button4
            // 
            button4.Location = new System.Drawing.Point(6, 51);
            button4.Name = "button4";
            button4.Size = new System.Drawing.Size(240, 23);
            button4.TabIndex = 5;
            button4.Text = "Ustawienia";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Location = new System.Drawing.Point(266, 22);
            button3.Name = "button3";
            button3.Size = new System.Drawing.Size(240, 23);
            button3.TabIndex = 1;
            button3.Text = "Panel sterowania";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new System.Drawing.Point(6, 22);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(240, 23);
            button2.TabIndex = 0;
            button2.Text = "Eksplorator plików";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // niniteGroupbox
            // 
            niniteGroupbox.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            niniteGroupbox.Controls.Add(linkLabel2);
            niniteGroupbox.Controls.Add(autorunNinite);
            niniteGroupbox.Controls.Add(button1);
            niniteGroupbox.Controls.Add(niniteMainList);
            niniteGroupbox.Location = new System.Drawing.Point(3, 3);
            niniteGroupbox.Name = "niniteGroupbox";
            niniteGroupbox.Size = new System.Drawing.Size(263, 393);
            niniteGroupbox.TabIndex = 0;
            niniteGroupbox.TabStop = false;
            niniteGroupbox.Text = "Ninite";
            // 
            // linkLabel2
            // 
            linkLabel2.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            linkLabel2.AutoSize = true;
            linkLabel2.Location = new System.Drawing.Point(6, 375);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new System.Drawing.Size(99, 15);
            linkLabel2.TabIndex = 3;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Zaznacz wszystko";
            linkLabel2.LinkClicked += linkLabel2_LinkClicked;
            // 
            // autorunNinite
            // 
            autorunNinite.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            autorunNinite.AutoSize = true;
            autorunNinite.Location = new System.Drawing.Point(0, 353);
            autorunNinite.Name = "autorunNinite";
            autorunNinite.Size = new System.Drawing.Size(144, 19);
            autorunNinite.TabIndex = 2;
            autorunNinite.Text = "Uruchom po pobraniu";
            autorunNinite.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            button1.Location = new System.Drawing.Point(5, 324);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(251, 23);
            button1.TabIndex = 1;
            button1.Text = "Pobierz zaznaczone";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // niniteMainList
            // 
            niniteMainList.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            niniteMainList.FormattingEnabled = true;
            niniteMainList.Items.AddRange(new object[] { "Google Chrome", "Mozilla Firefox", "Opera", "Microsoft Edge", "7-Zip", "VLC", "LibreOffice", "Foxit Reader" });
            niniteMainList.Location = new System.Drawing.Point(6, 22);
            niniteMainList.Name = "niniteMainList";
            niniteMainList.Size = new System.Drawing.Size(251, 292);
            niniteMainList.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(button7);
            tabPage2.Controls.Add(button6);
            tabPage2.Controls.Add(button5);
            tabPage2.Controls.Add(checkBox2);
            tabPage2.Controls.Add(textBox5);
            tabPage2.Controls.Add(label6);
            tabPage2.Controls.Add(textBox4);
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(textBox3);
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(textBox2);
            tabPage2.Controls.Add(label3);
            tabPage2.Controls.Add(label2);
            tabPage2.Controls.Add(textBox1);
            tabPage2.Controls.Add(label1);
            tabPage2.Controls.Add(listBox1);
            tabPage2.Location = new System.Drawing.Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new System.Windows.Forms.Padding(3);
            tabPage2.Size = new System.Drawing.Size(792, 399);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Sieć";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.Location = new System.Drawing.Point(687, 359);
            button7.Name = "button7";
            button7.Size = new System.Drawing.Size(75, 23);
            button7.TabIndex = 15;
            button7.Text = "Zapisz";
            button7.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new System.Drawing.Point(463, 359);
            button6.Name = "button6";
            button6.Size = new System.Drawing.Size(218, 23);
            button6.TabIndex = 14;
            button6.Text = "Statyczny bez komunikacji (EGZAMIN)";
            button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new System.Drawing.Point(273, 359);
            button5.Name = "button5";
            button5.Size = new System.Drawing.Size(184, 23);
            button5.TabIndex = 13;
            button5.Text = "Wyłącz DHCP i ustaw statyczny";
            button5.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new System.Drawing.Point(273, 326);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new System.Drawing.Size(58, 19);
            checkBox2.TabIndex = 12;
            checkBox2.Text = "DHCP";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // textBox5
            // 
            textBox5.Location = new System.Drawing.Point(273, 297);
            textBox5.Name = "textBox5";
            textBox5.Size = new System.Drawing.Size(312, 23);
            textBox5.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(273, 279);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(39, 15);
            label6.TabIndex = 10;
            label6.Text = "DNS 2";
            // 
            // textBox4
            // 
            textBox4.Location = new System.Drawing.Point(273, 253);
            textBox4.Name = "textBox4";
            textBox4.Size = new System.Drawing.Size(312, 23);
            textBox4.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(273, 235);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(39, 15);
            label5.TabIndex = 8;
            label5.Text = "DNS 1";
            // 
            // textBox3
            // 
            textBox3.Location = new System.Drawing.Point(273, 179);
            textBox3.Name = "textBox3";
            textBox3.Size = new System.Drawing.Size(312, 23);
            textBox3.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(273, 161);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(41, 15);
            label4.TabIndex = 6;
            label4.Text = "Brama";
            // 
            // textBox2
            // 
            textBox2.Location = new System.Drawing.Point(273, 135);
            textBox2.Name = "textBox2";
            textBox2.Size = new System.Drawing.Size(312, 23);
            textBox2.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(273, 117);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(41, 15);
            label3.TabIndex = 4;
            label3.Text = "Maska";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(273, 73);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(29, 15);
            label2.TabIndex = 3;
            label2.Text = "IPv4";
            // 
            // textBox1
            // 
            textBox1.Location = new System.Drawing.Point(273, 91);
            textBox1.Name = "textBox1";
            textBox1.Size = new System.Drawing.Size(312, 23);
            textBox1.TabIndex = 2;
            // 
            // label1
            // 
            label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(273, 3);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(511, 70);
            label1.TabIndex = 1;
            label1.Text = "Nazwa interfejsu sieciowego";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new System.Drawing.Point(3, 3);
            listBox1.Name = "listBox1";
            listBox1.Size = new System.Drawing.Size(264, 379);
            listBox1.TabIndex = 0;
            // 
            // linkLabel1
            // 
            linkLabel1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new System.Drawing.Point(730, 9);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new System.Drawing.Size(63, 15);
            linkLabel1.TabIndex = 4;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Pobieranie";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // linkLabel3
            // 
            linkLabel3.AutoSize = true;
            linkLabel3.Location = new System.Drawing.Point(662, 9);
            linkLabel3.Name = "linkLabel3";
            linkLabel3.Size = new System.Drawing.Size(62, 15);
            linkLabel3.TabIndex = 5;
            linkLabel3.TabStop = true;
            linkLabel3.Text = "O aplikacji";
            linkLabel3.LinkClicked += linkLabel3_LinkClicked;
            // 
            // linkLabel4
            // 
            linkLabel4.AutoSize = true;
            linkLabel4.Location = new System.Drawing.Point(553, 9);
            linkLabel4.Name = "linkLabel4";
            linkLabel4.Size = new System.Drawing.Size(103, 15);
            linkLabel4.TabIndex = 6;
            linkLabel4.TabStop = true;
            linkLabel4.Text = "Zdalne sterowanie";
            linkLabel4.LinkClicked += linkLabel4_LinkClicked;
            // 
            // linkLabel5
            // 
            linkLabel5.AutoSize = true;
            linkLabel5.Location = new System.Drawing.Point(510, 9);
            linkLabel5.Name = "linkLabel5";
            linkLabel5.Size = new System.Drawing.Size(37, 15);
            linkLabel5.TabIndex = 7;
            linkLabel5.TabStop = true;
            linkLabel5.Text = "Klient";
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 456);
            Controls.Add(linkLabel5);
            Controls.Add(linkLabel4);
            Controls.Add(linkLabel3);
            Controls.Add(linkLabel1);
            Controls.Add(tabControl1);
            Controls.Add(supportInfo);
            Controls.Add(winInfo);
            Name = "Form1";
            Text = "JBS Tool v0.1 beta";
            Load += Form1_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            niniteGroupbox.ResumeLayout(false);
            niniteGroupbox.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label winInfo;
        private System.Windows.Forms.Label supportInfo;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox niniteGroupbox;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckedListBox niniteMainList;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.LinkLabel linkLabel3;
        private System.Windows.Forms.CheckBox autorunNinite;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLabel4;
        private System.Windows.Forms.LinkLabel linkLabel5;
    }
}

