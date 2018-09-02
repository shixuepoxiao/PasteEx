﻿namespace PasteEx.Forms
{
    partial class FormSetting
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSetting));
            this.tipHelp = new System.Windows.Forms.ToolTip(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageNomal = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cboLanguage = new System.Windows.Forms.ComboBox();
            this.labelLanguage = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.chkFastNeedShiftKey = new System.Windows.Forms.CheckBox();
            this.btnFastUnRegister = new System.Windows.Forms.Button();
            this.btnFastRegister = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkNeedShiftKey = new System.Windows.Forms.CheckBox();
            this.btnUnRegister = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.tabPageCustom = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblTipError = new System.Windows.Forms.Label();
            this.lblHelp = new System.Windows.Forms.Label();
            this.txtAutoExtRule = new System.Windows.Forms.TextBox();
            this.chkAutoExtSwitch = new System.Windows.Forms.CheckBox();
            this.tabPageMode = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.lblTipHotkey = new System.Windows.Forms.Label();
            this.lblPasteExHotkey = new System.Windows.Forms.Label();
            this.txtHotkey = new PasteEx.Forms.Hotkey.HotkeyTextBox();
            this.tabPageAbout = new System.Windows.Forms.TabPage();
            this.labelUpdateinfo = new System.Windows.Forms.LinkLabel();
            this.picLoading = new System.Windows.Forms.PictureBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabControl1.SuspendLayout();
            this.tabPageNomal.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPageCustom.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabPageMode.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.tabPageAbout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLoading)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tipHelp
            // 
            this.tipHelp.AutomaticDelay = 0;
            this.tipHelp.AutoPopDelay = 1000000;
            this.tipHelp.InitialDelay = 0;
            this.tipHelp.ReshowDelay = 0;
            this.tipHelp.ShowAlways = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageNomal);
            this.tabControl1.Controls.Add(this.tabPageCustom);
            this.tabControl1.Controls.Add(this.tabPageMode);
            this.tabControl1.Controls.Add(this.tabPageAbout);
            resources.ApplyResources(this.tabControl1, "tabControl1");
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPageNomal
            // 
            this.tabPageNomal.Controls.Add(this.groupBox4);
            this.tabPageNomal.Controls.Add(this.groupBox3);
            this.tabPageNomal.Controls.Add(this.groupBox1);
            resources.ApplyResources(this.tabPageNomal, "tabPageNomal");
            this.tabPageNomal.Name = "tabPageNomal";
            this.tabPageNomal.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            resources.ApplyResources(this.groupBox4, "groupBox4");
            this.groupBox4.Controls.Add(this.cboLanguage);
            this.groupBox4.Controls.Add(this.labelLanguage);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.TabStop = false;
            // 
            // cboLanguage
            // 
            this.cboLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLanguage.FormattingEnabled = true;
            this.cboLanguage.Items.AddRange(new object[] {
            resources.GetString("cboLanguage.Items"),
            resources.GetString("cboLanguage.Items1"),
            resources.GetString("cboLanguage.Items2")});
            resources.ApplyResources(this.cboLanguage, "cboLanguage");
            this.cboLanguage.Name = "cboLanguage";
            this.cboLanguage.SelectedIndexChanged += new System.EventHandler(this.cboLanguage_SelectedIndexChanged);
            // 
            // labelLanguage
            // 
            resources.ApplyResources(this.labelLanguage, "labelLanguage");
            this.labelLanguage.Name = "labelLanguage";
            // 
            // groupBox3
            // 
            resources.ApplyResources(this.groupBox3, "groupBox3");
            this.groupBox3.Controls.Add(this.chkFastNeedShiftKey);
            this.groupBox3.Controls.Add(this.btnFastUnRegister);
            this.groupBox3.Controls.Add(this.btnFastRegister);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.TabStop = false;
            // 
            // chkFastNeedShiftKey
            // 
            resources.ApplyResources(this.chkFastNeedShiftKey, "chkFastNeedShiftKey");
            this.chkFastNeedShiftKey.Name = "chkFastNeedShiftKey";
            this.chkFastNeedShiftKey.UseVisualStyleBackColor = true;
            // 
            // btnFastUnRegister
            // 
            resources.ApplyResources(this.btnFastUnRegister, "btnFastUnRegister");
            this.btnFastUnRegister.Name = "btnFastUnRegister";
            this.btnFastUnRegister.UseVisualStyleBackColor = true;
            this.btnFastUnRegister.Click += new System.EventHandler(this.btnFastUnRegister_Click);
            // 
            // btnFastRegister
            // 
            resources.ApplyResources(this.btnFastRegister, "btnFastRegister");
            this.btnFastRegister.Name = "btnFastRegister";
            this.btnFastRegister.UseVisualStyleBackColor = true;
            this.btnFastRegister.Click += new System.EventHandler(this.btnFastRegister_Click);
            // 
            // groupBox1
            // 
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Controls.Add(this.chkNeedShiftKey);
            this.groupBox1.Controls.Add(this.btnUnRegister);
            this.groupBox1.Controls.Add(this.btnRegister);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // chkNeedShiftKey
            // 
            resources.ApplyResources(this.chkNeedShiftKey, "chkNeedShiftKey");
            this.chkNeedShiftKey.Name = "chkNeedShiftKey";
            this.chkNeedShiftKey.UseVisualStyleBackColor = true;
            // 
            // btnUnRegister
            // 
            resources.ApplyResources(this.btnUnRegister, "btnUnRegister");
            this.btnUnRegister.Name = "btnUnRegister";
            this.btnUnRegister.UseVisualStyleBackColor = true;
            this.btnUnRegister.Click += new System.EventHandler(this.btnUnRegister_Click);
            // 
            // btnRegister
            // 
            resources.ApplyResources(this.btnRegister, "btnRegister");
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // tabPageCustom
            // 
            this.tabPageCustom.Controls.Add(this.groupBox2);
            resources.ApplyResources(this.tabPageCustom, "tabPageCustom");
            this.tabPageCustom.Name = "tabPageCustom";
            this.tabPageCustom.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Controls.Add(this.lblTipError);
            this.groupBox2.Controls.Add(this.lblHelp);
            this.groupBox2.Controls.Add(this.txtAutoExtRule);
            this.groupBox2.Controls.Add(this.chkAutoExtSwitch);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // lblTipError
            // 
            resources.ApplyResources(this.lblTipError, "lblTipError");
            this.lblTipError.ForeColor = System.Drawing.Color.Red;
            this.lblTipError.Name = "lblTipError";
            // 
            // lblHelp
            // 
            resources.ApplyResources(this.lblHelp, "lblHelp");
            this.lblHelp.Cursor = System.Windows.Forms.Cursors.Help;
            this.lblHelp.Name = "lblHelp";
            this.lblHelp.MouseHover += new System.EventHandler(this.lblHelp_MouseHover);
            // 
            // txtAutoExtRule
            // 
            resources.ApplyResources(this.txtAutoExtRule, "txtAutoExtRule");
            this.txtAutoExtRule.Name = "txtAutoExtRule";
            this.txtAutoExtRule.TextChanged += new System.EventHandler(this.txtAutoExtRuleValidate);
            this.txtAutoExtRule.Leave += new System.EventHandler(this.txtAutoExtRuleValidate);
            this.txtAutoExtRule.MouseLeave += new System.EventHandler(this.txtAutoExtRuleValidate);
            // 
            // chkAutoExtSwitch
            // 
            resources.ApplyResources(this.chkAutoExtSwitch, "chkAutoExtSwitch");
            this.chkAutoExtSwitch.Name = "chkAutoExtSwitch";
            this.chkAutoExtSwitch.UseVisualStyleBackColor = true;
            this.chkAutoExtSwitch.CheckedChanged += new System.EventHandler(this.chkAutoExtSwitch_CheckedChanged);
            // 
            // tabPageMode
            // 
            this.tabPageMode.Controls.Add(this.groupBox5);
            resources.ApplyResources(this.tabPageMode, "tabPageMode");
            this.tabPageMode.Name = "tabPageMode";
            this.tabPageMode.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.lblTipHotkey);
            this.groupBox5.Controls.Add(this.lblPasteExHotkey);
            this.groupBox5.Controls.Add(this.txtHotkey);
            resources.ApplyResources(this.groupBox5, "groupBox5");
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.TabStop = false;
            // 
            // lblTipHotkey
            // 
            resources.ApplyResources(this.lblTipHotkey, "lblTipHotkey");
            this.lblTipHotkey.Name = "lblTipHotkey";
            // 
            // lblPasteExHotkey
            // 
            resources.ApplyResources(this.lblPasteExHotkey, "lblPasteExHotkey");
            this.lblPasteExHotkey.Name = "lblPasteExHotkey";
            // 
            // txtHotkey
            // 
            resources.ApplyResources(this.txtHotkey, "txtHotkey");
            this.txtHotkey.Name = "txtHotkey";
            // 
            // tabPageAbout
            // 
            this.tabPageAbout.Controls.Add(this.labelUpdateinfo);
            this.tabPageAbout.Controls.Add(this.picLoading);
            this.tabPageAbout.Controls.Add(this.linkLabel1);
            this.tabPageAbout.Controls.Add(this.label2);
            this.tabPageAbout.Controls.Add(this.pictureBox1);
            resources.ApplyResources(this.tabPageAbout, "tabPageAbout");
            this.tabPageAbout.Name = "tabPageAbout";
            this.tabPageAbout.UseVisualStyleBackColor = true;
            // 
            // labelUpdateinfo
            // 
            this.labelUpdateinfo.ForeColor = System.Drawing.Color.Green;
            resources.ApplyResources(this.labelUpdateinfo, "labelUpdateinfo");
            this.labelUpdateinfo.LinkColor = System.Drawing.Color.Green;
            this.labelUpdateinfo.Name = "labelUpdateinfo";
            this.labelUpdateinfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabels_LinkClicked);
            // 
            // picLoading
            // 
            this.picLoading.Image = global::PasteEx.Properties.Resources.loading;
            resources.ApplyResources(this.picLoading, "picLoading");
            this.picLoading.Name = "picLoading";
            this.picLoading.TabStop = false;
            // 
            // linkLabel1
            // 
            resources.ApplyResources(this.linkLabel1, "linkLabel1");
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.UseCompatibleTextRendering = true;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabels_LinkClicked);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Image = global::PasteEx.Properties.Resources.png;
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // FormSetting
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Icon = global::PasteEx.Properties.Resources.ico;
            this.Name = "FormSetting";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormSetting_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormSetting_FormClosed);
            this.Load += new System.EventHandler(this.FormSetting_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPageNomal.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPageCustom.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabPageMode.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.tabPageAbout.ResumeLayout(false);
            this.tabPageAbout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLoading)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ToolTip tipHelp;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageCustom;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblHelp;
        private System.Windows.Forms.TextBox txtAutoExtRule;
        private System.Windows.Forms.CheckBox chkAutoExtSwitch;
        private System.Windows.Forms.TabPage tabPageNomal;
        private System.Windows.Forms.TabPage tabPageAbout;
        private System.Windows.Forms.Label lblTipError;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox picLoading;
        private System.Windows.Forms.LinkLabel labelUpdateinfo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkNeedShiftKey;
        private System.Windows.Forms.Button btnUnRegister;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox chkFastNeedShiftKey;
        private System.Windows.Forms.Button btnFastUnRegister;
        private System.Windows.Forms.Button btnFastRegister;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox cboLanguage;
        private System.Windows.Forms.Label labelLanguage;
        private System.Windows.Forms.TabPage tabPageMode;
        private System.Windows.Forms.GroupBox groupBox5;
        private Hotkey.HotkeyTextBox txtHotkey;
        private System.Windows.Forms.Label lblPasteExHotkey;
        private System.Windows.Forms.Label lblTipHotkey;
    }
}