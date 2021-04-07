
namespace KuCoinTradeBot
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnExit = new System.Windows.Forms.Button();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnFullscreen = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lblPair = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabAccounts = new System.Windows.Forms.TabControl();
            this.tabMainAccount = new System.Windows.Forms.TabPage();
            this.trvMainAccount = new System.Windows.Forms.TreeView();
            this.tabTradingAccount = new System.Windows.Forms.TabPage();
            this.trvTradingAccount = new System.Windows.Forms.TreeView();
            this.tabMarginAccount = new System.Windows.Forms.TabPage();
            this.trvMarginAccount = new System.Windows.Forms.TreeView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.trvPoolAccount = new System.Windows.Forms.TreeView();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.button4 = new System.Windows.Forms.Button();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lblUserBalance = new System.Windows.Forms.Label();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.btnToggleKeys = new System.Windows.Forms.Button();
            this.txtSavePath = new System.Windows.Forms.TextBox();
            this.chkExtMsg = new System.Windows.Forms.CheckBox();
            this.btnSaveCfg = new System.Windows.Forms.Button();
            this.txtPassphrase = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAPISecret = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAPIKey = new System.Windows.Forms.TextBox();
            this.lblAPIKey = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.tabPage1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabAccounts.SuspendLayout();
            this.tabMainAccount.SuspendLayout();
            this.tabTradingAccount.SuspendLayout();
            this.tabMarginAccount.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.BackColor = System.Drawing.Color.Black;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExit.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnExit.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnExit.Location = new System.Drawing.Point(1119, 13);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(21, 26);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.BackColor = System.Drawing.Color.Black;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMinimize.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMinimize.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnMinimize.Location = new System.Drawing.Point(1065, 12);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(21, 26);
            this.btnMinimize.TabIndex = 1;
            this.btnMinimize.Text = "_";
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnFullscreen
            // 
            this.btnFullscreen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFullscreen.BackColor = System.Drawing.Color.Black;
            this.btnFullscreen.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFullscreen.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnFullscreen.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnFullscreen.Location = new System.Drawing.Point(1092, 12);
            this.btnFullscreen.Name = "btnFullscreen";
            this.btnFullscreen.Size = new System.Drawing.Size(21, 26);
            this.btnFullscreen.TabIndex = 2;
            this.btnFullscreen.Text = "☐";
            this.btnFullscreen.UseVisualStyleBackColor = false;
            this.btnFullscreen.Click += new System.EventHandler(this.btnFullscreen_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.tabPage2.Location = new System.Drawing.Point(4, 30);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1120, 574);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Trade";
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.tabPage1.Controls.Add(this.lblPair);
            this.tabPage1.Location = new System.Drawing.Point(4, 30);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1120, 574);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Markets";
            // 
            // lblPair
            // 
            this.lblPair.AutoSize = true;
            this.lblPair.Location = new System.Drawing.Point(3, 14);
            this.lblPair.Name = "lblPair";
            this.lblPair.Size = new System.Drawing.Size(148, 21);
            this.lblPair.TabIndex = 0;
            this.lblPair.Text = "$60000 BTC/USDT";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabControl1.Location = new System.Drawing.Point(12, 39);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1128, 608);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.tabPage4.Controls.Add(this.tabAccounts);
            this.tabPage4.Controls.Add(this.lblUserBalance);
            this.tabPage4.Location = new System.Drawing.Point(4, 30);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1120, 574);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Account";
            // 
            // tabAccounts
            // 
            this.tabAccounts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabAccounts.Controls.Add(this.tabMainAccount);
            this.tabAccounts.Controls.Add(this.tabTradingAccount);
            this.tabAccounts.Controls.Add(this.tabMarginAccount);
            this.tabAccounts.Controls.Add(this.tabPage3);
            this.tabAccounts.Controls.Add(this.tabPage6);
            this.tabAccounts.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabAccounts.Location = new System.Drawing.Point(0, 3);
            this.tabAccounts.Name = "tabAccounts";
            this.tabAccounts.SelectedIndex = 0;
            this.tabAccounts.Size = new System.Drawing.Size(1121, 567);
            this.tabAccounts.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabAccounts.TabIndex = 4;
            // 
            // tabMainAccount
            // 
            this.tabMainAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.tabMainAccount.Controls.Add(this.trvMainAccount);
            this.tabMainAccount.Location = new System.Drawing.Point(4, 30);
            this.tabMainAccount.Name = "tabMainAccount";
            this.tabMainAccount.Padding = new System.Windows.Forms.Padding(3);
            this.tabMainAccount.Size = new System.Drawing.Size(1113, 533);
            this.tabMainAccount.TabIndex = 0;
            this.tabMainAccount.Text = "Main";
            // 
            // trvMainAccount
            // 
            this.trvMainAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.trvMainAccount.ForeColor = System.Drawing.Color.Silver;
            this.trvMainAccount.Location = new System.Drawing.Point(0, 0);
            this.trvMainAccount.Name = "trvMainAccount";
            this.trvMainAccount.Size = new System.Drawing.Size(1113, 537);
            this.trvMainAccount.TabIndex = 1;
            // 
            // tabTradingAccount
            // 
            this.tabTradingAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.tabTradingAccount.Controls.Add(this.trvTradingAccount);
            this.tabTradingAccount.Location = new System.Drawing.Point(4, 30);
            this.tabTradingAccount.Name = "tabTradingAccount";
            this.tabTradingAccount.Padding = new System.Windows.Forms.Padding(3);
            this.tabTradingAccount.Size = new System.Drawing.Size(1113, 533);
            this.tabTradingAccount.TabIndex = 1;
            this.tabTradingAccount.Text = "Trading";
            // 
            // trvTradingAccount
            // 
            this.trvTradingAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.trvTradingAccount.ForeColor = System.Drawing.Color.Silver;
            this.trvTradingAccount.Location = new System.Drawing.Point(0, 0);
            this.trvTradingAccount.Name = "trvTradingAccount";
            this.trvTradingAccount.Size = new System.Drawing.Size(1117, 541);
            this.trvTradingAccount.TabIndex = 2;
            // 
            // tabMarginAccount
            // 
            this.tabMarginAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.tabMarginAccount.Controls.Add(this.trvMarginAccount);
            this.tabMarginAccount.Location = new System.Drawing.Point(4, 30);
            this.tabMarginAccount.Name = "tabMarginAccount";
            this.tabMarginAccount.Padding = new System.Windows.Forms.Padding(3);
            this.tabMarginAccount.Size = new System.Drawing.Size(1113, 533);
            this.tabMarginAccount.TabIndex = 3;
            this.tabMarginAccount.Text = "Margin";
            // 
            // trvMarginAccount
            // 
            this.trvMarginAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.trvMarginAccount.ForeColor = System.Drawing.Color.Silver;
            this.trvMarginAccount.Location = new System.Drawing.Point(0, 0);
            this.trvMarginAccount.Name = "trvMarginAccount";
            this.trvMarginAccount.Size = new System.Drawing.Size(1117, 541);
            this.trvMarginAccount.TabIndex = 2;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.tabPage3.Controls.Add(this.trvPoolAccount);
            this.tabPage3.Location = new System.Drawing.Point(4, 30);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1113, 533);
            this.tabPage3.TabIndex = 5;
            this.tabPage3.Text = "Pool";
            // 
            // trvPoolAccount
            // 
            this.trvPoolAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.trvPoolAccount.ForeColor = System.Drawing.Color.Silver;
            this.trvPoolAccount.Location = new System.Drawing.Point(0, 0);
            this.trvPoolAccount.Name = "trvPoolAccount";
            this.trvPoolAccount.Size = new System.Drawing.Size(1117, 541);
            this.trvPoolAccount.TabIndex = 2;
            // 
            // tabPage6
            // 
            this.tabPage6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.tabPage6.Controls.Add(this.button3);
            this.tabPage6.Controls.Add(this.textBox5);
            this.tabPage6.Controls.Add(this.checkBox2);
            this.tabPage6.Controls.Add(this.button4);
            this.tabPage6.Controls.Add(this.textBox6);
            this.tabPage6.Controls.Add(this.label4);
            this.tabPage6.Controls.Add(this.textBox7);
            this.tabPage6.Controls.Add(this.label5);
            this.tabPage6.Controls.Add(this.textBox8);
            this.tabPage6.Controls.Add(this.label9);
            this.tabPage6.Location = new System.Drawing.Point(4, 30);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(1113, 533);
            this.tabPage6.TabIndex = 6;
            this.tabPage6.Text = "Settings";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Black;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Location = new System.Drawing.Point(981, 35);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(82, 31);
            this.button3.TabIndex = 11;
            this.button3.Text = "Show";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // textBox5
            // 
            this.textBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox5.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBox5.Location = new System.Drawing.Point(2415, 1395);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(380, 21);
            this.textBox5.TabIndex = 10;
            this.textBox5.Text = "C:/User/{User}/repos/source/kucoin_bot/settings.ini";
            // 
            // checkBox2
            // 
            this.checkBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(21, 1401);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(211, 25);
            this.checkBox2.TabIndex = 7;
            this.checkBox2.Text = "Display message on exit";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.BackColor = System.Drawing.Color.Black;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Location = new System.Drawing.Point(2801, 1390);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(116, 31);
            this.button4.TabIndex = 6;
            this.button4.Text = "Save Config";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(683, 38);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(292, 28);
            this.textBox6.TabIndex = 5;
            this.textBox6.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(689, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 21);
            this.label4.TabIndex = 4;
            this.label4.Text = "API Passphrase:";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(313, 37);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(364, 28);
            this.textBox7.TabIndex = 3;
            this.textBox7.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(319, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 21);
            this.label5.TabIndex = 2;
            this.label5.Text = "API Secret:";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(15, 37);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(292, 28);
            this.textBox8.TabIndex = 1;
            this.textBox8.UseSystemPasswordChar = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(21, 19);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 21);
            this.label9.TabIndex = 0;
            this.label9.Text = "API Key:";
            // 
            // lblUserBalance
            // 
            this.lblUserBalance.AutoSize = true;
            this.lblUserBalance.Location = new System.Drawing.Point(20, 13);
            this.lblUserBalance.Name = "lblUserBalance";
            this.lblUserBalance.Size = new System.Drawing.Size(122, 21);
            this.lblUserBalance.TabIndex = 0;
            this.lblUserBalance.Text = "Balance: 0 BTC";
            // 
            // tabPage5
            // 
            this.tabPage5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.tabPage5.Controls.Add(this.btnToggleKeys);
            this.tabPage5.Controls.Add(this.txtSavePath);
            this.tabPage5.Controls.Add(this.chkExtMsg);
            this.tabPage5.Controls.Add(this.btnSaveCfg);
            this.tabPage5.Controls.Add(this.txtPassphrase);
            this.tabPage5.Controls.Add(this.label3);
            this.tabPage5.Controls.Add(this.txtAPISecret);
            this.tabPage5.Controls.Add(this.label2);
            this.tabPage5.Controls.Add(this.txtAPIKey);
            this.tabPage5.Controls.Add(this.lblAPIKey);
            this.tabPage5.Location = new System.Drawing.Point(4, 30);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(1120, 574);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Settings";
            // 
            // btnToggleKeys
            // 
            this.btnToggleKeys.BackColor = System.Drawing.Color.Black;
            this.btnToggleKeys.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnToggleKeys.Location = new System.Drawing.Point(981, 35);
            this.btnToggleKeys.Name = "btnToggleKeys";
            this.btnToggleKeys.Size = new System.Drawing.Size(82, 31);
            this.btnToggleKeys.TabIndex = 11;
            this.btnToggleKeys.Text = "Show";
            this.btnToggleKeys.UseVisualStyleBackColor = false;
            this.btnToggleKeys.Click += new System.EventHandler(this.btnToggleKeys_Click);
            // 
            // txtSavePath
            // 
            this.txtSavePath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSavePath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSavePath.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSavePath.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtSavePath.Location = new System.Drawing.Point(595, 531);
            this.txtSavePath.Name = "txtSavePath";
            this.txtSavePath.ReadOnly = true;
            this.txtSavePath.Size = new System.Drawing.Size(380, 21);
            this.txtSavePath.TabIndex = 10;
            this.txtSavePath.Text = "C:/User/{User}/repos/source/kucoin_bot/settings.ini";
            // 
            // chkExtMsg
            // 
            this.chkExtMsg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chkExtMsg.AutoSize = true;
            this.chkExtMsg.Location = new System.Drawing.Point(15, 537);
            this.chkExtMsg.Name = "chkExtMsg";
            this.chkExtMsg.Size = new System.Drawing.Size(211, 25);
            this.chkExtMsg.TabIndex = 7;
            this.chkExtMsg.Text = "Display message on exit";
            this.chkExtMsg.UseVisualStyleBackColor = true;
            // 
            // btnSaveCfg
            // 
            this.btnSaveCfg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveCfg.BackColor = System.Drawing.Color.Black;
            this.btnSaveCfg.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSaveCfg.Location = new System.Drawing.Point(981, 526);
            this.btnSaveCfg.Name = "btnSaveCfg";
            this.btnSaveCfg.Size = new System.Drawing.Size(116, 31);
            this.btnSaveCfg.TabIndex = 6;
            this.btnSaveCfg.Text = "Save Config";
            this.btnSaveCfg.UseVisualStyleBackColor = false;
            this.btnSaveCfg.Click += new System.EventHandler(this.btnSaveCfg_Click);
            // 
            // txtPassphrase
            // 
            this.txtPassphrase.Location = new System.Drawing.Point(683, 38);
            this.txtPassphrase.Name = "txtPassphrase";
            this.txtPassphrase.Size = new System.Drawing.Size(292, 28);
            this.txtPassphrase.TabIndex = 5;
            this.txtPassphrase.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(683, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "API Passphrase:";
            // 
            // txtAPISecret
            // 
            this.txtAPISecret.Location = new System.Drawing.Point(313, 37);
            this.txtAPISecret.Name = "txtAPISecret";
            this.txtAPISecret.Size = new System.Drawing.Size(364, 28);
            this.txtAPISecret.TabIndex = 3;
            this.txtAPISecret.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(313, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "API Secret:";
            // 
            // txtAPIKey
            // 
            this.txtAPIKey.Location = new System.Drawing.Point(15, 37);
            this.txtAPIKey.Name = "txtAPIKey";
            this.txtAPIKey.Size = new System.Drawing.Size(292, 28);
            this.txtAPIKey.TabIndex = 1;
            this.txtAPIKey.UseSystemPasswordChar = true;
            // 
            // lblAPIKey
            // 
            this.lblAPIKey.AutoSize = true;
            this.lblAPIKey.Location = new System.Drawing.Point(15, 13);
            this.lblAPIKey.Name = "lblAPIKey";
            this.lblAPIKey.Size = new System.Drawing.Size(72, 21);
            this.lblAPIKey.TabIndex = 0;
            this.lblAPIKey.Text = "API Key:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::KuCoinTradeBot.Properties.Resources.icon;
            this.pictureBox1.Location = new System.Drawing.Point(12, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 27);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label1.Location = new System.Drawing.Point(48, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 22);
            this.label1.TabIndex = 5;
            this.label1.Text = "Abyscuit KuCoin Bot";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "ini";
            this.saveFileDialog1.Filter = "Config file|*.ini";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.ClientSize = new System.Drawing.Size(1152, 659);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnFullscreen);
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.btnExit);
            this.ForeColor = System.Drawing.Color.DarkGray;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Abyscuit KuCoin Bot";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabAccounts.ResumeLayout(false);
            this.tabMainAccount.ResumeLayout(false);
            this.tabTradingAccount.ResumeLayout(false);
            this.tabMarginAccount.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage6.ResumeLayout(false);
            this.tabPage6.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnFullscreen;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Label lblAPIKey;
        private System.Windows.Forms.Button btnSaveCfg;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblUserBalance;
        private System.Windows.Forms.CheckBox chkExtMsg;
        private System.Windows.Forms.Label lblPair;
        private System.Windows.Forms.TextBox txtSavePath;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button btnToggleKeys;
        public System.Windows.Forms.TextBox txtAPIKey;
        public System.Windows.Forms.TextBox txtPassphrase;
        public System.Windows.Forms.TextBox txtAPISecret;
        private System.Windows.Forms.TabControl tabAccounts;
        private System.Windows.Forms.TabPage tabMainAccount;
        private System.Windows.Forms.TreeView trvMainAccount;
        private System.Windows.Forms.TabPage tabTradingAccount;
        private System.Windows.Forms.TabPage tabMarginAccount;
        private System.Windows.Forms.TreeView trvTradingAccount;
        private System.Windows.Forms.TreeView trvMarginAccount;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TreeView trvPoolAccount;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Button button4;
        public System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label9;
    }
}

