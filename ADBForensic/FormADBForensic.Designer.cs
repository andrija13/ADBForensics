
namespace ADBForensic
{
    partial class FormADBForensic
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormADBForensic));
            this.btnSearchDevices = new System.Windows.Forms.Button();
            this.lblHeading = new System.Windows.Forms.Label();
            this.txtBoxOutput = new System.Windows.Forms.TextBox();
            this.lblOutput = new System.Windows.Forms.Label();
            this.lbxAvailableDevices = new System.Windows.Forms.ListBox();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.btnExportCalls = new System.Windows.Forms.Button();
            this.btnScreenshot = new System.Windows.Forms.Button();
            this.btnExportContacts = new System.Windows.Forms.Button();
            this.btnExportSDCard = new System.Windows.Forms.Button();
            this.btnShowDeviceInfo = new System.Windows.Forms.Button();
            this.btnScreenrecord = new System.Windows.Forms.Button();
            this.numMaxLength = new System.Windows.Forms.NumericUpDown();
            this.lblMaxLength = new System.Windows.Forms.Label();
            this.gBoxScreenrecord = new System.Windows.Forms.GroupBox();
            this.lblHeight = new System.Windows.Forms.Label();
            this.lblWidth = new System.Windows.Forms.Label();
            this.numHeightSize = new System.Windows.Forms.NumericUpDown();
            this.numWidthSize = new System.Windows.Forms.NumericUpDown();
            this.lblVideoSize = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxLength)).BeginInit();
            this.gBoxScreenrecord.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numHeightSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWidthSize)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSearchDevices
            // 
            this.btnSearchDevices.Location = new System.Drawing.Point(12, 70);
            this.btnSearchDevices.Name = "btnSearchDevices";
            this.btnSearchDevices.Size = new System.Drawing.Size(92, 38);
            this.btnSearchDevices.TabIndex = 0;
            this.btnSearchDevices.Text = "Search devices";
            this.btnSearchDevices.UseVisualStyleBackColor = true;
            this.btnSearchDevices.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.Font = new System.Drawing.Font("Poppins SemiBold", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.Location = new System.Drawing.Point(146, 9);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(175, 39);
            this.lblHeading.TabIndex = 1;
            this.lblHeading.Text = "ADB Forensics";
            // 
            // txtBoxOutput
            // 
            this.txtBoxOutput.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.txtBoxOutput.ForeColor = System.Drawing.SystemColors.Window;
            this.txtBoxOutput.Location = new System.Drawing.Point(12, 233);
            this.txtBoxOutput.Multiline = true;
            this.txtBoxOutput.Name = "txtBoxOutput";
            this.txtBoxOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBoxOutput.Size = new System.Drawing.Size(443, 134);
            this.txtBoxOutput.TabIndex = 2;
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Location = new System.Drawing.Point(12, 217);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(42, 13);
            this.lblOutput.TabIndex = 3;
            this.lblOutput.Text = "Output:";
            // 
            // lbxAvailableDevices
            // 
            this.lbxAvailableDevices.FormattingEnabled = true;
            this.lbxAvailableDevices.Location = new System.Drawing.Point(12, 114);
            this.lbxAvailableDevices.Name = "lbxAvailableDevices";
            this.lbxAvailableDevices.Size = new System.Drawing.Size(190, 82);
            this.lbxAvailableDevices.TabIndex = 4;
            // 
            // folderBrowserDialog
            // 
            this.folderBrowserDialog.Description = "Please select directory where you want save the files.";
            // 
            // btnExportCalls
            // 
            this.btnExportCalls.Location = new System.Drawing.Point(208, 114);
            this.btnExportCalls.Name = "btnExportCalls";
            this.btnExportCalls.Size = new System.Drawing.Size(97, 24);
            this.btnExportCalls.TabIndex = 5;
            this.btnExportCalls.Text = "Export calls";
            this.btnExportCalls.UseVisualStyleBackColor = true;
            this.btnExportCalls.Click += new System.EventHandler(this.btnExportCalls_Click);
            // 
            // btnScreenshot
            // 
            this.btnScreenshot.Location = new System.Drawing.Point(208, 70);
            this.btnScreenshot.Name = "btnScreenshot";
            this.btnScreenshot.Size = new System.Drawing.Size(97, 35);
            this.btnScreenshot.TabIndex = 7;
            this.btnScreenshot.Text = "Take a screenshot";
            this.btnScreenshot.UseVisualStyleBackColor = true;
            this.btnScreenshot.Click += new System.EventHandler(this.btnScreenshot_Click);
            // 
            // btnExportContacts
            // 
            this.btnExportContacts.Location = new System.Drawing.Point(208, 144);
            this.btnExportContacts.Name = "btnExportContacts";
            this.btnExportContacts.Size = new System.Drawing.Size(97, 24);
            this.btnExportContacts.TabIndex = 8;
            this.btnExportContacts.Text = "Export contacts";
            this.btnExportContacts.UseVisualStyleBackColor = true;
            this.btnExportContacts.Click += new System.EventHandler(this.btnExportContacts_Click);
            // 
            // btnExportSDCard
            // 
            this.btnExportSDCard.Location = new System.Drawing.Point(208, 174);
            this.btnExportSDCard.Name = "btnExportSDCard";
            this.btnExportSDCard.Size = new System.Drawing.Size(97, 22);
            this.btnExportSDCard.TabIndex = 9;
            this.btnExportSDCard.Text = "Export SD card";
            this.btnExportSDCard.UseVisualStyleBackColor = true;
            this.btnExportSDCard.Click += new System.EventHandler(this.btnExportSDCard_Click);
            // 
            // btnShowDeviceInfo
            // 
            this.btnShowDeviceInfo.Location = new System.Drawing.Point(110, 70);
            this.btnShowDeviceInfo.Name = "btnShowDeviceInfo";
            this.btnShowDeviceInfo.Size = new System.Drawing.Size(92, 38);
            this.btnShowDeviceInfo.TabIndex = 11;
            this.btnShowDeviceInfo.Text = "Show device info";
            this.btnShowDeviceInfo.UseVisualStyleBackColor = true;
            this.btnShowDeviceInfo.Click += new System.EventHandler(this.btnShowDeviceInfo_Click);
            // 
            // btnScreenrecord
            // 
            this.btnScreenrecord.BackColor = System.Drawing.Color.White;
            this.btnScreenrecord.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnScreenrecord.Location = new System.Drawing.Point(9, 102);
            this.btnScreenrecord.Name = "btnScreenrecord";
            this.btnScreenrecord.Size = new System.Drawing.Size(122, 24);
            this.btnScreenrecord.TabIndex = 12;
            this.btnScreenrecord.Text = "Start recording 🔴";
            this.btnScreenrecord.UseVisualStyleBackColor = false;
            this.btnScreenrecord.Click += new System.EventHandler(this.btnScreenrecord_Click);
            // 
            // numMaxLength
            // 
            this.numMaxLength.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numMaxLength.Location = new System.Drawing.Point(84, 74);
            this.numMaxLength.Maximum = new decimal(new int[] {
            180,
            0,
            0,
            0});
            this.numMaxLength.Name = "numMaxLength";
            this.numMaxLength.Size = new System.Drawing.Size(47, 20);
            this.numMaxLength.TabIndex = 13;
            this.numMaxLength.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // lblMaxLength
            // 
            this.lblMaxLength.AutoSize = true;
            this.lblMaxLength.Location = new System.Drawing.Point(6, 71);
            this.lblMaxLength.Name = "lblMaxLength";
            this.lblMaxLength.Size = new System.Drawing.Size(74, 26);
            this.lblMaxLength.TabIndex = 14;
            this.lblMaxLength.Text = "Max recording\r\n time in s:\r\n";
            this.lblMaxLength.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gBoxScreenrecord
            // 
            this.gBoxScreenrecord.Controls.Add(this.lblHeight);
            this.gBoxScreenrecord.Controls.Add(this.lblWidth);
            this.gBoxScreenrecord.Controls.Add(this.numHeightSize);
            this.gBoxScreenrecord.Controls.Add(this.numWidthSize);
            this.gBoxScreenrecord.Controls.Add(this.lblVideoSize);
            this.gBoxScreenrecord.Controls.Add(this.lblMaxLength);
            this.gBoxScreenrecord.Controls.Add(this.btnScreenrecord);
            this.gBoxScreenrecord.Controls.Add(this.numMaxLength);
            this.gBoxScreenrecord.Location = new System.Drawing.Point(311, 70);
            this.gBoxScreenrecord.Name = "gBoxScreenrecord";
            this.gBoxScreenrecord.Size = new System.Drawing.Size(144, 135);
            this.gBoxScreenrecord.TabIndex = 15;
            this.gBoxScreenrecord.TabStop = false;
            this.gBoxScreenrecord.Text = "Record a video";
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.Location = new System.Drawing.Point(41, 44);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(39, 13);
            this.lblHeight.TabIndex = 19;
            this.lblHeight.Text = "height:";
            // 
            // lblWidth
            // 
            this.lblWidth.AutoSize = true;
            this.lblWidth.Location = new System.Drawing.Point(47, 23);
            this.lblWidth.Name = "lblWidth";
            this.lblWidth.Size = new System.Drawing.Size(35, 13);
            this.lblWidth.TabIndex = 18;
            this.lblWidth.Text = "width:";
            // 
            // numHeightSize
            // 
            this.numHeightSize.Increment = new decimal(new int[] {
            80,
            0,
            0,
            0});
            this.numHeightSize.Location = new System.Drawing.Point(84, 39);
            this.numHeightSize.Maximum = new decimal(new int[] {
            1280,
            0,
            0,
            0});
            this.numHeightSize.Minimum = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.numHeightSize.Name = "numHeightSize";
            this.numHeightSize.Size = new System.Drawing.Size(47, 20);
            this.numHeightSize.TabIndex = 17;
            this.numHeightSize.Value = new decimal(new int[] {
            1280,
            0,
            0,
            0});
            // 
            // numWidthSize
            // 
            this.numWidthSize.Increment = new decimal(new int[] {
            80,
            0,
            0,
            0});
            this.numWidthSize.Location = new System.Drawing.Point(84, 18);
            this.numWidthSize.Maximum = new decimal(new int[] {
            720,
            0,
            0,
            0});
            this.numWidthSize.Minimum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.numWidthSize.Name = "numWidthSize";
            this.numWidthSize.Size = new System.Drawing.Size(47, 20);
            this.numWidthSize.TabIndex = 16;
            this.numWidthSize.Value = new decimal(new int[] {
            720,
            0,
            0,
            0});
            // 
            // lblVideoSize
            // 
            this.lblVideoSize.AutoSize = true;
            this.lblVideoSize.Location = new System.Drawing.Point(8, 27);
            this.lblVideoSize.Name = "lblVideoSize";
            this.lblVideoSize.Size = new System.Drawing.Size(34, 26);
            this.lblVideoSize.TabIndex = 15;
            this.lblVideoSize.Text = "Video\r\nsize";
            this.lblVideoSize.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormADBForensic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 379);
            this.Controls.Add(this.gBoxScreenrecord);
            this.Controls.Add(this.btnShowDeviceInfo);
            this.Controls.Add(this.btnExportSDCard);
            this.Controls.Add(this.btnScreenshot);
            this.Controls.Add(this.btnExportContacts);
            this.Controls.Add(this.btnExportCalls);
            this.Controls.Add(this.lbxAvailableDevices);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.txtBoxOutput);
            this.Controls.Add(this.lblHeading);
            this.Controls.Add(this.btnSearchDevices);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormADBForensic";
            this.Text = " ADB Forensics";
            this.TransparencyKey = System.Drawing.Color.Crimson;
            ((System.ComponentModel.ISupportInitialize)(this.numMaxLength)).EndInit();
            this.gBoxScreenrecord.ResumeLayout(false);
            this.gBoxScreenrecord.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numHeightSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWidthSize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSearchDevices;
        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.TextBox txtBoxOutput;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.ListBox lbxAvailableDevices;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.Button btnExportCalls;
        private System.Windows.Forms.Button btnScreenshot;
        private System.Windows.Forms.Button btnExportContacts;
        private System.Windows.Forms.Button btnExportSDCard;
        private System.Windows.Forms.Button btnShowDeviceInfo;
        private System.Windows.Forms.Button btnScreenrecord;
        private System.Windows.Forms.NumericUpDown numMaxLength;
        private System.Windows.Forms.Label lblMaxLength;
        private System.Windows.Forms.GroupBox gBoxScreenrecord;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.Label lblWidth;
        private System.Windows.Forms.NumericUpDown numHeightSize;
        private System.Windows.Forms.NumericUpDown numWidthSize;
        private System.Windows.Forms.Label lblVideoSize;
    }
}

