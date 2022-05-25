using System.Diagnostics;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;

namespace KeyAuth
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void siticoneControlBox1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }


        private void Main_Load(object sender, EventArgs e)
        {
            Login.KeyAuthApp.check();
            version.Text = "";

        }


        public DateTime UnixTimeToDateTime(long unixtime)
        {
            System.DateTime dtDateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Local);
            dtDateTime = dtDateTime.AddSeconds(unixtime).ToLocalTime();
            return dtDateTime;
        }

        private void subscriptionDaysLabel_Click(object sender, EventArgs e)
        {

        }

        private void expiry_Click(object sender, EventArgs e)
        {

        }


        private void siticoneControlBox2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void key_Click(object sender, EventArgs e)
        {

        }

        private void AysmowButton2Button5_Click(object sender, EventArgs e)
        {
        }

        private void AysmowButton2Button7_Click(object sender, EventArgs e)
        {
        }

        private void AysmowButton_Click(object sender, EventArgs e)
        {
        }


        
