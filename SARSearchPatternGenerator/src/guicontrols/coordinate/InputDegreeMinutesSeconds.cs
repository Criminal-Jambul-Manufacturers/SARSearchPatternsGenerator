﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SARSearchPatternGenerator
{
    [Designer("System.Windows.Forms.Design.ParentControlDesigner, System.Design", typeof(IDesigner))]
    public class InputDegreeMinutesSeconds : InputCoordinate
    {
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private FloatInput floatInput4;
        private FloatInput floatInput3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private FloatInput floatInput1;
        private FloatInput floatInput2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private FloatInput floatInput5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private FloatInput floatInput6;
        private ButtonToggle buttonToggle2;
        private ButtonToggle buttonToggle1;
        private GroupBox groupBox1;
        private System.Windows.Forms.Label label5;

        public InputDegreeMinutesSeconds(): base()
        {
            InitializeComponent();
            modifyComponent();
        }

        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.floatInput4 = new SARSearchPatternGenerator.FloatInput();
            this.floatInput3 = new SARSearchPatternGenerator.FloatInput();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.floatInput1 = new SARSearchPatternGenerator.FloatInput();
            this.floatInput2 = new SARSearchPatternGenerator.FloatInput();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.floatInput5 = new SARSearchPatternGenerator.FloatInput();
            this.floatInput6 = new SARSearchPatternGenerator.FloatInput();
            this.buttonToggle2 = new SARSearchPatternGenerator.ButtonToggle();
            this.buttonToggle1 = new SARSearchPatternGenerator.ButtonToggle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 8;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.47761F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.79104F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.07692F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.76923F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel1.Controls.Add(this.label8, 6, 1);
            this.tableLayoutPanel1.Controls.Add(this.label7, 6, 0);
            this.tableLayoutPanel1.Controls.Add(this.floatInput4, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.floatInput3, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.label6, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.label4, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.floatInput1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.floatInput2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label5, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.floatInput5, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.floatInput6, 5, 1);
            this.tableLayoutPanel1.Controls.Add(this.buttonToggle2, 7, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonToggle1, 7, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 21);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(435, 66);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(374, 41);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 17);
            this.label8.TabIndex = 12;
            this.label8.Text = "sec";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(374, 8);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 17);
            this.label7.TabIndex = 11;
            this.label7.Text = "sec";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // floatInput4
            // 
            this.floatInput4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.floatInput4.Location = new System.Drawing.Point(177, 36);
            this.floatInput4.Name = "floatInput4";
            this.floatInput4.precision = 3;
            this.floatInput4.Size = new System.Drawing.Size(62, 22);
            this.floatInput4.TabIndex = 1;
            this.floatInput4.Text = "0";
            // 
            // floatInput3
            // 
            this.floatInput3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.floatInput3.Location = new System.Drawing.Point(177, 3);
            this.floatInput3.Name = "floatInput3";
            this.floatInput3.precision = 3;
            this.floatInput3.Size = new System.Drawing.Size(62, 22);
            this.floatInput3.TabIndex = 1;
            this.floatInput3.Text = "0";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(245, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "min";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(139, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "deg";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // floatInput1
            // 
            this.floatInput1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.floatInput1.Location = new System.Drawing.Point(90, 3);
            this.floatInput1.Name = "floatInput1";
            this.floatInput1.precision = 3;
            this.floatInput1.Size = new System.Drawing.Size(43, 22);
            this.floatInput1.TabIndex = 0;
            this.floatInput1.Text = "0";
            // 
            // floatInput2
            // 
            this.floatInput2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.floatInput2.Location = new System.Drawing.Point(90, 36);
            this.floatInput2.Name = "floatInput2";
            this.floatInput2.precision = 3;
            this.floatInput2.Size = new System.Drawing.Size(43, 22);
            this.floatInput2.TabIndex = 0;
            this.floatInput2.Text = "0";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Latitude:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Longitude:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(139, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "deg";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(245, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "min";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // floatInput5
            // 
            this.floatInput5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.floatInput5.Location = new System.Drawing.Point(283, 3);
            this.floatInput5.Name = "floatInput5";
            this.floatInput5.precision = 4;
            this.floatInput5.Size = new System.Drawing.Size(85, 22);
            this.floatInput5.TabIndex = 9;
            this.floatInput5.Text = "0";
            // 
            // floatInput6
            // 
            this.floatInput6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.floatInput6.Location = new System.Drawing.Point(283, 36);
            this.floatInput6.Name = "floatInput6";
            this.floatInput6.precision = 4;
            this.floatInput6.Size = new System.Drawing.Size(85, 22);
            this.floatInput6.TabIndex = 10;
            this.floatInput6.Text = "0";
            // 
            // buttonToggle2
            // 
            this.buttonToggle2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonToggle2.Location = new System.Drawing.Point(410, 4);
            this.buttonToggle2.Name = "buttonToggle2";
            this.buttonToggle2.offText = "N";
            this.buttonToggle2.onText = "S";
            this.buttonToggle2.Size = new System.Drawing.Size(21, 25);
            this.buttonToggle2.TabIndex = 13;
            this.buttonToggle2.Text = "N";
            // 
            // buttonToggle1
            // 
            this.buttonToggle1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonToggle1.Location = new System.Drawing.Point(410, 38);
            this.buttonToggle1.Name = "buttonToggle1";
            this.buttonToggle1.offText = "W";
            this.buttonToggle1.onText = "E";
            this.buttonToggle1.Size = new System.Drawing.Size(21, 22);
            this.buttonToggle1.TabIndex = 14;
            this.buttonToggle1.Text = "W";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(447, 93);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // InputDegreeMinutesSeconds
            // 
            this.Controls.Add(this.groupBox1);
            this.Name = "InputDegreeMinutesSeconds";
            this.Size = new System.Drawing.Size(453, 99);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        private void modifyComponent()
        {
            this.floatInput1.setValue(0);
            this.floatInput2.setValue(0);
            this.floatInput3.setValue(0);
            this.floatInput4.setValue(0);
            this.floatInput5.setValue(0);
            this.floatInput6.setValue(0);
            this.updateValue();
            this.floatInput1.TextChanged += onChange;
            this.floatInput2.TextChanged += onChange;
            this.floatInput3.TextChanged += onChange;
            this.floatInput4.TextChanged += onChange;
            this.floatInput5.TextChanged += onChange;
            this.floatInput6.TextChanged += onChange;
            this.buttonToggle1.Click += onChange;
            this.buttonToggle2.Click += onChange;
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        protected override void repopulateFields()
        {
            double lat = this.value.getLat();
            double lng = this.value.getLng();
            buttonToggle2.setState(lat < 0);
            buttonToggle1.setState(lng > 0);
            this.floatInput1.TextChanged -= onChange;
            this.floatInput2.TextChanged -= onChange;
            this.floatInput3.TextChanged -= onChange;
            this.floatInput4.TextChanged -= onChange;
            this.floatInput5.TextChanged -= onChange;
            this.floatInput6.TextChanged -= onChange;
            floatInput1.setValue(((DegMinSec)this.value).getLatDeg() * (buttonToggle2.isEnabled() ? -1 : 1));
            floatInput2.setValue(((DegMinSec)this.value).getLngDeg() * (buttonToggle1.isEnabled() ? 1 : -1));
            floatInput3.setValue(((DegMinSec)this.value).getLatMin() * (buttonToggle2.isEnabled() ? -1 : 1));
            floatInput4.setValue(((DegMinSec)this.value).getLngMin() * (buttonToggle1.isEnabled() ? 1 : -1));
            floatInput5.setValue(((DegMinSec)this.value).getLatSec() * (buttonToggle2.isEnabled() ? -1 : 1));
            floatInput6.setValue(((DegMinSec)this.value).getLngSec() * (buttonToggle1.isEnabled() ? 1 :- 1));
            this.floatInput1.TextChanged += onChange;
            this.floatInput2.TextChanged += onChange;
            this.floatInput3.TextChanged += onChange;
            this.floatInput4.TextChanged += onChange;
            this.floatInput5.TextChanged += onChange;
            this.floatInput6.TextChanged += onChange;
        }

        protected override void updateValue()
        {
            try
            {
                this.value = new DegMinSec(
                    floatInput1.getValue() * (buttonToggle2.isEnabled() ? -1 : 1),
                    floatInput3.getValue(),
                    floatInput5.getValue(),
                    floatInput2.getValue() * (buttonToggle1.isEnabled() ? 1 : -1),
                    floatInput4.getValue(),
                    floatInput6.getValue());
                this.unflag();
            }
            catch (OutOfBoundsCoordinateException)
            {
                this.flag();
                // keep value the same as it was before
            }
        }
        public override void setLabel(string txt)
        {
            groupBox1.Text = txt;
        }

        public override void setColor(Color c)
        {
            groupBox1.ForeColor = c;
        }

        public override string getLabel()
        {
            return groupBox1.Text;
        }

        public override Color getColor()
        {
            return groupBox1.ForeColor;
        }

        public override void flag()
        {
            floatInput1.ForeColor = Color.FromArgb(0, 200, 156, 40);
            floatInput2.ForeColor = Color.FromArgb(0, 200, 156, 40);
            floatInput3.ForeColor = Color.FromArgb(0, 200, 156, 40);
            floatInput4.ForeColor = Color.FromArgb(0, 200, 156, 40);
            floatInput5.ForeColor = Color.FromArgb(0, 200, 156, 40);
            floatInput6.ForeColor = Color.FromArgb(0, 200, 156, 40);
        }

        public override void unflag()
        {
            floatInput1.ForeColor = Color.Black;
            floatInput2.ForeColor = Color.Black;
            floatInput3.ForeColor = Color.Black;
            floatInput4.ForeColor = Color.Black;
            floatInput5.ForeColor = Color.Black;
            floatInput6.ForeColor = Color.Black;
        }
    }
}
