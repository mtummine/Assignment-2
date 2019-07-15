using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProjectManagement {
    public partial class MainApplicationForm : Form {
        public MainApplicationForm()
        {
            InitializeComponent();
        }

        private void generalButton_Click(object sender, EventArgs e)
        {
            requirementsPanel.Visible = false;
            trackingPanel.Visible = false;
            generalPanel.Visible = true;
            requirementsBtn.Enabled = true;
            trackingBtn.Enabled = true;
            generalButton.Enabled = false;
        }

        private void requirementsBtn_Click(object sender, EventArgs e)
        {
            requirementsPanel.Visible = true;
            trackingPanel.Visible = false;
            generalPanel.Visible = false;
            requirementsBtn.Enabled = false;
            trackingBtn.Enabled = true;
            generalButton.Enabled = true;
        }

        private void trackingBtn_Click(object sender, EventArgs e)
        {
            requirementsPanel.Visible = false;
            trackingPanel.Visible = true;
            generalPanel.Visible = false;
            requirementsBtn.Enabled = true;
            trackingBtn.Enabled = false;
            generalButton.Enabled = true;
        }
    }
}
