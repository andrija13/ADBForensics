using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Text.RegularExpressions;
using System.Runtime.CompilerServices;
using System.Threading;

namespace ADBForensic
{
    public partial class FormADBForensic : Form
    {
        private readonly Process process = new Process();

        private readonly ProcessStartInfo info = new ProcessStartInfo();

        public FormADBForensic()
        {
            InitializeComponent();

            info.WindowStyle = ProcessWindowStyle.Hidden;
            info.CreateNoWindow = true;
            info.UseShellExecute = false;
            info.RedirectStandardOutput = true;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                info.FileName = "adb.exe";
                info.Arguments = "devices";
                process.StartInfo = info;

                process.Start();

                lbxAvailableDevices.Items.Clear();

                txtBoxOutput.Text = process.StandardOutput.ReadToEnd();
                var listOfDevices = Regex.Split(txtBoxOutput.Text.Trim(), "\r\n|\r|\n").ToList();

                if (listOfDevices.Count < 2)
                {
                    throw new Exception("Devices not found");
                }

                listOfDevices.RemoveAt(0);

                ListBox mylist = new ListBox();
                listOfDevices.ForEach(x => lbxAvailableDevices.Items.Add(x));
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnShowDeviceInfo_Click(object sender, EventArgs e)
        {
            try
            {
                var selectedDevice = lbxAvailableDevices.SelectedItem?.ToString();

                if (string.IsNullOrEmpty(selectedDevice))
                {
                    throw new Exception("Please select device");
                }

                var indexOfEndChar = selectedDevice.IndexOf('\t');
                var deviceModel = selectedDevice.Substring(0, indexOfEndChar);
                txtBoxOutput.Text = string.Empty;

                info.FileName = "adb.exe";

                info.Arguments = "-s " + deviceModel + " shell getprop ro.product.brand";
                process.StartInfo = info;

                process.Start();
                txtBoxOutput.Text += "\n Brand: " + process.StandardOutput.ReadToEnd();

                info.Arguments = "-s " + deviceModel + " shell getprop ro.product.model";
                process.Start();
                txtBoxOutput.Text += "\n Model: " + process.StandardOutput.ReadToEnd();

                info.Arguments = "-s " + deviceModel + " shell getprop ro.serialno";
                process.Start();
                txtBoxOutput.Text += "\n Serial Number: " + process.StandardOutput.ReadToEnd();

                info.Arguments = "-s " + deviceModel + " shell getprop ro.build.version.release";
                process.Start();
                txtBoxOutput.Text += "\n Android Version: " + process.StandardOutput.ReadToEnd();

                info.Arguments = "-s " + deviceModel + " shell getprop persist.sys.timezone";
                process.Start();
                txtBoxOutput.Text += "\n Time Zone: " + process.StandardOutput.ReadToEnd();

                info.Arguments = "-s " + deviceModel + " shell cat /sys/class/power_supply/battery/status";
                process.Start();
                txtBoxOutput.Text += "\n Battery Status: " + process.StandardOutput.ReadToEnd();

                info.Arguments = "-s " + deviceModel + " shell cat /sys/class/power_supply/battery/capacity";
                process.Start();
                txtBoxOutput.Text += "\n Battery Level (%): " + process.StandardOutput.ReadToEnd();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnExportCalls_Click(object sender, EventArgs e)
        {
            try
            {
                ExportFile("/data/data/com.android.providers.contacts/databases/calllog.db");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnExportContacts_Click(object sender, EventArgs e)
        {
            try
            {
                ExportFile("/data/data/com.android.providers.telephony/databses/contacts2.db");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnExportSDCard_Click(object sender, EventArgs e)
        {
            try
            {
                ExportFile("/sdcard/");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnScreenshot_Click(object sender, EventArgs e)
        {
            try
            {
                var selectedDevice = lbxAvailableDevices.SelectedItem?.ToString();

                if (string.IsNullOrEmpty(selectedDevice))
                {
                    throw new Exception("Please select device");
                }

                var exportPath = string.Empty;

                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    exportPath = folderBrowserDialog.SelectedPath;
                }
                else
                {
                    return;
                }

                var indexOfEndChar = selectedDevice.IndexOf('\t');
                var deviceModel = selectedDevice.Substring(0, indexOfEndChar);

                var photoName = DateTime.Now.Ticks.ToString() + ".png";

                info.FileName = "adb.exe";
                info.Arguments = "-s " + deviceModel + " shell screencap -p /sdcard/" + photoName;
                process.StartInfo = info;

                process.Start();

                txtBoxOutput.Text = string.Empty;
                txtBoxOutput.Text += process.StandardOutput.ReadToEnd();

                if (!string.IsNullOrEmpty(txtBoxOutput.Text))
                {
                    throw new Exception(txtBoxOutput.Text);
                }

                info.Arguments = "-s " + deviceModel + " pull /sdcard/" + photoName + " " + exportPath;
                process.StartInfo = info;
                process.Start();

                txtBoxOutput.Text += process.StandardOutput.ReadToEnd();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ExportFile(string path)
        {
            var selectedDevice = lbxAvailableDevices.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(selectedDevice))
            {
                throw new Exception("Please select device");
            }

            var exportPath = string.Empty;

            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                exportPath = folderBrowserDialog.SelectedPath;
            }
            else
            {
                return;
            }

            var indexOfEndChar = selectedDevice.IndexOf('\t');
            var deviceModel = selectedDevice.Substring(0, indexOfEndChar);

            info.FileName = "adb.exe";
            info.Arguments = "-s " + deviceModel + " pull " + path + " " + exportPath;
            process.StartInfo = info;

            process.Start();

            txtBoxOutput.Text = string.Empty;
            txtBoxOutput.Text += process.StandardOutput.ReadToEnd();
        }

        private void btnScreenrecord_Click(object sender, EventArgs e)
        {
            try
            {
                var selectedDevice = lbxAvailableDevices.SelectedItem?.ToString();

                if (string.IsNullOrEmpty(selectedDevice))
                {
                    throw new Exception("Please select device");
                }

                var exportPath = string.Empty;

                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    exportPath = folderBrowserDialog.SelectedPath;
                }
                else 
                {
                    return;
                }

                var indexOfEndChar = selectedDevice.IndexOf('\t');
                var deviceModel = selectedDevice.Substring(0, indexOfEndChar);

                var size = numWidthSize.Value.ToString() + "x" + numHeightSize.Value.ToString();
                var timeLimit = numMaxLength.Value.ToString();
                var videoName = DateTime.Now.Ticks.ToString() + ".mp4";

                info.FileName = "adb.exe";
                info.Arguments = "-s " + deviceModel + " shell screenrecord"
                               + " --size " + size
                               + " --time-limit " + timeLimit
                               + " /sdcard/" + videoName;

                process.StartInfo = info;

                // Start recording
                btnScreenrecord.Text = "Recording";
                btnScreenrecord.BackColor = Color.Red;
                btnScreenrecord.Enabled = false;
                numMaxLength.Enabled = false;
                numHeightSize.Enabled = false;
                numWidthSize.Enabled = false;

                process.Start();
                txtBoxOutput.Text += process.StandardOutput.ReadToEnd();

                // End recording
                btnScreenrecord.Text = "Start recording";
                btnScreenrecord.BackColor = Color.White;
                btnScreenrecord.Enabled = true;
                numMaxLength.Enabled = true;
                numHeightSize.Enabled = true;
                numWidthSize.Enabled = true;

                // Pull screenrecord
                info.Arguments = "-s " + deviceModel + " pull /sdcard/" + videoName + " " + exportPath;
                process.StartInfo = info;

                process.Start();
                txtBoxOutput.Text += process.StandardOutput.ReadToEnd();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                btnScreenrecord.Text = "Start recording";
                btnScreenrecord.BackColor = Color.White;
                btnScreenrecord.Enabled = true;
                numMaxLength.Enabled = true;
                numHeightSize.Enabled = true;
                numWidthSize.Enabled = true;
            }
        }
    }
}