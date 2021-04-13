using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace lab_1_project
{
    public partial class MainWindow : Form
    {
        private readonly SqlConnection _connection =
            new SqlConnection(ConfigurationManager.ConnectionStrings["dbConnection"].ConnectionString);

        private readonly SqlDataAdapter _greenhousesAdapter = new SqlDataAdapter();
        private readonly DataSet _greenhousesDataSet = new DataSet();

        private readonly SqlDataAdapter _sectorsAdapter = new SqlDataAdapter();
        private readonly DataSet _sectorsDataSet = new DataSet();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
        }

        private void parentTableDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                ClearFields();

                if (parentTableDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value == null) return;
                if (parentTableDataGridView.CurrentRow != null) parentTableDataGridView.CurrentRow.Selected = true;

                var cellValue = parentTableDataGridView.Rows[e.RowIndex]
                    .Cells[ConfigurationManager.AppSettings["ParentPrimaryKey"]].FormattedValue;
                if (cellValue != null)
                {
                    var parentPrimaryKey = cellValue.ToString();

                    _greenhousesAdapter.SelectCommand =
                        new SqlCommand(ConfigurationManager.AppSettings["ChildSelect"], _connection);
                    _greenhousesAdapter.SelectCommand.Parameters.AddWithValue(
                        "@" + ConfigurationManager.AppSettings["ParentPrimaryKey"], parentPrimaryKey);

                    ((TextBox) panel.Controls[ConfigurationManager.AppSettings["ParentPrimaryKey"]]).Text =
                        parentPrimaryKey;
                }

                _greenhousesDataSet.Clear();
                _greenhousesAdapter.Fill(_greenhousesDataSet);
                childTableDataGridView.DataSource = _greenhousesDataSet.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                _connection.Close();
            }
        }

        private void childTableDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (childTableDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value == null) return;
                if (childTableDataGridView.CurrentRow != null) childTableDataGridView.CurrentRow.Selected = true;

                var childPrimaryKey = ConfigurationManager.AppSettings["ChildPrimaryKey"];
                var formattedValue = childTableDataGridView.Rows[e.RowIndex]
                    .Cells[childPrimaryKey]
                    .FormattedValue;
                if (formattedValue != null)
                    ((TextBox) panel.Controls[childPrimaryKey]).Text = formattedValue.ToString();

                var childRestColumnNames =
                    new List<string>(ConfigurationManager.AppSettings["ChildRestColumnNames"].Split(','));
                foreach (var columnName in childRestColumnNames)
                {
                    formattedValue = childTableDataGridView.Rows[e.RowIndex]
                        .Cells[columnName]
                        .FormattedValue;
                    if (formattedValue != null)
                        ((TextBox) panel.Controls[columnName]).Text = formattedValue.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                _connection.Close();
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            try
            {
                var childRestColumnNames =
                    new List<string>(ConfigurationManager.AppSettings["ChildRestColumnNames"].Split(','));
                if (childRestColumnNames.Any(columnName => ((TextBox) panel.Controls[columnName]).Text == ""))
                    throw new Exception("empty or incorrect data given");

                _greenhousesAdapter.InsertCommand =
                    new SqlCommand(ConfigurationManager.AppSettings["ChildInsert"], _connection);
                foreach (var columnName in childRestColumnNames)
                    _greenhousesAdapter.InsertCommand.Parameters.AddWithValue("@" + columnName,
                        ((TextBox) panel.Controls[columnName]).Text);

                _connection.Open();
                _greenhousesAdapter.InsertCommand.ExecuteNonQuery();
                _connection.Close();

                _greenhousesDataSet.Clear();
                _greenhousesAdapter.Fill(_greenhousesDataSet);

                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                _connection.Close();
            }
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            try
            {
                var selected = childTableDataGridView.SelectedRows;
                if (selected.Count == 0)
                    throw new Exception("no selected greenhouse");

                var formattedValue = selected[0].Cells[ConfigurationManager.AppSettings["ChildPrimaryKey"]]
                    .FormattedValue;
                if (formattedValue != null)
                {
                    var childPrimaryKey = formattedValue.ToString();

                    _greenhousesAdapter.DeleteCommand =
                        new SqlCommand(ConfigurationManager.AppSettings["ChildDelete"], _connection);
                    _greenhousesAdapter.DeleteCommand.Parameters.AddWithValue(
                        "@" + ConfigurationManager.AppSettings["ChildPrimaryKey"], childPrimaryKey);
                }

                _connection.Open();
                _greenhousesAdapter.DeleteCommand.ExecuteNonQuery();
                _connection.Close();

                MessageBox.Show("greenhouse removed");

                _greenhousesDataSet.Clear();
                _greenhousesAdapter.Fill(_greenhousesDataSet);

                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                _connection.Close();
            }
        }

        private void modifyButton_Click(object sender, EventArgs e)
        {
            try
            {
                var childAllColumnNames =
                    new List<string>(ConfigurationManager.AppSettings["ChildAllColumnNames"].Split(','));
                if (childAllColumnNames.Any(columnName => ((TextBox) panel.Controls[columnName]).Text == ""))
                    throw new Exception("empty or incorrect data given");

                _greenhousesAdapter.UpdateCommand =
                    new SqlCommand(ConfigurationManager.AppSettings["ChildUpdate"], _connection);
                foreach (var columnName in childAllColumnNames)
                    _greenhousesAdapter.UpdateCommand.Parameters.AddWithValue("@" + columnName,
                        ((TextBox) panel.Controls[columnName]).Text);

                _connection.Open();
                _greenhousesAdapter.UpdateCommand.ExecuteNonQuery();
                _connection.Close();

                _greenhousesDataSet.Clear();
                _greenhousesAdapter.Fill(_greenhousesDataSet);

                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                _connection.Close();
            }
        }

        private void connectButton_Click(object sender, EventArgs e)
        {
            try
            {
                _greenhousesDataSet.Clear();
                _sectorsAdapter.SelectCommand =
                    new SqlCommand(ConfigurationManager.AppSettings["ParentSelect"], _connection);
                _sectorsDataSet.Clear();
                _sectorsAdapter.Fill(_sectorsDataSet);
                parentTableDataGridView.DataSource = _sectorsDataSet.Tables[0];
                parentTableLabel.Text = ConfigurationManager.AppSettings["ParentTableName"];
                childTableLabel.Text = ConfigurationManager.AppSettings["ChildTableName"];

                // fields generation
                const int labelX = 0;
                const int fieldX = 100;
                var y = 0;
                var childAllColumnNames =
                    new List<string>(ConfigurationManager.AppSettings["ChildAllColumnNames"].Split(','));
                panel.Controls.Clear();
                foreach (var columnName in childAllColumnNames)
                {
                    var label = new Label
                        {Text = columnName, Location = new Point(labelX, y), Visible = true, Parent = panel};
                    var field = new TextBox
                        {Name = columnName, Location = new Point(fieldX, y), Visible = true, Parent = panel};
                    panel.Controls.Add(label);
                    panel.Controls.Add(field);
                    y += 30;
                }

                panel.Show();

                ((TextBox) panel.Controls[ConfigurationManager.AppSettings["ParentPrimaryKey"]]).ReadOnly = true;
                ((TextBox) panel.Controls[ConfigurationManager.AppSettings["ChildPrimaryKey"]]).ReadOnly = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                _connection.Close();
            }
        }

        private void ClearFields()
        {
            var childAllColumnNames =
                new List<string>(ConfigurationManager.AppSettings["ChildAllColumnNames"].Split(','));
            foreach (var columnName in childAllColumnNames) ((TextBox) panel.Controls[columnName]).Text = "";
        }
    }
}