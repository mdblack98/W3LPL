﻿namespace DXClusterUtil
{
    partial class Form1
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
                if (clusterClient != null) clusterClient.Dispose();
                if (tooltip != null) tooltip.Dispose();
                if (qrz != null) qrz.Dispose();
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.buttonStart = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.labelQDepth = new System.Windows.Forms.Label();
            this.textBoxClusterServer = new System.Windows.Forms.TextBox();
            this.textBoxCallsign = new System.Windows.Forms.TextBox();
            this.labelStatusQServer = new System.Windows.Forms.Label();
            this.textBoxPortLocal = new System.Windows.Forms.TextBox();
            this.checkedListBoxNewSpotters = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonBackup = new System.Windows.Forms.Button();
            this.buttonCopy = new System.Windows.Forms.Button();
            this.checkBoxCached = new System.Windows.Forms.CheckBox();
            this.checkBoxFiltered = new System.Windows.Forms.CheckBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.labelQRZCache = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.labelClusterCache = new System.Windows.Forms.Label();
            this.numericUpDownRTTYOffset = new System.Windows.Forms.NumericUpDown();
            this.listBoxIgnore = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxTimeForDump = new System.Windows.Forms.ComboBox();
            this.checkedListBoxReviewedSpotters = new DXClusterUtil.ColorCodedCheckedListBox();
            this.form1BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.form1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.form1BindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRTTYOffset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.form1BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.form1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.form1BindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(13, 13);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(75, 23);
            this.buttonStart.TabIndex = 0;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.ButtonStart_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // labelQDepth
            // 
            this.labelQDepth.AutoSize = true;
            this.labelQDepth.Location = new System.Drawing.Point(173, 44);
            this.labelQDepth.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelQDepth.Name = "labelQDepth";
            this.labelQDepth.Size = new System.Drawing.Size(0, 13);
            this.labelQDepth.TabIndex = 6;
            this.labelQDepth.Click += new System.EventHandler(this.LabelQDepth_Click);
            // 
            // textBoxClusterServer
            // 
            this.textBoxClusterServer.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::DXClusterUtil.Properties.Settings.Default, "ClusterServer", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBoxClusterServer.Location = new System.Drawing.Point(226, 15);
            this.textBoxClusterServer.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxClusterServer.Name = "textBoxClusterServer";
            this.textBoxClusterServer.Size = new System.Drawing.Size(108, 20);
            this.textBoxClusterServer.TabIndex = 3;
            this.textBoxClusterServer.Text = global::DXClusterUtil.Properties.Settings.Default.ClusterServer;
            this.textBoxClusterServer.TextChanged += new System.EventHandler(this.TextBoxClusterServer_TextChanged);
            this.textBoxClusterServer.Leave += new System.EventHandler(this.TextBoxCluster_Leave);
            // 
            // textBoxCallsign
            // 
            this.textBoxCallsign.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxCallsign.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::DXClusterUtil.Properties.Settings.Default, "Callsign", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBoxCallsign.Location = new System.Drawing.Point(100, 15);
            this.textBoxCallsign.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxCallsign.Name = "textBoxCallsign";
            this.textBoxCallsign.Size = new System.Drawing.Size(59, 20);
            this.textBoxCallsign.TabIndex = 1;
            this.textBoxCallsign.Text = global::DXClusterUtil.Properties.Settings.Default.Callsign;
            // 
            // labelStatusQServer
            // 
            this.labelStatusQServer.AutoSize = true;
            this.labelStatusQServer.Location = new System.Drawing.Point(77, 44);
            this.labelStatusQServer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelStatusQServer.Name = "labelStatusQServer";
            this.labelStatusQServer.Size = new System.Drawing.Size(33, 13);
            this.labelStatusQServer.TabIndex = 8;
            this.labelStatusQServer.Text = "Client";
            // 
            // textBoxPortLocal
            // 
            this.textBoxPortLocal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxPortLocal.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::DXClusterUtil.Properties.Settings.Default, "PortLocal", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBoxPortLocal.Location = new System.Drawing.Point(13, 41);
            this.textBoxPortLocal.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxPortLocal.Name = "textBoxPortLocal";
            this.textBoxPortLocal.Size = new System.Drawing.Size(54, 20);
            this.textBoxPortLocal.TabIndex = 4;
            this.textBoxPortLocal.Text = global::DXClusterUtil.Properties.Settings.Default.PortLocal;
            // 
            // checkedListBoxNewSpotters
            // 
            this.checkedListBoxNewSpotters.CheckOnClick = true;
            this.checkedListBoxNewSpotters.FormattingEnabled = true;
            this.checkedListBoxNewSpotters.Location = new System.Drawing.Point(431, 17);
            this.checkedListBoxNewSpotters.Margin = new System.Windows.Forms.Padding(2);
            this.checkedListBoxNewSpotters.Name = "checkedListBoxNewSpotters";
            this.checkedListBoxNewSpotters.Size = new System.Drawing.Size(104, 94);
            this.checkedListBoxNewSpotters.TabIndex = 12;
            this.checkedListBoxNewSpotters.SelectedIndexChanged += new System.EventHandler(this.CheckedListBoxNewSpotters_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(447, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "New Spotters";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(549, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Reviewed Spotters";
            // 
            // buttonBackup
            // 
            this.buttonBackup.Location = new System.Drawing.Point(13, 65);
            this.buttonBackup.Margin = new System.Windows.Forms.Padding(2);
            this.buttonBackup.Name = "buttonBackup";
            this.buttonBackup.Size = new System.Drawing.Size(75, 23);
            this.buttonBackup.TabIndex = 6;
            this.buttonBackup.Text = "Backup";
            this.buttonBackup.UseVisualStyleBackColor = true;
            this.buttonBackup.Click += new System.EventHandler(this.ButtonBackup_Click);
            // 
            // buttonCopy
            // 
            this.buttonCopy.Location = new System.Drawing.Point(100, 65);
            this.buttonCopy.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCopy.Name = "buttonCopy";
            this.buttonCopy.Size = new System.Drawing.Size(75, 23);
            this.buttonCopy.TabIndex = 7;
            this.buttonCopy.Text = "Copy Log";
            this.buttonCopy.UseVisualStyleBackColor = true;
            this.buttonCopy.Click += new System.EventHandler(this.Button1_Click);
            // 
            // checkBoxCached
            // 
            this.checkBoxCached.AutoSize = true;
            this.checkBoxCached.Location = new System.Drawing.Point(192, 70);
            this.checkBoxCached.Name = "checkBoxCached";
            this.checkBoxCached.Size = new System.Drawing.Size(63, 17);
            this.checkBoxCached.TabIndex = 8;
            this.checkBoxCached.Text = "Cached";
            this.checkBoxCached.UseVisualStyleBackColor = true;
            this.checkBoxCached.CheckedChanged += new System.EventHandler(this.CheckBoxCached_CheckedChanged);
            // 
            // checkBoxFiltered
            // 
            this.checkBoxFiltered.AutoSize = true;
            this.checkBoxFiltered.Location = new System.Drawing.Point(262, 70);
            this.checkBoxFiltered.Name = "checkBoxFiltered";
            this.checkBoxFiltered.Size = new System.Drawing.Size(60, 17);
            this.checkBoxFiltered.TabIndex = 9;
            this.checkBoxFiltered.Text = "Filtered";
            this.checkBoxFiltered.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.Font = new System.Drawing.Font("Lucida Sans Typewriter", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(6, 115);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(2);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(643, 116);
            this.richTextBox1.TabIndex = 14;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            this.richTextBox1.WordWrap = false;
            // 
            // labelQRZCache
            // 
            this.labelQRZCache.AutoSize = true;
            this.labelQRZCache.Location = new System.Drawing.Point(189, 93);
            this.labelQRZCache.Name = "labelQRZCache";
            this.labelQRZCache.Size = new System.Drawing.Size(64, 13);
            this.labelQRZCache.TabIndex = 21;
            this.labelQRZCache.Text = "QRZ Cache";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::DXClusterUtil.Properties.Settings.Default, "Password", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBoxPassword.Location = new System.Drawing.Point(163, 15);
            this.textBoxPassword.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(59, 20);
            this.textBoxPassword.TabIndex = 2;
            this.textBoxPassword.Text = global::DXClusterUtil.Properties.Settings.Default.Password;
            // 
            // labelClusterCache
            // 
            this.labelClusterCache.AutoSize = true;
            this.labelClusterCache.Location = new System.Drawing.Point(259, 93);
            this.labelClusterCache.Name = "labelClusterCache";
            this.labelClusterCache.Size = new System.Drawing.Size(72, 13);
            this.labelClusterCache.TabIndex = 23;
            this.labelClusterCache.Tag = "Cluster cache";
            this.labelClusterCache.Text = "Cluster cache";
            // 
            // numericUpDownRTTYOffset
            // 
            this.numericUpDownRTTYOffset.DataBindings.Add(new System.Windows.Forms.Binding("Value", global::DXClusterUtil.Properties.Settings.Default, "rttyOffset", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.numericUpDownRTTYOffset.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDownRTTYOffset.Location = new System.Drawing.Point(285, 41);
            this.numericUpDownRTTYOffset.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.numericUpDownRTTYOffset.Minimum = new decimal(new int[] {
            2000,
            0,
            0,
            -2147483648});
            this.numericUpDownRTTYOffset.Name = "numericUpDownRTTYOffset";
            this.numericUpDownRTTYOffset.Size = new System.Drawing.Size(48, 20);
            this.numericUpDownRTTYOffset.TabIndex = 5;
            this.numericUpDownRTTYOffset.Value = global::DXClusterUtil.Properties.Settings.Default.rttyOffset;
            this.numericUpDownRTTYOffset.ValueChanged += new System.EventHandler(this.NumericUpDownRTTYOffset_ValueChanged);
            // 
            // listBoxIgnore
            // 
            this.listBoxIgnore.FormattingEnabled = true;
            this.listBoxIgnore.Location = new System.Drawing.Point(341, 17);
            this.listBoxIgnore.Name = "listBoxIgnore";
            this.listBoxIgnore.Size = new System.Drawing.Size(80, 95);
            this.listBoxIgnore.TabIndex = 11;
            this.listBoxIgnore.Click += new System.EventHandler(this.ListBox1_Click);
            this.listBoxIgnore.SelectedIndexChanged += new System.EventHandler(this.ListBoxIgnore_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(360, 0);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Ignore";
            // 
            // comboBoxTimeForDump
            // 
            this.comboBoxTimeForDump.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::DXClusterUtil.Properties.Settings.Default, "TimeForDump", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.comboBoxTimeForDump.FormattingEnabled = true;
            this.comboBoxTimeForDump.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.comboBoxTimeForDump.Location = new System.Drawing.Point(13, 89);
            this.comboBoxTimeForDump.Name = "comboBoxTimeForDump";
            this.comboBoxTimeForDump.Size = new System.Drawing.Size(32, 21);
            this.comboBoxTimeForDump.TabIndex = 10;
            this.comboBoxTimeForDump.Text = global::DXClusterUtil.Properties.Settings.Default.TimeForDump;
            this.comboBoxTimeForDump.SelectedIndexChanged += new System.EventHandler(this.ComboBoxTimeForDump_SelectedIndexChanged);
            // 
            // checkedListBoxReviewedSpotters
            // 
            this.checkedListBoxReviewedSpotters.CheckedColor = System.Drawing.Color.Green;
            this.checkedListBoxReviewedSpotters.CheckOnClick = true;
            this.checkedListBoxReviewedSpotters.FormattingEnabled = true;
            this.checkedListBoxReviewedSpotters.IndeterminateColor = System.Drawing.Color.Orange;
            this.checkedListBoxReviewedSpotters.Location = new System.Drawing.Point(545, 17);
            this.checkedListBoxReviewedSpotters.Margin = new System.Windows.Forms.Padding(2);
            this.checkedListBoxReviewedSpotters.Name = "checkedListBoxReviewedSpotters";
            this.checkedListBoxReviewedSpotters.Size = new System.Drawing.Size(104, 94);
            this.checkedListBoxReviewedSpotters.TabIndex = 13;
            this.checkedListBoxReviewedSpotters.UncheckedColor = System.Drawing.Color.Red;
            this.checkedListBoxReviewedSpotters.SelectedIndexChanged += new System.EventHandler(this.CheckedListBoxReviewedSpotters_SelectedIndexChanged);
            this.checkedListBoxReviewedSpotters.MouseUp += new System.Windows.Forms.MouseEventHandler(this.CheckedListBoxReviewedSpotters_MouseUp);
            // 
            // form1BindingSource1
            // 
            this.form1BindingSource1.DataSource = typeof(DXClusterUtil.Form1);
            // 
            // form1BindingSource
            // 
            this.form1BindingSource.DataSource = typeof(DXClusterUtil.Form1);
            // 
            // form1BindingSource2
            // 
            this.form1BindingSource2.DataSource = typeof(DXClusterUtil.Form1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 233);
            this.Controls.Add(this.comboBoxTimeForDump);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listBoxIgnore);
            this.Controls.Add(this.numericUpDownRTTYOffset);
            this.Controls.Add(this.labelClusterCache);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.labelQRZCache);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.checkBoxFiltered);
            this.Controls.Add(this.checkBoxCached);
            this.Controls.Add(this.buttonCopy);
            this.Controls.Add(this.buttonBackup);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkedListBoxNewSpotters);
            this.Controls.Add(this.checkedListBoxReviewedSpotters);
            this.Controls.Add(this.textBoxPortLocal);
            this.Controls.Add(this.labelStatusQServer);
            this.Controls.Add(this.textBoxClusterServer);
            this.Controls.Add(this.labelQDepth);
            this.Controls.Add(this.textBoxCallsign);
            this.Controls.Add(this.buttonStart);
            this.DataBindings.Add(new System.Windows.Forms.Binding("Location", global::DXClusterUtil.Properties.Settings.Default, "Location", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = global::DXClusterUtil.Properties.Settings.Default.Location;
            this.Name = "Form1";
            this.Text = "DXClusterUtil V1.16 by W9MDB";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResizeEnd += new System.EventHandler(this.Form1_ResizeEnd);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRTTYOffset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.form1BindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.form1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.form1BindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox textBoxCallsign;
        private System.Windows.Forms.Label labelQDepth;
        private System.Windows.Forms.TextBox textBoxClusterServer;
        private System.Windows.Forms.Label labelStatusQServer;
        private System.Windows.Forms.TextBox textBoxPortLocal;
        private System.Windows.Forms.BindingSource form1BindingSource1;
        private System.Windows.Forms.BindingSource form1BindingSource;
        private System.Windows.Forms.BindingSource form1BindingSource2;
        public System.Windows.Forms.CheckedListBox checkedListBoxNewSpotters;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private ColorCodedCheckedListBox checkedListBoxReviewedSpotters;
        private System.Windows.Forms.Button buttonBackup;
        private System.Windows.Forms.Button buttonCopy;
        private System.Windows.Forms.CheckBox checkBoxCached;
        private System.Windows.Forms.CheckBox checkBoxFiltered;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label labelQRZCache;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label labelClusterCache;
        private System.Windows.Forms.NumericUpDown numericUpDownRTTYOffset;
        private System.Windows.Forms.ListBox listBoxIgnore;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxTimeForDump;
    }
}

