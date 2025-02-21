﻿namespace RSBot.Default.Views
{
    partial class Main
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("Avoid", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup2 = new System.Windows.Forms.ListViewGroup("Prefer", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup3 = new System.Windows.Forms.ListViewGroup("No custom behavior", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("General");
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("Champion");
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("Giant");
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem("General (party)");
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem("Champion (party)");
            System.Windows.Forms.ListViewItem listViewItem6 = new System.Windows.Forms.ListViewItem("Giant (party)");
            System.Windows.Forms.ListViewItem listViewItem7 = new System.Windows.Forms.ListViewItem("Unique");
            System.Windows.Forms.ListViewItem listViewItem8 = new System.Windows.Forms.ListViewItem("Strong");
            System.Windows.Forms.ListViewItem listViewItem9 = new System.Windows.Forms.ListViewItem("Elite");
            System.Windows.Forms.ListViewItem listViewItem10 = new System.Windows.Forms.ListViewItem("Event");
            this.groupBox2 = new SDUI.Controls.GroupBox();
            this.lvAvoidance = new SDUI.Controls.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.ctxAvoidance = new SDUI.Controls.ContextMenuStrip();
            this.btnAvoid = new System.Windows.Forms.ToolStripMenuItem();
            this.btnPrefer = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnNoCustomBehavior = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox3 = new SDUI.Controls.GroupBox();
            this.linkRecord = new System.Windows.Forms.LinkLabel();
            this.checkBoxUseReverse = new SDUI.Controls.CheckBox();
            this.checkUseSpeedDrug = new SDUI.Controls.CheckBox();
            this.checkCastBuffs = new SDUI.Controls.CheckBox();
            this.checkUseMount = new SDUI.Controls.CheckBox();
            this.btnBrowse = new SDUI.Controls.Button();
            this.txtWalkscript = new SDUI.Controls.TextBox();
            this.label4 = new SDUI.Controls.Label();
            this.checkBerzerkWhenFull = new SDUI.Controls.CheckBox();
            this.groupBox4 = new SDUI.Controls.GroupBox();
            this.label7 = new SDUI.Controls.Label();
            this.numBerzerkMonsterAmount = new SDUI.Controls.NumUpDown();
            this.checkBerzerkAvoidance = new SDUI.Controls.CheckBox();
            this.checkBerzerkMonsterAmount = new SDUI.Controls.CheckBox();
            this.groupBox1 = new SDUI.Controls.GroupBox();
            this.buttonSelectTrainingArea = new SDUI.Controls.Button();
            this.label6 = new SDUI.Controls.Label();
            this.label5 = new SDUI.Controls.Label();
            this.radioWalkAround = new SDUI.Controls.Radio();
            this.radioCenter = new SDUI.Controls.Radio();
            this.btnGetCurrent = new SDUI.Controls.Button();
            this.label3 = new SDUI.Controls.Label();
            this.label2 = new SDUI.Controls.Label();
            this.label1 = new SDUI.Controls.Label();
            this.txtRadius = new SDUI.Controls.TextBox();
            this.txtYCoord = new SDUI.Controls.TextBox();
            this.txtXCoord = new SDUI.Controls.TextBox();
            this.groupBoxIgnores = new SDUI.Controls.GroupBox();
            this.linkAttackWeakerMobsHelp = new System.Windows.Forms.LinkLabel();
            this.checkAttackWeakerFirst = new SDUI.Controls.CheckBox();
            this.checkBoxDimensionPillar = new SDUI.Controls.CheckBox();
            this.checkBox1 = new SDUI.Controls.CheckBox();
            this.groupBox2.SuspendLayout();
            this.ctxAvoidance.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numBerzerkMonsterAmount)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBoxIgnores.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.lvAvoidance);
            this.groupBox2.Location = new System.Drawing.Point(23, 250);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 7, 2, 3);
            this.groupBox2.Radius = 10;
            this.groupBox2.ShadowDepth = 4;
            this.groupBox2.Size = new System.Drawing.Size(221, 214);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Avoidance";
            // 
            // lvAvoidance
            // 
            this.lvAvoidance.Alignment = System.Windows.Forms.ListViewAlignment.Default;
            this.lvAvoidance.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvAvoidance.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.lvAvoidance.ContextMenuStrip = this.ctxAvoidance;
            this.lvAvoidance.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvAvoidance.FullRowSelect = true;
            listViewGroup1.Header = "Avoid";
            listViewGroup1.Name = "grpAvoid";
            listViewGroup2.Header = "Prefer";
            listViewGroup2.Name = "grpPrefer";
            listViewGroup3.Header = "No custom behavior";
            listViewGroup3.Name = "grpNone";
            this.lvAvoidance.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1,
            listViewGroup2,
            listViewGroup3});
            this.lvAvoidance.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            listViewItem1.Group = listViewGroup3;
            listViewItem2.Group = listViewGroup3;
            listViewItem3.Group = listViewGroup3;
            listViewItem4.Group = listViewGroup3;
            listViewItem5.Group = listViewGroup3;
            listViewItem6.Group = listViewGroup3;
            listViewItem7.Group = listViewGroup3;
            listViewItem8.Group = listViewGroup3;
            listViewItem9.Group = listViewGroup3;
            listViewItem10.Group = listViewGroup3;
            listViewItem10.ToolTipText = "Event Mobs";
            this.lvAvoidance.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4,
            listViewItem5,
            listViewItem6,
            listViewItem7,
            listViewItem8,
            listViewItem9,
            listViewItem10});
            this.lvAvoidance.Location = new System.Drawing.Point(2, 23);
            this.lvAvoidance.Name = "lvAvoidance";
            this.lvAvoidance.Size = new System.Drawing.Size(217, 188);
            this.lvAvoidance.TabIndex = 5;
            this.lvAvoidance.TileSize = new System.Drawing.Size(168, 16);
            this.lvAvoidance.UseCompatibleStateImageBehavior = false;
            this.lvAvoidance.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Width = 190;
            // 
            // ctxAvoidance
            // 
            this.ctxAvoidance.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAvoid,
            this.btnPrefer,
            this.toolStripSeparator1,
            this.btnNoCustomBehavior});
            this.ctxAvoidance.Name = "ctxAvoidance";
            this.ctxAvoidance.Size = new System.Drawing.Size(196, 76);
            // 
            // btnAvoid
            // 
            this.btnAvoid.Name = "btnAvoid";
            this.btnAvoid.Size = new System.Drawing.Size(195, 22);
            this.btnAvoid.Text = "Avoid";
            this.btnAvoid.Click += new System.EventHandler(this.btnAvoid_Click);
            // 
            // btnPrefer
            // 
            this.btnPrefer.Name = "btnPrefer";
            this.btnPrefer.Size = new System.Drawing.Size(195, 22);
            this.btnPrefer.Text = "Prefer";
            this.btnPrefer.Click += new System.EventHandler(this.btnPrefer_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(192, 6);
            // 
            // btnNoCustomBehavior
            // 
            this.btnNoCustomBehavior.Name = "btnNoCustomBehavior";
            this.btnNoCustomBehavior.Size = new System.Drawing.Size(195, 22);
            this.btnNoCustomBehavior.Text = "No custom behavior";
            this.btnNoCustomBehavior.Click += new System.EventHandler(this.btnNoCustomBehavior_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.checkBox1);
            this.groupBox3.Controls.Add(this.linkRecord);
            this.groupBox3.Controls.Add(this.checkBoxUseReverse);
            this.groupBox3.Controls.Add(this.checkUseSpeedDrug);
            this.groupBox3.Controls.Add(this.checkCastBuffs);
            this.groupBox3.Controls.Add(this.checkUseMount);
            this.groupBox3.Controls.Add(this.btnBrowse);
            this.groupBox3.Controls.Add(this.txtWalkscript);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Location = new System.Drawing.Point(262, 16);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.groupBox3.Radius = 10;
            this.groupBox3.ShadowDepth = 4;
            this.groupBox3.Size = new System.Drawing.Size(478, 144);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Back to training";
            // 
            // linkRecord
            // 
            this.linkRecord.AutoSize = true;
            this.linkRecord.Location = new System.Drawing.Point(348, 33);
            this.linkRecord.Name = "linkRecord";
            this.linkRecord.Size = new System.Drawing.Size(52, 15);
            this.linkRecord.TabIndex = 7;
            this.linkRecord.TabStop = true;
            this.linkRecord.Text = "[Record]";
            this.linkRecord.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkRecord_LinkClicked);
            // 
            // checkBoxUseReverse
            // 
            this.checkBoxUseReverse.AutoSize = true;
            this.checkBoxUseReverse.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxUseReverse.Location = new System.Drawing.Point(378, 84);
            this.checkBoxUseReverse.Name = "checkBoxUseReverse";
            this.checkBoxUseReverse.ShadowDepth = 1;
            this.checkBoxUseReverse.Size = new System.Drawing.Size(85, 15);
            this.checkBoxUseReverse.TabIndex = 7;
            this.checkBoxUseReverse.Text = "Use Reverse";
            this.checkBoxUseReverse.UseVisualStyleBackColor = false;
            this.checkBoxUseReverse.CheckedChanged += new System.EventHandler(this.checkBoxUseReverse_CheckedChanged);
            // 
            // checkUseSpeedDrug
            // 
            this.checkUseSpeedDrug.AutoSize = true;
            this.checkUseSpeedDrug.BackColor = System.Drawing.Color.Transparent;
            this.checkUseSpeedDrug.Location = new System.Drawing.Point(261, 84);
            this.checkUseSpeedDrug.Name = "checkUseSpeedDrug";
            this.checkUseSpeedDrug.ShadowDepth = 1;
            this.checkUseSpeedDrug.Size = new System.Drawing.Size(104, 15);
            this.checkUseSpeedDrug.TabIndex = 7;
            this.checkUseSpeedDrug.Text = "Use speed drug";
            this.checkUseSpeedDrug.UseVisualStyleBackColor = false;
            this.checkUseSpeedDrug.CheckedChanged += new System.EventHandler(this.checkUseSpeedDrug_CheckedChanged);
            // 
            // checkCastBuffs
            // 
            this.checkCastBuffs.AutoSize = true;
            this.checkCastBuffs.BackColor = System.Drawing.Color.Transparent;
            this.checkCastBuffs.Location = new System.Drawing.Point(171, 84);
            this.checkCastBuffs.Name = "checkCastBuffs";
            this.checkCastBuffs.ShadowDepth = 1;
            this.checkCastBuffs.Size = new System.Drawing.Size(76, 15);
            this.checkCastBuffs.TabIndex = 6;
            this.checkCastBuffs.Text = "Cast buffs";
            this.checkCastBuffs.UseVisualStyleBackColor = false;
            this.checkCastBuffs.CheckedChanged += new System.EventHandler(this.checkCastBuffs_CheckedChanged);
            // 
            // checkUseMount
            // 
            this.checkUseMount.AutoSize = true;
            this.checkUseMount.BackColor = System.Drawing.Color.Transparent;
            this.checkUseMount.Location = new System.Drawing.Point(21, 84);
            this.checkUseMount.Name = "checkUseMount";
            this.checkUseMount.ShadowDepth = 1;
            this.checkUseMount.Size = new System.Drawing.Size(140, 15);
            this.checkUseMount.TabIndex = 3;
            this.checkUseMount.Text = "Use mount if available";
            this.checkUseMount.UseVisualStyleBackColor = false;
            this.checkUseMount.CheckedChanged += new System.EventHandler(this.checkUseMount_CheckedChanged);
            // 
            // btnBrowse
            // 
            this.btnBrowse.Color = System.Drawing.Color.Transparent;
            this.btnBrowse.Location = new System.Drawing.Point(406, 51);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Radius = 6;
            this.btnBrowse.ShadowDepth = 4F;
            this.btnBrowse.Size = new System.Drawing.Size(57, 23);
            this.btnBrowse.TabIndex = 3;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // txtWalkscript
            // 
            this.txtWalkscript.BackColor = System.Drawing.Color.White;
            this.txtWalkscript.Location = new System.Drawing.Point(21, 52);
            this.txtWalkscript.MaxLength = 32767;
            this.txtWalkscript.MultiLine = false;
            this.txtWalkscript.Name = "txtWalkscript";
            this.txtWalkscript.Radius = 2;
            this.txtWalkscript.Size = new System.Drawing.Size(379, 21);
            this.txtWalkscript.TabIndex = 4;
            this.txtWalkscript.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtWalkscript.UseSystemPasswordChar = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(18, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Walkscript:";
            // 
            // checkBerzerkWhenFull
            // 
            this.checkBerzerkWhenFull.AutoSize = true;
            this.checkBerzerkWhenFull.BackColor = System.Drawing.Color.Transparent;
            this.checkBerzerkWhenFull.Location = new System.Drawing.Point(21, 34);
            this.checkBerzerkWhenFull.Name = "checkBerzerkWhenFull";
            this.checkBerzerkWhenFull.ShadowDepth = 1;
            this.checkBerzerkWhenFull.Size = new System.Drawing.Size(177, 15);
            this.checkBerzerkWhenFull.TabIndex = 4;
            this.checkBerzerkWhenFull.Text = "Enter berzerk mode when full";
            this.checkBerzerkWhenFull.UseVisualStyleBackColor = false;
            this.checkBerzerkWhenFull.CheckedChanged += new System.EventHandler(this.checkBerzerkWhenFull_CheckedChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Transparent;
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.numBerzerkMonsterAmount);
            this.groupBox4.Controls.Add(this.checkBerzerkAvoidance);
            this.groupBox4.Controls.Add(this.checkBerzerkMonsterAmount);
            this.groupBox4.Controls.Add(this.checkBerzerkWhenFull);
            this.groupBox4.Location = new System.Drawing.Point(262, 176);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.groupBox4.Radius = 10;
            this.groupBox4.ShadowDepth = 4;
            this.groupBox4.Size = new System.Drawing.Size(478, 125);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Berzerk";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label7.Location = new System.Drawing.Point(245, 62);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 15);
            this.label7.TabIndex = 7;
            this.label7.Text = "monsters";
            // 
            // numBerzerkMonsterAmount
            // 
            this.numBerzerkMonsterAmount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.numBerzerkMonsterAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numBerzerkMonsterAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.numBerzerkMonsterAmount.Location = new System.Drawing.Point(202, 59);
            this.numBerzerkMonsterAmount.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numBerzerkMonsterAmount.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numBerzerkMonsterAmount.Name = "numBerzerkMonsterAmount";
            this.numBerzerkMonsterAmount.Size = new System.Drawing.Size(37, 23);
            this.numBerzerkMonsterAmount.TabIndex = 6;
            this.numBerzerkMonsterAmount.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numBerzerkMonsterAmount.ValueChanged += new System.EventHandler(this.numBerzerkMonsterAmount_ValueChanged);
            // 
            // checkBerzerkAvoidance
            // 
            this.checkBerzerkAvoidance.AutoSize = true;
            this.checkBerzerkAvoidance.BackColor = System.Drawing.Color.Transparent;
            this.checkBerzerkAvoidance.Location = new System.Drawing.Point(21, 88);
            this.checkBerzerkAvoidance.Name = "checkBerzerkAvoidance";
            this.checkBerzerkAvoidance.ShadowDepth = 1;
            this.checkBerzerkAvoidance.Size = new System.Drawing.Size(333, 15);
            this.checkBerzerkAvoidance.TabIndex = 5;
            this.checkBerzerkAvoidance.Text = "If being attacked by a monster type that should be avoided";
            this.checkBerzerkAvoidance.UseVisualStyleBackColor = false;
            this.checkBerzerkAvoidance.CheckedChanged += new System.EventHandler(this.checkBerzerkAvoidance_CheckedChanged);
            // 
            // checkBerzerkMonsterAmount
            // 
            this.checkBerzerkMonsterAmount.AutoSize = true;
            this.checkBerzerkMonsterAmount.BackColor = System.Drawing.Color.Transparent;
            this.checkBerzerkMonsterAmount.Location = new System.Drawing.Point(21, 60);
            this.checkBerzerkMonsterAmount.Name = "checkBerzerkMonsterAmount";
            this.checkBerzerkMonsterAmount.ShadowDepth = 1;
            this.checkBerzerkMonsterAmount.Size = new System.Drawing.Size(175, 15);
            this.checkBerzerkMonsterAmount.TabIndex = 4;
            this.checkBerzerkMonsterAmount.Text = "Being attacked by more than";
            this.checkBerzerkMonsterAmount.UseVisualStyleBackColor = false;
            this.checkBerzerkMonsterAmount.CheckedChanged += new System.EventHandler(this.checkBerzerkMonsterAmount_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.buttonSelectTrainingArea);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.radioWalkAround);
            this.groupBox1.Controls.Add(this.radioCenter);
            this.groupBox1.Controls.Add(this.btnGetCurrent);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtRadius);
            this.groupBox1.Controls.Add(this.txtYCoord);
            this.groupBox1.Controls.Add(this.txtXCoord);
            this.groupBox1.Location = new System.Drawing.Point(23, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.groupBox1.Radius = 10;
            this.groupBox1.ShadowDepth = 4;
            this.groupBox1.Size = new System.Drawing.Size(221, 228);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Area";
            // 
            // buttonSelectTrainingArea
            // 
            this.buttonSelectTrainingArea.Color = System.Drawing.Color.DeepSkyBlue;
            this.buttonSelectTrainingArea.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonSelectTrainingArea.ForeColor = System.Drawing.Color.White;
            this.buttonSelectTrainingArea.Location = new System.Drawing.Point(179, 107);
            this.buttonSelectTrainingArea.Name = "buttonSelectTrainingArea";
            this.buttonSelectTrainingArea.Radius = 6;
            this.buttonSelectTrainingArea.ShadowDepth = 4F;
            this.buttonSelectTrainingArea.Size = new System.Drawing.Size(24, 24);
            this.buttonSelectTrainingArea.TabIndex = 7;
            this.buttonSelectTrainingArea.Text = "...";
            this.buttonSelectTrainingArea.UseVisualStyleBackColor = true;
            this.buttonSelectTrainingArea.Click += new System.EventHandler(this.buttonSelectTrainingArea_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(14, 145);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(159, 15);
            this.label6.TabIndex = 7;
            this.label6.Text = "If there is no enemy nearby...";
            // 
            // label5
            // 
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(11, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(200, 2);
            this.label5.TabIndex = 6;
            // 
            // radioWalkAround
            // 
            this.radioWalkAround.AutoSize = true;
            this.radioWalkAround.Checked = true;
            this.radioWalkAround.Location = new System.Drawing.Point(35, 195);
            this.radioWalkAround.Name = "radioWalkAround";
            this.radioWalkAround.ShadowDepth = 0;
            this.radioWalkAround.Size = new System.Drawing.Size(99, 15);
            this.radioWalkAround.TabIndex = 5;
            this.radioWalkAround.TabStop = true;
            this.radioWalkAround.Text = "Walk around";
            this.radioWalkAround.CheckedChanged += new System.EventHandler(this.radioWalkAround_CheckedChanged);
            // 
            // radioCenter
            // 
            this.radioCenter.AutoSize = true;
            this.radioCenter.Location = new System.Drawing.Point(35, 169);
            this.radioCenter.Name = "radioCenter";
            this.radioCenter.ShadowDepth = 0;
            this.radioCenter.Size = new System.Drawing.Size(125, 15);
            this.radioCenter.TabIndex = 4;
            this.radioCenter.Text = "Go back to center";
            this.radioCenter.CheckedChanged += new System.EventHandler(this.radioCenter_CheckedChanged);
            // 
            // btnGetCurrent
            // 
            this.btnGetCurrent.Color = System.Drawing.Color.Transparent;
            this.btnGetCurrent.Location = new System.Drawing.Point(76, 107);
            this.btnGetCurrent.Name = "btnGetCurrent";
            this.btnGetCurrent.Radius = 6;
            this.btnGetCurrent.ShadowDepth = 4F;
            this.btnGetCurrent.Size = new System.Drawing.Size(97, 23);
            this.btnGetCurrent.TabIndex = 3;
            this.btnGetCurrent.Text = "Current";
            this.btnGetCurrent.UseVisualStyleBackColor = true;
            this.btnGetCurrent.Click += new System.EventHandler(this.btnGetCurrent_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(27, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Radius:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(53, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Y:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(53, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "X:";
            // 
            // txtRadius
            // 
            this.txtRadius.Location = new System.Drawing.Point(76, 81);
            this.txtRadius.MaxLength = 32767;
            this.txtRadius.MultiLine = false;
            this.txtRadius.Name = "txtRadius";
            this.txtRadius.Radius = 2;
            this.txtRadius.Size = new System.Drawing.Size(97, 21);
            this.txtRadius.TabIndex = 0;
            this.txtRadius.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtRadius.UseSystemPasswordChar = false;
            this.txtRadius.TextChanged += new System.EventHandler(this.txtRadius_TextChanged);
            // 
            // txtYCoord
            // 
            this.txtYCoord.Location = new System.Drawing.Point(76, 55);
            this.txtYCoord.MaxLength = 32767;
            this.txtYCoord.MultiLine = false;
            this.txtYCoord.Name = "txtYCoord";
            this.txtYCoord.Radius = 2;
            this.txtYCoord.Size = new System.Drawing.Size(97, 21);
            this.txtYCoord.TabIndex = 0;
            this.txtYCoord.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtYCoord.UseSystemPasswordChar = false;
            this.txtYCoord.TextChanged += new System.EventHandler(this.txtYCoord_TextChanged);
            // 
            // txtXCoord
            // 
            this.txtXCoord.Location = new System.Drawing.Point(76, 29);
            this.txtXCoord.MaxLength = 32767;
            this.txtXCoord.MultiLine = false;
            this.txtXCoord.Name = "txtXCoord";
            this.txtXCoord.Radius = 2;
            this.txtXCoord.Size = new System.Drawing.Size(97, 21);
            this.txtXCoord.TabIndex = 0;
            this.txtXCoord.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtXCoord.UseSystemPasswordChar = false;
            this.txtXCoord.TextChanged += new System.EventHandler(this.txtXCoord_TextChanged);
            // 
            // groupBoxIgnores
            // 
            this.groupBoxIgnores.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxIgnores.Controls.Add(this.linkAttackWeakerMobsHelp);
            this.groupBoxIgnores.Controls.Add(this.checkAttackWeakerFirst);
            this.groupBoxIgnores.Controls.Add(this.checkBoxDimensionPillar);
            this.groupBoxIgnores.Location = new System.Drawing.Point(262, 319);
            this.groupBoxIgnores.Name = "groupBoxIgnores";
            this.groupBoxIgnores.Padding = new System.Windows.Forms.Padding(3, 8, 3, 3);
            this.groupBoxIgnores.Radius = 10;
            this.groupBoxIgnores.ShadowDepth = 4;
            this.groupBoxIgnores.Size = new System.Drawing.Size(478, 100);
            this.groupBoxIgnores.TabIndex = 6;
            this.groupBoxIgnores.TabStop = false;
            this.groupBoxIgnores.Text = "Advanced";
            // 
            // linkAttackWeakerMobsHelp
            // 
            this.linkAttackWeakerMobsHelp.AutoSize = true;
            this.linkAttackWeakerMobsHelp.Location = new System.Drawing.Point(271, 55);
            this.linkAttackWeakerMobsHelp.Name = "linkAttackWeakerMobsHelp";
            this.linkAttackWeakerMobsHelp.Size = new System.Drawing.Size(12, 15);
            this.linkAttackWeakerMobsHelp.TabIndex = 7;
            this.linkAttackWeakerMobsHelp.TabStop = true;
            this.linkAttackWeakerMobsHelp.Text = "?";
            this.linkAttackWeakerMobsHelp.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkAttackWeakerMobsHelp_LinkClicked);
            // 
            // checkAttackWeakerFirst
            // 
            this.checkAttackWeakerFirst.AutoSize = true;
            this.checkAttackWeakerFirst.BackColor = System.Drawing.Color.Transparent;
            this.checkAttackWeakerFirst.Location = new System.Drawing.Point(18, 57);
            this.checkAttackWeakerFirst.Name = "checkAttackWeakerFirst";
            this.checkAttackWeakerFirst.ShadowDepth = 1;
            this.checkAttackWeakerFirst.Size = new System.Drawing.Size(253, 15);
            this.checkAttackWeakerFirst.TabIndex = 1;
            this.checkAttackWeakerFirst.Text = "If avoided: counter attack weaker mobs first";
            this.checkAttackWeakerFirst.UseVisualStyleBackColor = false;
            this.checkAttackWeakerFirst.CheckedChanged += new System.EventHandler(this.checkAttackWeakerFirst_CheckedChanged);
            // 
            // checkBoxDimensionPillar
            // 
            this.checkBoxDimensionPillar.AutoSize = true;
            this.checkBoxDimensionPillar.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxDimensionPillar.Location = new System.Drawing.Point(18, 36);
            this.checkBoxDimensionPillar.Name = "checkBoxDimensionPillar";
            this.checkBoxDimensionPillar.ShadowDepth = 1;
            this.checkBoxDimensionPillar.Size = new System.Drawing.Size(146, 15);
            this.checkBoxDimensionPillar.TabIndex = 0;
            this.checkBoxDimensionPillar.Text = "Ignore Dimension Pillar";
            this.checkBoxDimensionPillar.UseVisualStyleBackColor = false;
            this.checkBoxDimensionPillar.CheckedChanged += new System.EventHandler(this.checkBoxIgnorePillars_CheckedChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.Color.Transparent;
            this.checkBox1.Location = new System.Drawing.Point(21, 105);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.ShadowDepth = 1;
            this.checkBox1.Size = new System.Drawing.Size(111, 15);
            this.checkBox1.TabIndex = 8;
            this.checkBox1.Text = "Use Revive Scroll";
            this.checkBox1.UseVisualStyleBackColor = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.groupBoxIgnores);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox4);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "Main";
            this.Size = new System.Drawing.Size(772, 491);
            this.groupBox2.ResumeLayout(false);
            this.ctxAvoidance.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numBerzerkMonsterAmount)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBoxIgnores.ResumeLayout(false);
            this.groupBoxIgnores.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private SDUI.Controls.GroupBox groupBox2;
        private SDUI.Controls.GroupBox groupBox3;
        private SDUI.Controls.Button btnBrowse;
        private SDUI.Controls.TextBox txtWalkscript;
        private SDUI.Controls.Label label4;
        private SDUI.Controls.CheckBox checkUseMount;
        private SDUI.Controls.CheckBox checkUseSpeedDrug;
        private SDUI.Controls.CheckBox checkCastBuffs;
        private SDUI.Controls.CheckBox checkBerzerkWhenFull;
        private SDUI.Controls.ListView lvAvoidance;
        private SDUI.Controls.ContextMenuStrip ctxAvoidance;
        private System.Windows.Forms.ToolStripMenuItem btnAvoid;
        private System.Windows.Forms.ToolStripMenuItem btnPrefer;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem btnNoCustomBehavior;
        private SDUI.Controls.GroupBox groupBox4;
        private SDUI.Controls.NumUpDown numBerzerkMonsterAmount;
        private SDUI.Controls.CheckBox checkBerzerkAvoidance;
        private SDUI.Controls.CheckBox checkBerzerkMonsterAmount;
        private SDUI.Controls.Label label7;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private SDUI.Controls.GroupBox groupBox1;
        private SDUI.Controls.Label label6;
        private SDUI.Controls.Label label5;
        private SDUI.Controls.Radio radioWalkAround;
        private SDUI.Controls.Radio radioCenter;
        private SDUI.Controls.Button btnGetCurrent;
        private SDUI.Controls.Label label3;
        private SDUI.Controls.Label label2;
        private SDUI.Controls.Label label1;
        private SDUI.Controls.TextBox txtRadius;
        private SDUI.Controls.TextBox txtYCoord;
        private SDUI.Controls.TextBox txtXCoord;
        private SDUI.Controls.CheckBox checkBoxUseReverse;
        private SDUI.Controls.Button buttonSelectTrainingArea;
        private SDUI.Controls.Radio radioStand;
        private SDUI.Controls.GroupBox groupBoxIgnores;
        private SDUI.Controls.CheckBox checkBoxDimensionPillar;
        private SDUI.Controls.CheckBox checkAttackWeakerFirst;
        private System.Windows.Forms.LinkLabel linkAttackWeakerMobsHelp;
        private System.Windows.Forms.LinkLabel linkRecord;
        private SDUI.Controls.CheckBox checkBox1;
    }
}
