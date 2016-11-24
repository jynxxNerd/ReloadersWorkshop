﻿namespace ReloadersWorkShop
	{
	partial class cFirearmAccessoryForm
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
			System.Windows.Forms.Label label18;
			this.GeneralGroup = new System.Windows.Forms.GroupBox();
			this.DescriptionTextBox = new CommonLib.Controls.cTextBox();
			this.SerialNumberTextBox = new CommonLib.Controls.cTextBox();
			this.PartNumberTextBox = new CommonLib.Controls.cTextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.ManufacturerCombo = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.TypeCombo = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.AcquisitionGroupBox = new System.Windows.Forms.GroupBox();
			this.PriceTextBox = new CommonLib.Controls.cDoubleValueTextBox();
			this.PurchaseDatePicker = new System.Windows.Forms.DateTimePicker();
			this.PriceLabel = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.OKButton = new System.Windows.Forms.Button();
			this.FormCancelButton = new System.Windows.Forms.Button();
			this.ScopeDetailsGroupBox = new System.Windows.Forms.GroupBox();
			this.ScopeTurretTypeCombo = new System.Windows.Forms.ComboBox();
			this.ScopeClickTextBox = new CommonLib.Controls.cDoubleValueTextBox();
			this.ScopeTubeCombo = new System.Windows.Forms.ComboBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.ScopeObjectiveTextBox = new CommonLib.Controls.cTextBox();
			this.label12 = new System.Windows.Forms.Label();
			this.ScopePowerTextBox = new CommonLib.Controls.cTextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.RedDotDetailsGroupBox = new System.Windows.Forms.GroupBox();
			this.label15 = new System.Windows.Forms.Label();
			this.RedDotTubeSizeTextBox = new CommonLib.Controls.cDoubleValueTextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.RedDotCowitnessTextBox = new CommonLib.Controls.cDoubleValueTextBox();
			this.RedDotMOATextBox = new CommonLib.Controls.cDoubleValueTextBox();
			this.label14 = new System.Windows.Forms.Label();
			this.RedDotBatteryTextBox = new CommonLib.Controls.cTextBox();
			this.label17 = new System.Windows.Forms.Label();
			this.label19 = new System.Windows.Forms.Label();
			this.SourceCombo = new System.Windows.Forms.ComboBox();
			label18 = new System.Windows.Forms.Label();
			this.GeneralGroup.SuspendLayout();
			this.AcquisitionGroupBox.SuspendLayout();
			this.ScopeDetailsGroupBox.SuspendLayout();
			this.RedDotDetailsGroupBox.SuspendLayout();
			this.SuspendLayout();
			// 
			// label18
			// 
			label18.AutoSize = true;
			label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			label18.ForeColor = System.Drawing.SystemColors.ControlText;
			label18.Location = new System.Drawing.Point(153, 51);
			label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			label18.Name = "label18";
			label18.Size = new System.Drawing.Size(64, 13);
			label18.TabIndex = 30;
			label18.Text = "Turret Click:";
			// 
			// GeneralGroup
			// 
			this.GeneralGroup.Controls.Add(this.DescriptionTextBox);
			this.GeneralGroup.Controls.Add(this.SerialNumberTextBox);
			this.GeneralGroup.Controls.Add(this.PartNumberTextBox);
			this.GeneralGroup.Controls.Add(this.label5);
			this.GeneralGroup.Controls.Add(this.label4);
			this.GeneralGroup.Controls.Add(this.label3);
			this.GeneralGroup.Controls.Add(this.ManufacturerCombo);
			this.GeneralGroup.Controls.Add(this.label2);
			this.GeneralGroup.Controls.Add(this.TypeCombo);
			this.GeneralGroup.Controls.Add(this.label1);
			this.GeneralGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.GeneralGroup.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.GeneralGroup.Location = new System.Drawing.Point(12, 12);
			this.GeneralGroup.Name = "GeneralGroup";
			this.GeneralGroup.Size = new System.Drawing.Size(339, 170);
			this.GeneralGroup.TabIndex = 0;
			this.GeneralGroup.TabStop = false;
			this.GeneralGroup.Text = "General";
			// 
			// DescriptionTextBox
			// 
			this.DescriptionTextBox.BackColor = System.Drawing.SystemColors.Window;
			this.DescriptionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.DescriptionTextBox.Location = new System.Drawing.Point(107, 131);
			this.DescriptionTextBox.MaxLength = 35;
			this.DescriptionTextBox.Name = "DescriptionTextBox";
			this.DescriptionTextBox.Required = false;
			this.DescriptionTextBox.Size = new System.Drawing.Size(222, 20);
			this.DescriptionTextBox.TabIndex = 4;
			this.DescriptionTextBox.ToolTip = "";
			this.DescriptionTextBox.ValidChars = "";
			this.DescriptionTextBox.Value = "";
			// 
			// SerialNumberTextBox
			// 
			this.SerialNumberTextBox.BackColor = System.Drawing.SystemColors.Window;
			this.SerialNumberTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.SerialNumberTextBox.Location = new System.Drawing.Point(107, 105);
			this.SerialNumberTextBox.MaxLength = 35;
			this.SerialNumberTextBox.Name = "SerialNumberTextBox";
			this.SerialNumberTextBox.Required = false;
			this.SerialNumberTextBox.Size = new System.Drawing.Size(174, 20);
			this.SerialNumberTextBox.TabIndex = 3;
			this.SerialNumberTextBox.ToolTip = "";
			this.SerialNumberTextBox.ValidChars = "";
			this.SerialNumberTextBox.Value = "";
			// 
			// PartNumberTextBox
			// 
			this.PartNumberTextBox.BackColor = System.Drawing.SystemColors.Window;
			this.PartNumberTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.PartNumberTextBox.Location = new System.Drawing.Point(107, 79);
			this.PartNumberTextBox.MaxLength = 35;
			this.PartNumberTextBox.Name = "PartNumberTextBox";
			this.PartNumberTextBox.Required = false;
			this.PartNumberTextBox.Size = new System.Drawing.Size(174, 20);
			this.PartNumberTextBox.TabIndex = 2;
			this.PartNumberTextBox.ToolTip = "";
			this.PartNumberTextBox.ValidChars = "";
			this.PartNumberTextBox.Value = "";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label5.Location = new System.Drawing.Point(38, 134);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(63, 13);
			this.label5.TabIndex = 8;
			this.label5.Text = "Description:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label4.Location = new System.Drawing.Point(55, 108);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(46, 13);
			this.label4.TabIndex = 6;
			this.label4.Text = "Serial #:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label3.Location = new System.Drawing.Point(28, 82);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(73, 13);
			this.label3.TabIndex = 4;
			this.label3.Text = "Part #/Model:";
			// 
			// ManufacturerCombo
			// 
			this.ManufacturerCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.ManufacturerCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ManufacturerCombo.FormattingEnabled = true;
			this.ManufacturerCombo.Location = new System.Drawing.Point(107, 51);
			this.ManufacturerCombo.Name = "ManufacturerCombo";
			this.ManufacturerCombo.Size = new System.Drawing.Size(174, 21);
			this.ManufacturerCombo.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label2.Location = new System.Drawing.Point(28, 54);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(73, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Manufacturer:";
			// 
			// TypeCombo
			// 
			this.TypeCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.TypeCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TypeCombo.FormattingEnabled = true;
			this.TypeCombo.Items.AddRange(new object[] {
            "Scope",
            "Red Dot",
            "Laser / Light",
            "Trigger",
            "Furniture",
            "Bipod / Monopod",
            "Firearm Parts",
            "Other"});
			this.TypeCombo.Location = new System.Drawing.Point(107, 24);
			this.TypeCombo.Name = "TypeCombo";
			this.TypeCombo.Size = new System.Drawing.Size(174, 21);
			this.TypeCombo.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label1.Location = new System.Drawing.Point(15, 27);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(86, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Accessory Type:";
			// 
			// AcquisitionGroupBox
			// 
			this.AcquisitionGroupBox.Controls.Add(this.SourceCombo);
			this.AcquisitionGroupBox.Controls.Add(this.PriceTextBox);
			this.AcquisitionGroupBox.Controls.Add(this.PurchaseDatePicker);
			this.AcquisitionGroupBox.Controls.Add(this.PriceLabel);
			this.AcquisitionGroupBox.Controls.Add(this.label9);
			this.AcquisitionGroupBox.Controls.Add(this.label10);
			this.AcquisitionGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.AcquisitionGroupBox.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.AcquisitionGroupBox.Location = new System.Drawing.Point(12, 188);
			this.AcquisitionGroupBox.Name = "AcquisitionGroupBox";
			this.AcquisitionGroupBox.Size = new System.Drawing.Size(339, 83);
			this.AcquisitionGroupBox.TabIndex = 1;
			this.AcquisitionGroupBox.TabStop = false;
			this.AcquisitionGroupBox.Text = "Acquisition Details";
			// 
			// PriceTextBox
			// 
			this.PriceTextBox.BackColor = System.Drawing.SystemColors.Window;
			this.PriceTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.PriceTextBox.Location = new System.Drawing.Point(281, 50);
			this.PriceTextBox.MaxValue = 0D;
			this.PriceTextBox.MinValue = 0D;
			this.PriceTextBox.Name = "PriceTextBox";
			this.PriceTextBox.NumDecimals = 0;
			this.PriceTextBox.Size = new System.Drawing.Size(48, 20);
			this.PriceTextBox.TabIndex = 2;
			this.PriceTextBox.Text = "0";
			this.PriceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.PriceTextBox.ToolTip = "";
			this.PriceTextBox.Value = 0D;
			this.PriceTextBox.ZeroAllowed = true;
			// 
			// PurchaseDatePicker
			// 
			this.PurchaseDatePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.PurchaseDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.PurchaseDatePicker.Location = new System.Drawing.Point(107, 50);
			this.PurchaseDatePicker.Name = "PurchaseDatePicker";
			this.PurchaseDatePicker.Size = new System.Drawing.Size(106, 20);
			this.PurchaseDatePicker.TabIndex = 1;
			// 
			// PriceLabel
			// 
			this.PriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.PriceLabel.ForeColor = System.Drawing.SystemColors.ControlText;
			this.PriceLabel.Location = new System.Drawing.Point(219, 53);
			this.PriceLabel.Name = "PriceLabel";
			this.PriceLabel.Size = new System.Drawing.Size(56, 13);
			this.PriceLabel.TabIndex = 4;
			this.PriceLabel.Text = "Price:";
			this.PriceLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label9.Location = new System.Drawing.Point(23, 53);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(81, 13);
			this.label9.TabIndex = 2;
			this.label9.Text = "Purchase Date:";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label10.Location = new System.Drawing.Point(23, 27);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(78, 13);
			this.label10.TabIndex = 0;
			this.label10.Text = "Acquired From:";
			// 
			// OKButton
			// 
			this.OKButton.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.OKButton.Location = new System.Drawing.Point(85, 291);
			this.OKButton.Name = "OKButton";
			this.OKButton.Size = new System.Drawing.Size(75, 23);
			this.OKButton.TabIndex = 3;
			this.OKButton.Text = "OK";
			this.OKButton.UseVisualStyleBackColor = true;
			// 
			// FormCancelButton
			// 
			this.FormCancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.FormCancelButton.Location = new System.Drawing.Point(201, 291);
			this.FormCancelButton.Name = "FormCancelButton";
			this.FormCancelButton.Size = new System.Drawing.Size(75, 23);
			this.FormCancelButton.TabIndex = 4;
			this.FormCancelButton.Text = "Cancel";
			this.FormCancelButton.UseVisualStyleBackColor = true;
			// 
			// ScopeDetailsGroupBox
			// 
			this.ScopeDetailsGroupBox.Controls.Add(this.ScopeTurretTypeCombo);
			this.ScopeDetailsGroupBox.Controls.Add(this.ScopeClickTextBox);
			this.ScopeDetailsGroupBox.Controls.Add(label18);
			this.ScopeDetailsGroupBox.Controls.Add(this.ScopeTubeCombo);
			this.ScopeDetailsGroupBox.Controls.Add(this.label7);
			this.ScopeDetailsGroupBox.Controls.Add(this.label6);
			this.ScopeDetailsGroupBox.Controls.Add(this.label13);
			this.ScopeDetailsGroupBox.Controls.Add(this.ScopeObjectiveTextBox);
			this.ScopeDetailsGroupBox.Controls.Add(this.label12);
			this.ScopeDetailsGroupBox.Controls.Add(this.ScopePowerTextBox);
			this.ScopeDetailsGroupBox.Controls.Add(this.label11);
			this.ScopeDetailsGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ScopeDetailsGroupBox.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.ScopeDetailsGroupBox.Location = new System.Drawing.Point(392, 12);
			this.ScopeDetailsGroupBox.Name = "ScopeDetailsGroupBox";
			this.ScopeDetailsGroupBox.Size = new System.Drawing.Size(339, 85);
			this.ScopeDetailsGroupBox.TabIndex = 2;
			this.ScopeDetailsGroupBox.TabStop = false;
			this.ScopeDetailsGroupBox.Text = "Scope Details";
			this.ScopeDetailsGroupBox.Visible = false;
			// 
			// ScopeTurretTypeCombo
			// 
			this.ScopeTurretTypeCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.ScopeTurretTypeCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ScopeTurretTypeCombo.ForeColor = System.Drawing.SystemColors.WindowText;
			this.ScopeTurretTypeCombo.FormattingEnabled = true;
			this.ScopeTurretTypeCombo.Items.AddRange(new object[] {
            "MOA",
            "Mil"});
			this.ScopeTurretTypeCombo.Location = new System.Drawing.Point(265, 48);
			this.ScopeTurretTypeCombo.Margin = new System.Windows.Forms.Padding(2);
			this.ScopeTurretTypeCombo.Name = "ScopeTurretTypeCombo";
			this.ScopeTurretTypeCombo.Size = new System.Drawing.Size(55, 21);
			this.ScopeTurretTypeCombo.TabIndex = 4;
			// 
			// ScopeClickTextBox
			// 
			this.ScopeClickTextBox.BackColor = System.Drawing.SystemColors.Window;
			this.ScopeClickTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ScopeClickTextBox.Location = new System.Drawing.Point(222, 48);
			this.ScopeClickTextBox.MaxLength = 5;
			this.ScopeClickTextBox.MaxValue = 0D;
			this.ScopeClickTextBox.MinValue = 0D;
			this.ScopeClickTextBox.Name = "ScopeClickTextBox";
			this.ScopeClickTextBox.NumDecimals = 3;
			this.ScopeClickTextBox.Size = new System.Drawing.Size(38, 20);
			this.ScopeClickTextBox.TabIndex = 3;
			this.ScopeClickTextBox.Text = "0.000";
			this.ScopeClickTextBox.ToolTip = "";
			this.ScopeClickTextBox.Value = 0D;
			this.ScopeClickTextBox.ZeroAllowed = true;
			// 
			// ScopeTubeCombo
			// 
			this.ScopeTubeCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.ScopeTubeCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ScopeTubeCombo.FormattingEnabled = true;
			this.ScopeTubeCombo.Items.AddRange(new object[] {
            "1 Inch",
            "30 mm"});
			this.ScopeTubeCombo.Location = new System.Drawing.Point(65, 48);
			this.ScopeTubeCombo.Name = "ScopeTubeCombo";
			this.ScopeTubeCombo.Size = new System.Drawing.Size(80, 21);
			this.ScopeTubeCombo.TabIndex = 2;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label7.Location = new System.Drawing.Point(24, 51);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(35, 13);
			this.label7.TabIndex = 10;
			this.label7.Text = "Tube:";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label6.Location = new System.Drawing.Point(274, 27);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(23, 13);
			this.label6.TabIndex = 9;
			this.label6.Text = "mm";
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label13.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label13.Location = new System.Drawing.Point(126, 27);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(12, 13);
			this.label13.TabIndex = 8;
			this.label13.Text = "x";
			// 
			// ScopeObjectiveTextBox
			// 
			this.ScopeObjectiveTextBox.BackColor = System.Drawing.SystemColors.Window;
			this.ScopeObjectiveTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ScopeObjectiveTextBox.Location = new System.Drawing.Point(222, 24);
			this.ScopeObjectiveTextBox.MaxLength = 2;
			this.ScopeObjectiveTextBox.Name = "ScopeObjectiveTextBox";
			this.ScopeObjectiveTextBox.Required = false;
			this.ScopeObjectiveTextBox.Size = new System.Drawing.Size(46, 20);
			this.ScopeObjectiveTextBox.TabIndex = 1;
			this.ScopeObjectiveTextBox.ToolTip = "";
			this.ScopeObjectiveTextBox.ValidChars = "";
			this.ScopeObjectiveTextBox.Value = "";
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label12.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label12.Location = new System.Drawing.Point(161, 27);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(55, 13);
			this.label12.TabIndex = 6;
			this.label12.Text = "Objective:";
			// 
			// ScopePowerTextBox
			// 
			this.ScopePowerTextBox.BackColor = System.Drawing.SystemColors.Window;
			this.ScopePowerTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ScopePowerTextBox.Location = new System.Drawing.Point(65, 24);
			this.ScopePowerTextBox.MaxLength = 5;
			this.ScopePowerTextBox.Name = "ScopePowerTextBox";
			this.ScopePowerTextBox.Required = false;
			this.ScopePowerTextBox.Size = new System.Drawing.Size(55, 20);
			this.ScopePowerTextBox.TabIndex = 0;
			this.ScopePowerTextBox.ToolTip = "";
			this.ScopePowerTextBox.ValidChars = "";
			this.ScopePowerTextBox.Value = "";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label11.Location = new System.Drawing.Point(19, 27);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(40, 13);
			this.label11.TabIndex = 0;
			this.label11.Text = "Power:";
			// 
			// RedDotDetailsGroupBox
			// 
			this.RedDotDetailsGroupBox.Controls.Add(this.label15);
			this.RedDotDetailsGroupBox.Controls.Add(this.RedDotTubeSizeTextBox);
			this.RedDotDetailsGroupBox.Controls.Add(this.label8);
			this.RedDotDetailsGroupBox.Controls.Add(this.RedDotCowitnessTextBox);
			this.RedDotDetailsGroupBox.Controls.Add(this.RedDotMOATextBox);
			this.RedDotDetailsGroupBox.Controls.Add(this.label14);
			this.RedDotDetailsGroupBox.Controls.Add(this.RedDotBatteryTextBox);
			this.RedDotDetailsGroupBox.Controls.Add(this.label17);
			this.RedDotDetailsGroupBox.Controls.Add(this.label19);
			this.RedDotDetailsGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.RedDotDetailsGroupBox.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.RedDotDetailsGroupBox.Location = new System.Drawing.Point(392, 103);
			this.RedDotDetailsGroupBox.Name = "RedDotDetailsGroupBox";
			this.RedDotDetailsGroupBox.Size = new System.Drawing.Size(339, 85);
			this.RedDotDetailsGroupBox.TabIndex = 2;
			this.RedDotDetailsGroupBox.TabStop = false;
			this.RedDotDetailsGroupBox.Text = "Red Dot Details";
			this.RedDotDetailsGroupBox.Visible = false;
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label15.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label15.Location = new System.Drawing.Point(126, 53);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(23, 13);
			this.label15.TabIndex = 36;
			this.label15.Text = "mm";
			// 
			// RedDotTubeSizeTextBox
			// 
			this.RedDotTubeSizeTextBox.BackColor = System.Drawing.SystemColors.Window;
			this.RedDotTubeSizeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.RedDotTubeSizeTextBox.Location = new System.Drawing.Point(80, 50);
			this.RedDotTubeSizeTextBox.MaxValue = 0D;
			this.RedDotTubeSizeTextBox.MinValue = 0D;
			this.RedDotTubeSizeTextBox.Name = "RedDotTubeSizeTextBox";
			this.RedDotTubeSizeTextBox.NumDecimals = 0;
			this.RedDotTubeSizeTextBox.Size = new System.Drawing.Size(40, 20);
			this.RedDotTubeSizeTextBox.TabIndex = 2;
			this.RedDotTubeSizeTextBox.Text = "0";
			this.RedDotTubeSizeTextBox.ToolTip = "";
			this.RedDotTubeSizeTextBox.Value = 0D;
			this.RedDotTubeSizeTextBox.ZeroAllowed = true;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label8.Location = new System.Drawing.Point(17, 53);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(56, 13);
			this.label8.TabIndex = 34;
			this.label8.Text = "Tube size:";
			// 
			// RedDotCowitnessTextBox
			// 
			this.RedDotCowitnessTextBox.BackColor = System.Drawing.SystemColors.Window;
			this.RedDotCowitnessTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.RedDotCowitnessTextBox.Location = new System.Drawing.Point(229, 24);
			this.RedDotCowitnessTextBox.MaxLength = 6;
			this.RedDotCowitnessTextBox.MaxValue = 0D;
			this.RedDotCowitnessTextBox.MinValue = 0D;
			this.RedDotCowitnessTextBox.Name = "RedDotCowitnessTextBox";
			this.RedDotCowitnessTextBox.NumDecimals = 2;
			this.RedDotCowitnessTextBox.Size = new System.Drawing.Size(51, 20);
			this.RedDotCowitnessTextBox.TabIndex = 1;
			this.RedDotCowitnessTextBox.Text = "0.00";
			this.RedDotCowitnessTextBox.ToolTip = "";
			this.RedDotCowitnessTextBox.Value = 0D;
			this.RedDotCowitnessTextBox.ZeroAllowed = true;
			// 
			// RedDotMOATextBox
			// 
			this.RedDotMOATextBox.BackColor = System.Drawing.SystemColors.Window;
			this.RedDotMOATextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.RedDotMOATextBox.Location = new System.Drawing.Point(79, 24);
			this.RedDotMOATextBox.MaxLength = 4;
			this.RedDotMOATextBox.MaxValue = 0D;
			this.RedDotMOATextBox.MinValue = 0D;
			this.RedDotMOATextBox.Name = "RedDotMOATextBox";
			this.RedDotMOATextBox.NumDecimals = 1;
			this.RedDotMOATextBox.Size = new System.Drawing.Size(29, 20);
			this.RedDotMOATextBox.TabIndex = 0;
			this.RedDotMOATextBox.Text = "0.0";
			this.RedDotMOATextBox.ToolTip = "";
			this.RedDotMOATextBox.Value = 0D;
			this.RedDotMOATextBox.ZeroAllowed = true;
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label14.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label14.Location = new System.Drawing.Point(125, 27);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(98, 13);
			this.label14.TabIndex = 10;
			this.label14.Text = "Co-Witness Height:";
			// 
			// RedDotBatteryTextBox
			// 
			this.RedDotBatteryTextBox.BackColor = System.Drawing.SystemColors.Window;
			this.RedDotBatteryTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.RedDotBatteryTextBox.Location = new System.Drawing.Point(229, 50);
			this.RedDotBatteryTextBox.MaxLength = 20;
			this.RedDotBatteryTextBox.Name = "RedDotBatteryTextBox";
			this.RedDotBatteryTextBox.Required = false;
			this.RedDotBatteryTextBox.Size = new System.Drawing.Size(85, 20);
			this.RedDotBatteryTextBox.TabIndex = 3;
			this.RedDotBatteryTextBox.ToolTip = "";
			this.RedDotBatteryTextBox.ValidChars = "";
			this.RedDotBatteryTextBox.Value = "";
			// 
			// label17
			// 
			this.label17.AutoSize = true;
			this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label17.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label17.Location = new System.Drawing.Point(180, 53);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(43, 13);
			this.label17.TabIndex = 6;
			this.label17.Text = "Battery:";
			// 
			// label19
			// 
			this.label19.AutoSize = true;
			this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label19.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label19.Location = new System.Drawing.Point(19, 27);
			this.label19.Name = "label19";
			this.label19.Size = new System.Drawing.Size(54, 13);
			this.label19.TabIndex = 0;
			this.label19.Text = "Dot MOA:";
			// 
			// SourceCombo
			// 
			this.SourceCombo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.SourceCombo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.SourceCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.SourceCombo.FormattingEnabled = true;
			this.SourceCombo.Location = new System.Drawing.Point(107, 24);
			this.SourceCombo.Name = "SourceCombo";
			this.SourceCombo.Size = new System.Drawing.Size(222, 21);
			this.SourceCombo.TabIndex = 5;
			// 
			// cFirearmAccessoryForm
			// 
			this.AcceptButton = this.OKButton;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.FormCancelButton;
			this.ClientSize = new System.Drawing.Size(750, 321);
			this.ControlBox = false;
			this.Controls.Add(this.RedDotDetailsGroupBox);
			this.Controls.Add(this.ScopeDetailsGroupBox);
			this.Controls.Add(this.FormCancelButton);
			this.Controls.Add(this.OKButton);
			this.Controls.Add(this.AcquisitionGroupBox);
			this.Controls.Add(this.GeneralGroup);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "cFirearmAccessoryForm";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Add Firearm Accessory";
			this.GeneralGroup.ResumeLayout(false);
			this.GeneralGroup.PerformLayout();
			this.AcquisitionGroupBox.ResumeLayout(false);
			this.AcquisitionGroupBox.PerformLayout();
			this.ScopeDetailsGroupBox.ResumeLayout(false);
			this.ScopeDetailsGroupBox.PerformLayout();
			this.RedDotDetailsGroupBox.ResumeLayout(false);
			this.RedDotDetailsGroupBox.PerformLayout();
			this.ResumeLayout(false);

			}

		#endregion

		private System.Windows.Forms.GroupBox GeneralGroup;
		private System.Windows.Forms.ComboBox TypeCombo;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox ManufacturerCombo;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.GroupBox AcquisitionGroupBox;
		private CommonLib.Controls.cDoubleValueTextBox PriceTextBox;
		private System.Windows.Forms.DateTimePicker PurchaseDatePicker;
		private System.Windows.Forms.Label PriceLabel;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Button OKButton;
		private System.Windows.Forms.Button FormCancelButton;
		private CommonLib.Controls.cTextBox DescriptionTextBox;
		private CommonLib.Controls.cTextBox SerialNumberTextBox;
		private CommonLib.Controls.cTextBox PartNumberTextBox;
		private System.Windows.Forms.GroupBox ScopeDetailsGroupBox;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.ComboBox ScopeTubeCombo;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label13;
		private CommonLib.Controls.cTextBox ScopeObjectiveTextBox;
		private System.Windows.Forms.Label label12;
		private CommonLib.Controls.cTextBox ScopePowerTextBox;
		private System.Windows.Forms.ComboBox ScopeTurretTypeCombo;
		private CommonLib.Controls.cDoubleValueTextBox ScopeClickTextBox;
		private System.Windows.Forms.GroupBox RedDotDetailsGroupBox;
		private System.Windows.Forms.Label label15;
		private CommonLib.Controls.cDoubleValueTextBox RedDotTubeSizeTextBox;
		private System.Windows.Forms.Label label8;
		private CommonLib.Controls.cDoubleValueTextBox RedDotCowitnessTextBox;
		private CommonLib.Controls.cDoubleValueTextBox RedDotMOATextBox;
		private System.Windows.Forms.Label label14;
		private CommonLib.Controls.cTextBox RedDotBatteryTextBox;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.Label label19;
		private System.Windows.Forms.ComboBox SourceCombo;
		}
	}