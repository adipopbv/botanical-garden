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
            this.sectorsDataGridView = new System.Windows.Forms.DataGridView();
            this.childTableLabel = new System.Windows.Forms.Label();
            this.greenhousesDataGridView = new System.Windows.Forms.DataGridView();
            this.addButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.modifyButton = new System.Windows.Forms.Button();
            this.connectButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.greenhouseIdTextBox = new System.Windows.Forms.TextBox();
            this.nicknameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.freeSpacesTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.isFullTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.sectorIdTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize) (this.sectorsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.greenhousesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // parentTableLabel
            // 
            this.parentTableLabel.Location = new System.Drawing.Point(287, 9);
            this.parentTableLabel.Name = "parentTableLabel";
            this.parentTableLabel.Size = new System.Drawing.Size(53, 19);
            this.parentTableLabel.TabIndex = 0;
            this.parentTableLabel.Text = "Sectors";
            this.parentTableLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sectorsDataGridView
            // 
            this.sectorsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sectorsDataGridView.Location = new System.Drawing.Point(11, 30);
            this.sectorsDataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.sectorsDataGridView.Name = "sectorsDataGridView";
            this.sectorsDataGridView.RowHeadersWidth = 51;
            this.sectorsDataGridView.RowTemplate.Height = 24;
            this.sectorsDataGridView.Size = new System.Drawing.Size(601, 247);
            this.sectorsDataGridView.TabIndex = 33;
            this.sectorsDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.sectorsDataGridView_CellClick);
            // 
            // childTableLabel
            // 
            this.childTableLabel.Location = new System.Drawing.Point(276, 291);
            this.childTableLabel.Name = "childTableLabel";
            this.childTableLabel.Size = new System.Drawing.Size(74, 19);
            this.childTableLabel.TabIndex = 34;
            this.childTableLabel.Text = "Greenhouses";
            this.childTableLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // greenhousesDataGridView
            // 
            this.greenhousesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.greenhousesDataGridView.Location = new System.Drawing.Point(11, 312);
            this.greenhousesDataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.greenhousesDataGridView.Name = "greenhousesDataGridView";
            this.greenhousesDataGridView.RowHeadersWidth = 51;
            this.greenhousesDataGridView.RowTemplate.Height = 24;
            this.greenhousesDataGridView.Size = new System.Drawing.Size(601, 247);
            this.greenhousesDataGridView.TabIndex = 35;
            this.greenhousesDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.greenhousesDataGridView_CellClick);
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
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(617, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 23);
            this.label1.TabIndex = 50;
            this.label1.Text = "greenhouse_id";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // greenhouseIdTextBox
            // 
            this.greenhouseIdTextBox.Location = new System.Drawing.Point(745, 32);
            this.greenhouseIdTextBox.Name = "greenhouseIdTextBox";
            this.greenhouseIdTextBox.Size = new System.Drawing.Size(100, 20);
            this.greenhouseIdTextBox.TabIndex = 51;
            // 
            // nicknameTextBox
            // 
            this.nicknameTextBox.Location = new System.Drawing.Point(745, 58);
            this.nicknameTextBox.Name = "nicknameTextBox";
            this.nicknameTextBox.Size = new System.Drawing.Size(100, 20);
            this.nicknameTextBox.TabIndex = 53;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(617, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 23);
            this.label2.TabIndex = 52;
            this.label2.Text = "nickname";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // freeSpacesTextBox
            // 
            this.freeSpacesTextBox.Location = new System.Drawing.Point(745, 84);
            this.freeSpacesTextBox.Name = "freeSpacesTextBox";
            this.freeSpacesTextBox.Size = new System.Drawing.Size(100, 20);
            this.freeSpacesTextBox.TabIndex = 55;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(617, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 23);
            this.label3.TabIndex = 54;
            this.label3.Text = "free_spaces";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // isFullTextBox
            // 
            this.isFullTextBox.Location = new System.Drawing.Point(745, 110);
            this.isFullTextBox.Name = "isFullTextBox";
            this.isFullTextBox.Size = new System.Drawing.Size(100, 20);
            this.isFullTextBox.TabIndex = 57;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(617, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 23);
            this.label4.TabIndex = 56;
            this.label4.Text = "is_full";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sectorIdTextBox
            // 
            this.sectorIdTextBox.Location = new System.Drawing.Point(745, 136);
            this.sectorIdTextBox.Name = "sectorIdTextBox";
            this.sectorIdTextBox.Size = new System.Drawing.Size(100, 20);
            this.sectorIdTextBox.TabIndex = 59;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(617, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 23);
            this.label5.TabIndex = 58;
            this.label5.Text = "sector_id";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 573);
            this.Controls.Add(this.sectorIdTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.isFullTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.freeSpacesTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nicknameTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.greenhouseIdTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.connectButton);
            this.Controls.Add(this.modifyButton);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.parentTableLabel);
            this.Controls.Add(this.sectorsDataGridView);
            this.Controls.Add(this.childTableLabel);
            this.Controls.Add(this.greenhousesDataGridView);
            this.Name = "MainWindow";
            this.Text = "MainWindow";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            ((System.ComponentModel.ISupportInitialize) (this.sectorsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.greenhousesDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox greenhouseIdTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nicknameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox freeSpacesTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox isFullTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox sectorIdTextBox;
        private System.Windows.Forms.Label label5;

        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Button modifyButton;
        private System.Windows.Forms.Button connectButton;

        private System.Windows.Forms.Label parentTableLabel;
        private System.Windows.Forms.DataGridView sectorsDataGridView;
        private System.Windows.Forms.Label childTableLabel;
        private System.Windows.Forms.DataGridView greenhousesDataGridView;

        #endregion
    }
}