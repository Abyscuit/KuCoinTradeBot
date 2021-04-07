using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CryptoExchange.Net.Objects;
using Kucoin.Net;
using Kucoin.Net.Objects;

namespace KuCoinTradeBot
{
    public partial class Form1 : Form
    {
        public static string CONFIG_SAVE_PATH = "";
        public static Config config = new Config();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (ExitMessage())
            {
                if (MessageBox.Show("Are you sure you want to close the application?", "Close Program", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    this.Close();
            }
            else Close();
        }
        // Dragging form function
        static int[] mousePos = { 0,0 };
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            
        }

        private void btnFullscreen_Click(object sender, EventArgs e)
        {
            if (WindowState!= FormWindowState.Maximized) this.WindowState = FormWindowState.Maximized;
            else this.WindowState = FormWindowState.Normal;
            //MinimumSize = Size;
            //MaximumSize = Size;
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            if (WindowState != FormWindowState.Minimized) this.WindowState = FormWindowState.Minimized;
            else this.WindowState = FormWindowState.Normal;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            config.LoadConfig();
            UpdateSettings();
            CONFIG_SAVE_PATH = Directory.GetCurrentDirectory() + "\\Settings.ini";
            txtSavePath.Text = CONFIG_SAVE_PATH;

            KucoinClient client = new KucoinClient(new KucoinClientOptions()
            {
                ApiCredentials = new KucoinApiCredentials(config.KUCOIN_APIKEY, config.KUCOIN_APISECRET, config.KUCOIN_APIPASSPHRASE)
            });
            var result = client.GetAccounts();
            if (result.Success)
            {
                List<KucoinAccount> kList = result.Data.ToList<KucoinAccount>();
                for (int i = 0; i < kList.Count; i++)
                {
                    if (kList[i].Type == KucoinAccountType.Main)
                    {
                        TreeNode nAvail = new TreeNode($"Available: {kList[i].Available} {kList[i].Currency}");
                        TreeNode nLocked = new TreeNode($"Locked: {kList[i].Holds} {kList[i].Currency}");
                        TreeNode nRoot = new TreeNode($"{kList[i].Currency} - {kList[i].Balance}", new TreeNode[] { nAvail, nLocked });
                        trvMainAccount.Nodes.Add(nRoot);
                    }
                    else if (kList[i].Type == KucoinAccountType.Trade)
                    {
                        TreeNode nAvail = new TreeNode($"Available: {kList[i].Available} {kList[i].Currency}");
                        TreeNode nLocked = new TreeNode($"Locked: {kList[i].Holds} {kList[i].Currency}");
                        TreeNode nRoot = new TreeNode($"{kList[i].Currency} - {kList[i].Balance}", new TreeNode[] { nAvail, nLocked });
                        trvTradingAccount.Nodes.Add(nRoot);
                    }
                    else if (kList[i].Type == KucoinAccountType.Margin)
                    {
                        TreeNode nAvail = new TreeNode($"Available: {kList[i].Available} {kList[i].Currency}");
                        TreeNode nLocked = new TreeNode($"Locked: {kList[i].Holds} {kList[i].Currency}");
                        TreeNode nRoot = new TreeNode($"{kList[i].Currency} - {kList[i].Balance}", new TreeNode[] { nAvail, nLocked });
                        trvMarginAccount.Nodes.Add(nRoot);
                    }
                    else if (kList[i].Type == KucoinAccountType.Pool)
                    {
                        TreeNode nAvail = new TreeNode($"Available: {kList[i].Available} {kList[i].Currency}");
                        TreeNode nLocked = new TreeNode($"Locked: {kList[i].Holds} {kList[i].Currency}");
                        TreeNode nRoot = new TreeNode($"{kList[i].Currency} - {kList[i].Balance}", new TreeNode[] { nAvail, nLocked });
                        trvPoolAccount.Nodes.Add(nRoot);
                    }
                }
            }
        }

        public void UpdateSettings()
        {
            txtAPIKey.Text = config.KUCOIN_APIKEY;
            txtAPISecret.Text = config.KUCOIN_APISECRET;
            txtPassphrase.Text = config.KUCOIN_APIPASSPHRASE;
            chkExtMsg.Checked = config.EXIT_MESSAGE;
        }

        private void btnSaveCfg_Click(object sender, EventArgs e)
        {
            Config.SaveConfig();
            MessageBox.Show("Configuration file saved", "Save Successful");
        }

        private bool ExitMessage()
        {
            if (chkExtMsg.Checked) return true;
            return false;
        }

        private void btnChangeSavePath_Click(object sender, EventArgs e)
        {
            saveFileDialog1.DefaultExt = "ini";
            if(saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtSavePath.Text = saveFileDialog1.FileName;
            }
        }

        private void btnToggleKeys_Click(object sender, EventArgs e)
        {
            txtAPIKey.UseSystemPasswordChar = !txtAPIKey.UseSystemPasswordChar;
            txtAPISecret.UseSystemPasswordChar = !txtAPISecret.UseSystemPasswordChar;
            txtPassphrase.UseSystemPasswordChar = !txtPassphrase.UseSystemPasswordChar;
            if (txtPassphrase.UseSystemPasswordChar) btnToggleKeys.Text = "Show";
            else btnToggleKeys.Text = "Hide";
        }
    }
}
