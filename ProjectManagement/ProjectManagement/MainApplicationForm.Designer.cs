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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
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
            this.label1 = new System.Windows.Forms.Label();
            this.trackingPanel = new System.Windows.Forms.Panel();
            this.trackingPanelLabel = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.hoursDataGrid = new System.Windows.Forms.DataGridView();
            this.taskColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoursColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.generalPanel.SuspendLayout();
            this.risksPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.requirementsPanel.SuspendLayout();
            this.trackingPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoursDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // generalPanel
            // 
            this.generalPanel.Controls.Add(this.ownerLabel);
            this.generalPanel.Controls.Add(this.managerNameTextBox);
            this.generalPanel.Controls.Add(this.teamText);
            this.generalPanel.Controls.Add(this.risksPanel);
            this.generalPanel.Controls.Add(this.descriptionText);
            this.generalPanel.Location = new System.Drawing.Point(12, 76);
            this.generalPanel.Name = "generalPanel";
            this.generalPanel.Size = new System.Drawing.Size(820, 443);
            this.generalPanel.TabIndex = 0;
            // 
            // ownerLabel
            // 
            this.ownerLabel.AutoSize = true;
            this.ownerLabel.Location = new System.Drawing.Point(29, 13);
            this.ownerLabel.Name = "ownerLabel";
            this.ownerLabel.Size = new System.Drawing.Size(112, 17);
            this.ownerLabel.TabIndex = 5;
            this.ownerLabel.Text = "Project Manager";
            // 
            // managerNameTextBox
            // 
            this.managerNameTextBox.Location = new System.Drawing.Point(147, 13);
            this.managerNameTextBox.Name = "managerNameTextBox";
            this.managerNameTextBox.Size = new System.Drawing.Size(145, 22);
            this.managerNameTextBox.TabIndex = 4;
            // 
            // teamText
            // 
            this.teamText.Location = new System.Drawing.Point(620, 53);
            this.teamText.Multiline = true;
            this.teamText.Name = "teamText";
            this.teamText.Size = new System.Drawing.Size(190, 372);
            this.teamText.TabIndex = 3;
            this.teamText.Text = "Team Members";
            // 
            // risksPanel
            // 
            this.risksPanel.Controls.Add(this.dataGridView1);
            this.risksPanel.Location = new System.Drawing.Point(32, 235);
            this.risksPanel.Name = "risksPanel";
            this.risksPanel.Size = new System.Drawing.Size(550, 191);
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
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(550, 191);
            this.dataGridView1.TabIndex = 1;
            // 
            // Risk
            // 
            this.Risk.HeaderText = "Risk";
            this.Risk.Name = "Risk";
            // 
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            // 
            // descriptionText
            // 
            this.descriptionText.Location = new System.Drawing.Point(32, 53);
            this.descriptionText.Multiline = true;
            this.descriptionText.Name = "descriptionText";
            this.descriptionText.Size = new System.Drawing.Size(550, 156);
            this.descriptionText.TabIndex = 0;
            this.descriptionText.Text = "Project Description";
            // 
            // generalButton
            // 
            this.generalButton.Enabled = false;
            this.generalButton.Location = new System.Drawing.Point(481, 12);
            this.generalButton.Name = "generalButton";
            this.generalButton.Size = new System.Drawing.Size(113, 41);
            this.generalButton.TabIndex = 1;
            this.generalButton.Text = "General";
            this.generalButton.UseVisualStyleBackColor = true;
            this.generalButton.Click += new System.EventHandler(this.generalButton_Click);
            // 
            // requirementsBtn
            // 
            this.requirementsBtn.Location = new System.Drawing.Point(600, 12);
            this.requirementsBtn.Name = "requirementsBtn";
            this.requirementsBtn.Size = new System.Drawing.Size(113, 41);
            this.requirementsBtn.TabIndex = 2;
            this.requirementsBtn.Text = "Requirements";
            this.requirementsBtn.UseVisualStyleBackColor = true;
            this.requirementsBtn.Click += new System.EventHandler(this.requirementsBtn_Click);
            // 
            // trackingBtn
            // 
            this.trackingBtn.Location = new System.Drawing.Point(719, 12);
            this.trackingBtn.Name = "trackingBtn";
            this.trackingBtn.Size = new System.Drawing.Size(113, 41);
            this.trackingBtn.TabIndex = 3;
            this.trackingBtn.Text = "Tracking";
            this.trackingBtn.UseVisualStyleBackColor = true;
            this.trackingBtn.Click += new System.EventHandler(this.trackingBtn_Click);
            // 
            // projectNameText
            // 
            this.projectNameText.Enabled = false;
            this.projectNameText.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.projectNameText.Location = new System.Drawing.Point(12, 12);
            this.projectNameText.Name = "projectNameText";
            this.projectNameText.Size = new System.Drawing.Size(438, 41);
            this.projectNameText.TabIndex = 0;
            this.projectNameText.Text = "Project Name";
            // 
            // requirementsPanel
            // 
            this.requirementsPanel.Controls.Add(this.label1);
            this.requirementsPanel.Location = new System.Drawing.Point(15, 76);
            this.requirementsPanel.Name = "requirementsPanel";
            this.requirementsPanel.Size = new System.Drawing.Size(817, 442);
            this.requirementsPanel.TabIndex = 4;
            this.requirementsPanel.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(386, 212);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Requirements";
            // 
            // trackingPanel
            // 
            this.trackingPanel.Controls.Add(this.trackingPanelLabel);
            this.trackingPanel.Controls.Add(this.chart1);
            this.trackingPanel.Controls.Add(this.hoursDataGrid);
            this.trackingPanel.Location = new System.Drawing.Point(12, 76);
            this.trackingPanel.Name = "trackingPanel";
            this.trackingPanel.Size = new System.Drawing.Size(820, 456);
            this.trackingPanel.TabIndex = 1;
            this.trackingPanel.Visible = false;
            // 
            // trackingPanelLabel
            // 
            this.trackingPanelLabel.AutoSize = true;
            this.trackingPanelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trackingPanelLabel.Location = new System.Drawing.Point(29, 30);
            this.trackingPanelLabel.Name = "trackingPanelLabel";
            this.trackingPanelLabel.Size = new System.Drawing.Size(169, 29);
            this.trackingPanelLabel.TabIndex = 3;
            this.trackingPanelLabel.Text = "Effort Tracking";
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(392, 86);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(382, 311);
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
            this.hoursDataGrid.Location = new System.Drawing.Point(6, 86);
            this.hoursDataGrid.Name = "hoursDataGrid";
            this.hoursDataGrid.RowTemplate.Height = 24;
            this.hoursDataGrid.Size = new System.Drawing.Size(321, 311);
            this.hoursDataGrid.TabIndex = 1;
            // 
            // taskColumn
            // 
            this.taskColumn.HeaderText = "Task";
            this.taskColumn.Name = "taskColumn";
            this.taskColumn.ReadOnly = true;
            // 
            // hoursColumn
            // 
            this.hoursColumn.HeaderText = "Total (hours)";
            this.hoursColumn.Name = "hoursColumn";
            this.hoursColumn.ReadOnly = true;
            // 
            // MainApplicationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 520);
            this.Controls.Add(this.projectNameText);
            this.Controls.Add(this.trackingBtn);
            this.Controls.Add(this.requirementsBtn);
            this.Controls.Add(this.generalButton);
            this.Controls.Add(this.trackingPanel);
            this.Controls.Add(this.requirementsPanel);
            this.Controls.Add(this.generalPanel);
            this.Name = "MainApplicationForm";
            this.Text = "Project Management";
            this.generalPanel.ResumeLayout(false);
            this.generalPanel.PerformLayout();
            this.risksPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.requirementsPanel.ResumeLayout(false);
            this.requirementsPanel.PerformLayout();
            this.trackingPanel.ResumeLayout(false);
            this.trackingPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoursDataGrid)).EndInit();
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel trackingPanel;
        private System.Windows.Forms.Label trackingPanelLabel;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataGridView hoursDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn taskColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoursColumn;
    }
}

