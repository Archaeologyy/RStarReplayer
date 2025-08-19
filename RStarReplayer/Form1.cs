using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace RStarReplayer
{
    public partial class Form1 : Form
    {
        private const string RuleName = "RStarReplayer";
        private const string RuleCommand = "advfirewall firewall add rule name=\"RStarReplayer\" dir=out action=block remoteip=192.81.241.171";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (FirewallRuleExists(RuleName))
            {
                WhatModeLabel.Text = "No Saving: ON";
                WhatModeLabel.ForeColor = Color.Green;
            }
            else
            {
                WhatModeLabel.Text = "No Saving: OFF";
                WhatModeLabel.ForeColor = Color.Red;
            }

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DeleteFirewallRule(RuleName);
        }

        private void SavingON_Click(object sender, EventArgs e)
        {
            RunNetsh(RuleCommand);
            WhatModeLabel.Text = "No Saving: ON";
            WhatModeLabel.ForeColor = Color.Green;
        }

        private void SavingOFF_Click(object sender, EventArgs e)
        {
            DeleteFirewallRule(RuleName);
            WhatModeLabel.Text = "No Saving: OFF";
            WhatModeLabel.ForeColor = Color.Red;
        }

        private void CheckRuleButton_Click(object sender, EventArgs e)
        {
            try
            {
                ProcessStartInfo psi = new ProcessStartInfo
                {
                    FileName = "cmd.exe",
                    Arguments = "/k netsh advfirewall firewall show rule name=\"RStarReplayer\"",
                    UseShellExecute = true,
                    Verb = "runas"
                };

                Process.Start(psi);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to open Command Prompt, run as administrator?: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private bool FirewallRuleExists(string ruleName)
        {
            try
            {
                ProcessStartInfo psi = new ProcessStartInfo
                {
                    FileName = @"C:\Windows\System32\netsh.exe",
                    Arguments = $"advfirewall firewall show rule name=\"{ruleName}\"",
                    RedirectStandardOutput = true,
                    UseShellExecute = false,
                    CreateNoWindow = true
                };

                using (Process process = Process.Start(psi))
                {
                    string output = process.StandardOutput.ReadToEnd();
                    process.WaitForExit();

                    return output.IndexOf(ruleName, StringComparison.OrdinalIgnoreCase) >= 0;
                }
            }
            catch
            {
                return false;
            }
        }

        private void DeleteFirewallRule(string ruleName)
        {
            RunNetsh($"advfirewall firewall delete rule name=\"{ruleName}\"");
        }

        private void RunNetsh(string args)
        {
            try
            {
                ProcessStartInfo psi = new ProcessStartInfo
                {
                    FileName = @"C:\Windows\System32\netsh.exe",
                    Arguments = args,
                    UseShellExecute = false,
                    CreateNoWindow = true
                };

                using (Process process = Process.Start(psi))
                {
                    process.WaitForExit();
                }
            }
            catch
            {
                
            }
        }
    }
}
