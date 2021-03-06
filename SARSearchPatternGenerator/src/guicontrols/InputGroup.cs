﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SARSearchPatternGenerator
{
    /// <summary>
    /// Handles a group of input fields and updates them when they change.
    /// </summary>
    [Designer("System.Windows.Forms.Design.ParentControlDesigner, System.Design", typeof(IDesigner))]
    public class InputGroup : TableLayoutPanel
    {
        public EventHandler valueChanged;
        public InputGroup() : base()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            this.ResumeLayout(false);

        }

        protected void onUpdate()
        {
            if (valueChanged != null)
            {
                valueChanged.Invoke(this, new EventArgs());
            }
        }

        public void onValueChange(object sender, EventArgs e)
        {
            onUpdate();
        }
    }
}
