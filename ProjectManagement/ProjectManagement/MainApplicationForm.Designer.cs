namespace ProjectManagement {
    partial class MainApplicationForm {
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.generalPanel = new System.Windows.Forms.Panel();
            this.ownerLabel = new System.Windows.Forms.Label();
            this.managerNameTextBox = new System.Windows.Forms.TextBox();
            this.teamText = new System.Windows.Forms.TextBox();
            this.risksPanel = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Risk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionText = new System.Windows.Forms.TextBox();
            this.generalButton = new System.Windows.Forms.Button();
            this.requirementsBtn = new System.Windows.Forms.Button();
            this.trackingBtn = new System.Windows.Forms.Button();
            this.projectNameText = new System.Windows.Forms.TextBox();
            this.requirementsPanel = new System.Windows.Forms.Panel();
            this.trackingPanel = new System.Windows.Forms.Panel();
            this.trackingPanelLabel = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.hoursDataGrid = new System.Windows.Forms.DataGridView();
            this.taskColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoursColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewFunctional = new System.Windows.Forms.DataGridView();
            this.FunctionalColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewNonFunctional = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.generalPanel.SuspendLayout();
            this.risksPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.requirementsPanel.SuspendLayout();
            this.trackingPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoursDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFunctional)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNonFunctional)).BeginInit();
            this.SuspendLayout();
            // 
            // generalPanel
            // 
            this.generalPanel.Controls.Add(this.ownerLabel);
            this.generalPanel.Controls.Add(this.managerNameTextBox);
            this.generalPanel.Controls.Add(this.teamText);
            this.generalPanel.Controls.Add(this.risksPanel);
            this.generalPanel.Controls.Add(this.descriptionText);
            this.generalPanel.Location = new System.Drawing.Point(18, 119);
            this.generalPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.generalPanel.Name = "generalPanel";
            this.generalPanel.Size = new System.Drawing.Size(1230, 692);
            this.generalPanel.TabIndex = 0;
            // 
            // ownerLabel
            // 
            this.ownerLabel.AutoSize = true;
            this.ownerLabel.Location = new System.Drawing.Point(44, 20);
            this.ownerLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ownerLabel.Name = "ownerLabel";
            this.ownerLabel.Size = new System.Drawing.Size(170, 25);
            this.ownerLabel.TabIndex = 5;
            this.ownerLabel.Text = "Project Manager";
            // 
            // managerNameTextBox
            // 
            this.managerNameTextBox.Location = new System.Drawing.Point(220, 20);
            this.managerNameTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.managerNameTextBox.Name = "managerNameTextBox";
            this.managerNameTextBox.Size = new System.Drawing.Size(216, 31);
            this.managerNameTextBox.TabIndex = 4;
            // 
            // teamText
            // 
            this.teamText.Location = new System.Drawing.Point(930, 83);
            this.teamText.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.teamText.Multiline = true;
            this.teamText.Name = "teamText";
            this.teamText.Size = new System.Drawing.Size(283, 579);
            this.teamText.TabIndex = 3;
            this.teamText.Text = "Team Members";
            // 
            // risksPanel
            // 
            this.risksPanel.Controls.Add(this.dataGridView1);
            this.risksPanel.Location = new System.Drawing.Point(48, 367);
            this.risksPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.risksPanel.Name = "risksPanel";
            this.risksPanel.Size = new System.Drawing.Size(825, 298);
            this.risksPanel.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Risk,
            this.Status});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(825, 298);
            this.dataGridView1.TabIndex = 1;
            // 
            // Risk
            // 
            this.Risk.HeaderText = "Risk";
            this.Risk.MinimumWidth = 10;
            this.Risk.Name = "Risk";
            // 
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.MinimumWidth = 10;
            this.Status.Name = "Status";
            // 
            // descriptionText
            // 
            this.descriptionText.Location = new System.Drawing.Point(48, 83);
            this.descriptionText.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.descriptionText.Multiline = true;
            this.descriptionText.Name = "descriptionText";
            this.descriptionText.Size = new System.Drawing.Size(823, 242);
            this.descriptionText.TabIndex = 0;
            this.descriptionText.Text = "Project Description";
            // 
            // generalButton
            // 
            this.generalButton.Enabled = false;
            this.generalButton.Location = new System.Drawing.Point(722, 19);
            this.generalButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.generalButton.Name = "generalButton";
            this.generalButton.Size = new System.Drawing.Size(170, 64);
            this.generalButton.TabIndex = 1;
            this.generalButton.Text = "General";
            this.generalButton.UseVisualStyleBackColor = true;
            this.generalButton.Click += new System.EventHandler(this.generalButton_Click);
            // 
            // requirementsBtn
            // 
            this.requirementsBtn.Location = new System.Drawing.Point(900, 19);
            this.requirementsBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.requirementsBtn.Name = "requirementsBtn";
            this.requirementsBtn.Size = new System.Drawing.Size(170, 64);
            this.requirementsBtn.TabIndex = 2;
            this.requirementsBtn.Text = "Requirements";
            this.requirementsBtn.UseVisualStyleBackColor = true;
            this.requirementsBtn.Click += new System.EventHandler(this.requirementsBtn_Click);
            // 
            // trackingBtn
            // 
            this.trackingBtn.Location = new System.Drawing.Point(1078, 19);
            this.trackingBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.trackingBtn.Name = "trackingBtn";
            this.trackingBtn.Size = new System.Drawing.Size(170, 64);
            this.trackingBtn.TabIndex = 3;
            this.trackingBtn.Text = "Tracking";
            this.trackingBtn.UseVisualStyleBackColor = true;
            this.trackingBtn.Click += new System.EventHandler(this.trackingBtn_Click);
            // 
            // projectNameText
            // 
            this.projectNameText.Enabled = false;
            this.projectNameText.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.projectNameText.Location = new System.Drawing.Point(18, 19);
            this.projectNameText.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.projectNameText.Name = "projectNameText";
            this.projectNameText.Size = new System.Drawing.Size(655, 62);
            this.projectNameText.TabIndex = 0;
            this.projectNameText.Text = "Project Name";
            // 
            // requirementsPanel
            // 
            this.requirementsPanel.Controls.Add(this.dataGridViewNonFunctional);
            this.requirementsPanel.Controls.Add(this.dataGridViewFunctional);
            this.requirementsPanel.Location = new System.Drawing.Point(22, 119);
            this.requirementsPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.requirementsPanel.Name = "requirementsPanel";
            this.requirementsPanel.Size = new System.Drawing.Size(1226, 691);
            this.requirementsPanel.TabIndex = 4;
            this.requirementsPanel.Visible = false;
            // 
            // trackingPanel
            // 
            this.trackingPanel.Controls.Add(this.trackingPanelLabel);
            this.trackingPanel.Controls.Add(this.chart1);
            this.trackingPanel.Controls.Add(this.hoursDataGrid);
            this.trackingPanel.Location = new System.Drawing.Point(18, 119);
            this.trackingPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.trackingPanel.Name = "trackingPanel";
            this.trackingPanel.Size = new System.Drawing.Size(1230, 712);
            this.trackingPanel.TabIndex = 1;
            this.trackingPanel.Visible = false;
            // 
            // trackingPanelLabel
            // 
            this.trackingPanelLabel.AutoSize = true;
            this.trackingPanelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trackingPanelLabel.Location = new System.Drawing.Point(44, 47);
            this.trackingPanelLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.trackingPanelLabel.Name = "trackingPanelLabel";
            this.trackingPanelLabel.Size = new System.Drawing.Size(268, 44);
            this.trackingPanelLabel.TabIndex = 3;
            this.trackingPanelLabel.Text = "Effort Tracking";
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(588, 134);
            this.chart1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(573, 486);
            this.chart1.TabIndex = 2;
            this.chart1.Text = "chart1";
            // 
            // hoursDataGrid
            // 
            this.hoursDataGrid.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.hoursDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.hoursDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.hoursDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.taskColumn,
            this.hoursColumn});
            this.hoursDataGrid.Location = new System.Drawing.Point(9, 134);
            this.hoursDataGrid.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.hoursDataGrid.Name = "hoursDataGrid";
            this.hoursDataGrid.RowHeadersWidth = 82;
            this.hoursDataGrid.RowTemplate.Height = 24;
            this.hoursDataGrid.Size = new System.Drawing.Size(482, 486);
            this.hoursDataGrid.TabIndex = 1;
            // 
            // taskColumn
            // 
            this.taskColumn.HeaderText = "Task";
            this.taskColumn.MinimumWidth = 10;
            this.taskColumn.Name = "taskColumn";
            this.taskColumn.ReadOnly = true;
            // 
            // hoursColumn
            // 
            this.hoursColumn.HeaderText = "Total (hours)";
            this.hoursColumn.MinimumWidth = 10;
            this.hoursColumn.Name = "hoursColumn";
            this.hoursColumn.ReadOnly = true;
            // 
            // dataGridViewFunctional
            // 
            this.dataGridViewFunctional.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFunctional.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FunctionalColumn});
            this.dataGridViewFunctional.Location = new System.Drawing.Point(48, 26);
            this.dataGridViewFunctional.Name = "dataGridViewFunctional";
            this.dataGridViewFunctional.RowHeadersWidth = 82;
            this.dataGridViewFunctional.RowTemplate.Height = 33;
            this.dataGridViewFunctional.Size = new System.Drawing.Size(1132, 299);
            this.dataGridViewFunctional.TabIndex = 2;
            // 
            // FunctionalColumn
            // 
            this.FunctionalColumn.FillWeight = 300F;
            this.FunctionalColumn.Frozen = true;
            this.FunctionalColumn.HeaderText = "Functional Requirements";
            this.FunctionalColumn.MinimumWidth = 100;
            this.FunctionalColumn.Name = "FunctionalColumn";
            this.FunctionalColumn.Width = 1200;
            // 
            // dataGridViewNonFunctional
            // 
            this.dataGridViewNonFunctional.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewNonFunctional.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1});
            this.dataGridViewNonFunctional.Location = new System.Drawing.Point(48, 352);
            this.dataGridViewNonFunctional.Name = "dataGridViewNonFunctional";
            this.dataGridViewNonFunctional.RowHeadersWidth = 82;
            this.dataGridViewNonFunctional.RowTemplate.Height = 33;
            this.dataGridViewNonFunctional.Size = new System.Drawing.Size(1132, 299);
            this.dataGridViewNonFunctional.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.FillWeight = 300F;
            this.dataGridViewTextBoxColumn1.Frozen = true;
            this.dataGridViewTextBoxColumn1.HeaderText = "Non-Functional Requirements";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 100;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 1200;
            // 
            // MainApplicationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1290, 812);
            this.Controls.Add(this.projectNameText);
            this.Controls.Add(this.trackingBtn);
            this.Controls.Add(this.requirementsBtn);
            this.Controls.Add(this.generalButton);
            this.Controls.Add(this.requirementsPanel);
            this.Controls.Add(this.generalPanel);
            this.Controls.Add(this.trackingPanel);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainApplicationForm";
            this.Text = "Project Management";
            this.generalPanel.ResumeLayout(false);
            this.generalPanel.PerformLayout();
            this.risksPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.requirementsPanel.ResumeLayout(false);
            this.trackingPanel.ResumeLayout(false);
            this.trackingPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoursDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFunctional)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNonFunctional)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel generalPanel;
        private System.Windows.Forms.Button generalButton;
        private System.Windows.Forms.Button requirementsBtn;
        private System.Windows.Forms.Button trackingBtn;
        private System.Windows.Forms.TextBox projectNameText;
        private System.Windows.Forms.TextBox descriptionText;
        private System.Windows.Forms.TextBox teamText;
        private System.Windows.Forms.Panel risksPanel;
        private System.Windows.Forms.Label ownerLabel;
        private System.Windows.Forms.TextBox managerNameTextBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Risk;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.Panel requirementsPanel;
        private System.Windows.Forms.Panel trackingPanel;
        private System.Windows.Forms.Label trackingPanelLabel;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataGridView hoursDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn taskColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoursColumn;
        private System.Windows.Forms.DataGridView dataGridViewNonFunctional;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridView dataGridViewFunctional;
        private System.Windows.Forms.DataGridViewTextBoxColumn FunctionalColumn;
    }
}

