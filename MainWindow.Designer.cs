using System.ComponentModel;

namespace lab_1_project
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.parentTableLabel = new System.Windows.Forms.Label();
            this.parentTableDataGridView = new System.Windows.Forms.DataGridView();
            this.childTableLabel = new System.Windows.Forms.Label();
            this.childTableDataGridView = new System.Windows.Forms.DataGridView();
            this.addButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.modifyButton = new System.Windows.Forms.Button();
            this.connectButton = new System.Windows.Forms.Button();
            this.panel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize) (this.parentTableDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.childTableDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // parentTableLabel
            // 
            this.parentTableLabel.Location = new System.Drawing.Point(287, 9);
            this.parentTableLabel.Name = "parentTableLabel";
            this.parentTableLabel.Size = new System.Drawing.Size(53, 19);
            this.parentTableLabel.TabIndex = 0;
            this.parentTableLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // parentTableDataGridView
            // 
            this.parentTableDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.parentTableDataGridView.Location = new System.Drawing.Point(11, 30);
            this.parentTableDataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.parentTableDataGridView.Name = "parentTableDataGridView";
            this.parentTableDataGridView.RowHeadersWidth = 51;
            this.parentTableDataGridView.RowTemplate.Height = 24;
            this.parentTableDataGridView.Size = new System.Drawing.Size(601, 247);
            this.parentTableDataGridView.TabIndex = 33;
            this.parentTableDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.parentTableDataGridView_CellClick);
            // 
            // childTableLabel
            // 
            this.childTableLabel.Location = new System.Drawing.Point(276, 291);
            this.childTableLabel.Name = "childTableLabel";
            this.childTableLabel.Size = new System.Drawing.Size(74, 19);
            this.childTableLabel.TabIndex = 34;
            this.childTableLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // childTableDataGridView
            // 
            this.childTableDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.childTableDataGridView.Location = new System.Drawing.Point(11, 312);
            this.childTableDataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.childTableDataGridView.Name = "childTableDataGridView";
            this.childTableDataGridView.RowHeadersWidth = 51;
            this.childTableDataGridView.RowTemplate.Height = 24;
            this.childTableDataGridView.Size = new System.Drawing.Size(601, 247);
            this.childTableDataGridView.TabIndex = 35;
            this.childTableDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.childTableDataGridView_CellClick);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(697, 339);
            this.addButton.Name = "addButton";
            this.addButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.addButton.Size = new System.Drawing.Size(96, 42);
            this.addButton.TabIndex = 46;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(697, 387);
            this.removeButton.Name = "removeButton";
            this.removeButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.removeButton.Size = new System.Drawing.Size(96, 42);
            this.removeButton.TabIndex = 47;
            this.removeButton.Text = "Remove";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // modifyButton
            // 
            this.modifyButton.Location = new System.Drawing.Point(697, 435);
            this.modifyButton.Name = "modifyButton";
            this.modifyButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.modifyButton.Size = new System.Drawing.Size(96, 42);
            this.modifyButton.TabIndex = 48;
            this.modifyButton.Text = "Modify";
            this.modifyButton.UseVisualStyleBackColor = true;
            this.modifyButton.Click += new System.EventHandler(this.modifyButton_Click);
            // 
            // connectButton
            // 
            this.connectButton.Location = new System.Drawing.Point(697, 500);
            this.connectButton.Name = "connectButton";
            this.connectButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.connectButton.Size = new System.Drawing.Size(96, 26);
            this.connectButton.TabIndex = 49;
            this.connectButton.Text = "Connect";
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // panel
            // 
            this.panel.Location = new System.Drawing.Point(629, 30);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(228, 247);
            this.panel.TabIndex = 50;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 573);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.connectButton);
            this.Controls.Add(this.modifyButton);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.parentTableLabel);
            this.Controls.Add(this.parentTableDataGridView);
            this.Controls.Add(this.childTableLabel);
            this.Controls.Add(this.childTableDataGridView);
            this.Name = "MainWindow";
            this.Text = "MainWindow";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            ((System.ComponentModel.ISupportInitialize) (this.parentTableDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.childTableDataGridView)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel panel;

        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Button modifyButton;
        private System.Windows.Forms.Button connectButton;

        private System.Windows.Forms.Label parentTableLabel;
        private System.Windows.Forms.DataGridView parentTableDataGridView;
        private System.Windows.Forms.Label childTableLabel;
        private System.Windows.Forms.DataGridView childTableDataGridView;

        #endregion
    }
}