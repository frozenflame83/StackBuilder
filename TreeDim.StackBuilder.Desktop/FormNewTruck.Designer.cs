﻿namespace TreeDim.StackBuilder.Desktop
{
    partial class FormNewTruck
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNewTruck));
            this.bnCancel = new System.Windows.Forms.Button();
            this.bnAccept = new System.Windows.Forms.Button();
            this.trackBarHorizAngle = new System.Windows.Forms.TrackBar();
            this.tbPalletProperties = new System.Windows.Forms.TextBox();
            this.cbTruck = new System.Windows.Forms.ComboBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.lbDescription = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.radioButtonTruck2 = new System.Windows.Forms.RadioButton();
            this.radioButtonTruck1 = new System.Windows.Forms.RadioButton();
            this.lbMm3 = new System.Windows.Forms.Label();
            this.lbMm2 = new System.Windows.Forms.Label();
            this.lbMm1 = new System.Windows.Forms.Label();
            this.nudHeight = new System.Windows.Forms.NumericUpDown();
            this.nudWidth = new System.Windows.Forms.NumericUpDown();
            this.nudLength = new System.Windows.Forms.NumericUpDown();
            this.lbHeight = new System.Windows.Forms.Label();
            this.lbWidth = new System.Windows.Forms.Label();
            this.lbLength = new System.Windows.Forms.Label();
            this.cbColor = new OfficePickers.ColorPicker.ComboBoxColorPicker();
            this.lbColor = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nudAdmissibleLoadWeight = new System.Windows.Forms.NumericUpDown();
            this.lbKg = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarHorizAngle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAdmissibleLoadWeight)).BeginInit();
            this.SuspendLayout();
            // 
            // bnCancel
            // 
            this.bnCancel.AccessibleDescription = null;
            this.bnCancel.AccessibleName = null;
            resources.ApplyResources(this.bnCancel, "bnCancel");
            this.bnCancel.BackgroundImage = null;
            this.bnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bnCancel.Font = null;
            this.bnCancel.Name = "bnCancel";
            this.bnCancel.UseVisualStyleBackColor = true;
            // 
            // bnAccept
            // 
            this.bnAccept.AccessibleDescription = null;
            this.bnAccept.AccessibleName = null;
            resources.ApplyResources(this.bnAccept, "bnAccept");
            this.bnAccept.BackgroundImage = null;
            this.bnAccept.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.bnAccept.Font = null;
            this.bnAccept.Name = "bnAccept";
            this.bnAccept.UseVisualStyleBackColor = true;
            // 
            // trackBarHorizAngle
            // 
            this.trackBarHorizAngle.AccessibleDescription = null;
            this.trackBarHorizAngle.AccessibleName = null;
            resources.ApplyResources(this.trackBarHorizAngle, "trackBarHorizAngle");
            this.trackBarHorizAngle.BackgroundImage = null;
            this.trackBarHorizAngle.Font = null;
            this.trackBarHorizAngle.Maximum = 360;
            this.trackBarHorizAngle.Name = "trackBarHorizAngle";
            this.trackBarHorizAngle.TickFrequency = 90;
            this.trackBarHorizAngle.Value = 45;
            this.trackBarHorizAngle.ValueChanged += new System.EventHandler(this.onHorizAngleChanged);
            // 
            // tbPalletProperties
            // 
            this.tbPalletProperties.AccessibleDescription = null;
            this.tbPalletProperties.AccessibleName = null;
            resources.ApplyResources(this.tbPalletProperties, "tbPalletProperties");
            this.tbPalletProperties.BackgroundImage = null;
            this.tbPalletProperties.Font = null;
            this.tbPalletProperties.Name = "tbPalletProperties";
            this.tbPalletProperties.ReadOnly = true;
            // 
            // cbTruck
            // 
            this.cbTruck.AccessibleDescription = null;
            this.cbTruck.AccessibleName = null;
            resources.ApplyResources(this.cbTruck, "cbTruck");
            this.cbTruck.BackgroundImage = null;
            this.cbTruck.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTruck.Font = null;
            this.cbTruck.FormattingEnabled = true;
            this.cbTruck.Name = "cbTruck";
            // 
            // tbName
            // 
            this.tbName.AccessibleDescription = null;
            this.tbName.AccessibleName = null;
            resources.ApplyResources(this.tbName, "tbName");
            this.tbName.BackgroundImage = null;
            this.tbName.Font = null;
            this.tbName.Name = "tbName";
            this.tbName.TextChanged += new System.EventHandler(this.onNameDescriptionChanged);
            // 
            // tbDescription
            // 
            this.tbDescription.AccessibleDescription = null;
            this.tbDescription.AccessibleName = null;
            resources.ApplyResources(this.tbDescription, "tbDescription");
            this.tbDescription.BackgroundImage = null;
            this.tbDescription.Font = null;
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.TextChanged += new System.EventHandler(this.onNameDescriptionChanged);
            // 
            // lbDescription
            // 
            this.lbDescription.AccessibleDescription = null;
            this.lbDescription.AccessibleName = null;
            resources.ApplyResources(this.lbDescription, "lbDescription");
            this.lbDescription.Font = null;
            this.lbDescription.Name = "lbDescription";
            // 
            // lbName
            // 
            this.lbName.AccessibleDescription = null;
            this.lbName.AccessibleName = null;
            resources.ApplyResources(this.lbName, "lbName");
            this.lbName.Font = null;
            this.lbName.Name = "lbName";
            // 
            // radioButtonTruck2
            // 
            this.radioButtonTruck2.AccessibleDescription = null;
            this.radioButtonTruck2.AccessibleName = null;
            resources.ApplyResources(this.radioButtonTruck2, "radioButtonTruck2");
            this.radioButtonTruck2.BackgroundImage = null;
            this.radioButtonTruck2.Font = null;
            this.radioButtonTruck2.Name = "radioButtonTruck2";
            this.radioButtonTruck2.TabStop = true;
            this.radioButtonTruck2.UseVisualStyleBackColor = true;
            // 
            // radioButtonTruck1
            // 
            this.radioButtonTruck1.AccessibleDescription = null;
            this.radioButtonTruck1.AccessibleName = null;
            resources.ApplyResources(this.radioButtonTruck1, "radioButtonTruck1");
            this.radioButtonTruck1.BackgroundImage = null;
            this.radioButtonTruck1.Font = null;
            this.radioButtonTruck1.Name = "radioButtonTruck1";
            this.radioButtonTruck1.TabStop = true;
            this.radioButtonTruck1.UseVisualStyleBackColor = true;
            // 
            // lbMm3
            // 
            this.lbMm3.AccessibleDescription = null;
            this.lbMm3.AccessibleName = null;
            resources.ApplyResources(this.lbMm3, "lbMm3");
            this.lbMm3.Font = null;
            this.lbMm3.Name = "lbMm3";
            // 
            // lbMm2
            // 
            this.lbMm2.AccessibleDescription = null;
            this.lbMm2.AccessibleName = null;
            resources.ApplyResources(this.lbMm2, "lbMm2");
            this.lbMm2.Font = null;
            this.lbMm2.Name = "lbMm2";
            // 
            // lbMm1
            // 
            this.lbMm1.AccessibleDescription = null;
            this.lbMm1.AccessibleName = null;
            resources.ApplyResources(this.lbMm1, "lbMm1");
            this.lbMm1.Font = null;
            this.lbMm1.Name = "lbMm1";
            // 
            // nudHeight
            // 
            this.nudHeight.AccessibleDescription = null;
            this.nudHeight.AccessibleName = null;
            resources.ApplyResources(this.nudHeight, "nudHeight");
            this.nudHeight.Font = null;
            this.nudHeight.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudHeight.Name = "nudHeight";
            this.nudHeight.ValueChanged += new System.EventHandler(this.onTruckPropertyChanged);
            // 
            // nudWidth
            // 
            this.nudWidth.AccessibleDescription = null;
            this.nudWidth.AccessibleName = null;
            resources.ApplyResources(this.nudWidth, "nudWidth");
            this.nudWidth.Font = null;
            this.nudWidth.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudWidth.Name = "nudWidth";
            this.nudWidth.ValueChanged += new System.EventHandler(this.onTruckPropertyChanged);
            // 
            // nudLength
            // 
            this.nudLength.AccessibleDescription = null;
            this.nudLength.AccessibleName = null;
            resources.ApplyResources(this.nudLength, "nudLength");
            this.nudLength.Font = null;
            this.nudLength.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudLength.Name = "nudLength";
            this.nudLength.ValueChanged += new System.EventHandler(this.onTruckPropertyChanged);
            // 
            // lbHeight
            // 
            this.lbHeight.AccessibleDescription = null;
            this.lbHeight.AccessibleName = null;
            resources.ApplyResources(this.lbHeight, "lbHeight");
            this.lbHeight.Font = null;
            this.lbHeight.Name = "lbHeight";
            // 
            // lbWidth
            // 
            this.lbWidth.AccessibleDescription = null;
            this.lbWidth.AccessibleName = null;
            resources.ApplyResources(this.lbWidth, "lbWidth");
            this.lbWidth.Font = null;
            this.lbWidth.Name = "lbWidth";
            // 
            // lbLength
            // 
            this.lbLength.AccessibleDescription = null;
            this.lbLength.AccessibleName = null;
            resources.ApplyResources(this.lbLength, "lbLength");
            this.lbLength.Font = null;
            this.lbLength.Name = "lbLength";
            // 
            // cbColor
            // 
            this.cbColor.AccessibleDescription = null;
            this.cbColor.AccessibleName = null;
            resources.ApplyResources(this.cbColor, "cbColor");
            this.cbColor.BackgroundImage = null;
            this.cbColor.Color = System.Drawing.Color.Gold;
            this.cbColor.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbColor.DropDownHeight = 1;
            this.cbColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbColor.DropDownWidth = 1;
            this.cbColor.Font = null;
            this.cbColor.FormattingEnabled = true;
            this.cbColor.Items.AddRange(new object[] {
            resources.GetString("cbColor.Items"),
            resources.GetString("cbColor.Items1"),
            resources.GetString("cbColor.Items2"),
            resources.GetString("cbColor.Items3"),
            resources.GetString("cbColor.Items4"),
            resources.GetString("cbColor.Items5"),
            resources.GetString("cbColor.Items6"),
            resources.GetString("cbColor.Items7"),
            resources.GetString("cbColor.Items8"),
            resources.GetString("cbColor.Items9"),
            resources.GetString("cbColor.Items10"),
            resources.GetString("cbColor.Items11"),
            resources.GetString("cbColor.Items12")});
            this.cbColor.Name = "cbColor";
            this.cbColor.SelectedColorChanged += new System.EventHandler(this.onTruckPropertyChanged);
            // 
            // lbColor
            // 
            this.lbColor.AccessibleDescription = null;
            this.lbColor.AccessibleName = null;
            resources.ApplyResources(this.lbColor, "lbColor");
            this.lbColor.Font = null;
            this.lbColor.Name = "lbColor";
            // 
            // pictureBox
            // 
            this.pictureBox.AccessibleDescription = null;
            this.pictureBox.AccessibleName = null;
            resources.ApplyResources(this.pictureBox, "pictureBox");
            this.pictureBox.BackgroundImage = null;
            this.pictureBox.Font = null;
            this.pictureBox.ImageLocation = null;
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.TabStop = false;
            // 
            // label1
            // 
            this.label1.AccessibleDescription = null;
            this.label1.AccessibleName = null;
            resources.ApplyResources(this.label1, "label1");
            this.label1.Font = null;
            this.label1.Name = "label1";
            // 
            // nudAdmissibleLoadWeight
            // 
            this.nudAdmissibleLoadWeight.AccessibleDescription = null;
            this.nudAdmissibleLoadWeight.AccessibleName = null;
            resources.ApplyResources(this.nudAdmissibleLoadWeight, "nudAdmissibleLoadWeight");
            this.nudAdmissibleLoadWeight.Font = null;
            this.nudAdmissibleLoadWeight.Name = "nudAdmissibleLoadWeight";
            this.nudAdmissibleLoadWeight.ValueChanged += new System.EventHandler(this.onTruckPropertyChanged);
            // 
            // lbKg
            // 
            this.lbKg.AccessibleDescription = null;
            this.lbKg.AccessibleName = null;
            resources.ApplyResources(this.lbKg, "lbKg");
            this.lbKg.Font = null;
            this.lbKg.Name = "lbKg";
            // 
            // FormNewTruck
            // 
            this.AccessibleDescription = null;
            this.AccessibleName = null;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = null;
            this.Controls.Add(this.lbKg);
            this.Controls.Add(this.nudAdmissibleLoadWeight);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbColor);
            this.Controls.Add(this.lbColor);
            this.Controls.Add(this.lbMm3);
            this.Controls.Add(this.lbMm2);
            this.Controls.Add(this.lbMm1);
            this.Controls.Add(this.nudHeight);
            this.Controls.Add(this.nudWidth);
            this.Controls.Add(this.nudLength);
            this.Controls.Add(this.lbHeight);
            this.Controls.Add(this.lbWidth);
            this.Controls.Add(this.lbLength);
            this.Controls.Add(this.tbPalletProperties);
            this.Controls.Add(this.cbTruck);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.tbDescription);
            this.Controls.Add(this.lbDescription);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.radioButtonTruck2);
            this.Controls.Add(this.radioButtonTruck1);
            this.Controls.Add(this.trackBarHorizAngle);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.bnCancel);
            this.Controls.Add(this.bnAccept);
            this.Font = null;
            this.Icon = null;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormNewTruck";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Load += new System.EventHandler(this.FormNewTruck_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormNewTruck_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarHorizAngle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAdmissibleLoadWeight)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bnCancel;
        private System.Windows.Forms.Button bnAccept;
        private System.Windows.Forms.TrackBar trackBarHorizAngle;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.TextBox tbPalletProperties;
        private System.Windows.Forms.ComboBox cbTruck;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbDescription;
        private System.Windows.Forms.Label lbDescription;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.RadioButton radioButtonTruck2;
        private System.Windows.Forms.RadioButton radioButtonTruck1;
        private System.Windows.Forms.Label lbMm3;
        private System.Windows.Forms.Label lbMm2;
        private System.Windows.Forms.Label lbMm1;
        private System.Windows.Forms.NumericUpDown nudHeight;
        private System.Windows.Forms.NumericUpDown nudWidth;
        private System.Windows.Forms.NumericUpDown nudLength;
        private System.Windows.Forms.Label lbHeight;
        private System.Windows.Forms.Label lbWidth;
        private System.Windows.Forms.Label lbLength;
        private OfficePickers.ColorPicker.ComboBoxColorPicker cbColor;
        private System.Windows.Forms.Label lbColor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudAdmissibleLoadWeight;
        private System.Windows.Forms.Label lbKg;
    }
}