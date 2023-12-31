﻿using SerialPortHelperLib;
using SMS780E.Storage;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMS780E
{
    public partial class BootForm : Form
    {
        public Daemon daemon;

        public BootForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;

            if (Properties.Settings.Default.IsSavingLoginCfg)
            {
                t_com.Text = Properties.Settings.Default.SavedCom;
                t_br.Text = Properties.Settings.Default.SavedBaud;
                t_data.Text = Properties.Settings.Default.SavedDatabits;
                t_stop.Text = Properties.Settings.Default.SavedStopbits;
                cbSave.Checked = Properties.Settings.Default.IsSavingLoginCfg;
                cbAutoLogin.Checked = Properties.Settings.Default.IsAutoLogin;

                if (Properties.Settings.Default.IsAutoLogin)
                {
                    Login();
                }
            }
        }

        private void btStart_Click(object sender, EventArgs e)
        {
            Login();
        }

        private void Login()
        {
            bool startResult =
    daemon.StartCom(t_com.Text, int.Parse(t_br.Text), int.Parse(t_data.Text), t_stop.Text, out string info);
            if (!startResult)
            {
                MessageBox.Show(info);
            }
            else
            {
                if (cbSave.Checked == true)
                {
                    Properties.Settings.Default.SavedCom = t_com.Text;
                    Properties.Settings.Default.SavedBaud = t_br.Text;
                    Properties.Settings.Default.SavedDatabits = t_data.Text;
                    Properties.Settings.Default.SavedStopbits = t_stop.Text;
                    Properties.Settings.Default.IsSavingLoginCfg = true;

                    if (cbAutoLogin.Checked == true)
                    {
                        Properties.Settings.Default.IsAutoLogin = true;
                    }
                    else
                    {
                        Properties.Settings.Default.IsAutoLogin = false;
                    }

                    Properties.Settings.Default.Save();
                }
                else
                {
                    Properties.Settings.Default.IsSavingLoginCfg = false;
                    Properties.Settings.Default.IsAutoLogin = false;

                    Properties.Settings.Default.Save();
                }

                daemon.NewDesktopForm();
                daemon.ShowDesktopForm();

                this.Close();
            }
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            daemon.DirectExit();
        }

        private void BootForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            daemon.DirectExit();
        }

        private void cbAutoLogin_CheckedChanged(object sender, EventArgs e)
        {
            if (cbAutoLogin.Checked == true)
            {
                cbSave.Checked = true;
            }
        }
    }
}
