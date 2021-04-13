using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace lab_1_project
{
    public partial class MainWindow : Form
    {
        private readonly SqlConnection _connection =
            new SqlConnection(
                "Data Source=MSIGS75-WINDOWS\\SQLEXPRESS;Initial Catalog=BotanicalGarden;Integrated Security=True;");

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
            sectorIdTextBox.ReadOnly = true;
            greenhouseIdTextBox.ReadOnly = true;
        }

        private void sectorsDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                ClearFields();

                if (sectorsDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value == null) return;
                if (sectorsDataGridView.CurrentRow != null) sectorsDataGridView.CurrentRow.Selected = true;

                var sectorId = sectorsDataGridView.Rows[e.RowIndex].Cells["sector_id"].FormattedValue.ToString();

                _greenhousesAdapter.SelectCommand =
                    new SqlCommand("select * from Greenhouses where sector_id = @sector_id", _connection);
                _greenhousesAdapter.SelectCommand.Parameters.AddWithValue("@sector_id", sectorId);

                sectorIdTextBox.Text = sectorId;

                _greenhousesDataSet.Clear();
                _greenhousesAdapter.Fill(_greenhousesDataSet);
                greenhousesDataGridView.DataSource = _greenhousesDataSet.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                _connection.Close();
            }
        }

        private void greenhousesDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (greenhousesDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value == null) return;
                if (greenhousesDataGridView.CurrentRow != null) greenhousesDataGridView.CurrentRow.Selected = true;

                greenhouseIdTextBox.Text = greenhousesDataGridView.Rows[e.RowIndex].Cells["greenhouse_id"]
                    .FormattedValue.ToString();
                nicknameTextBox.Text =
                    greenhousesDataGridView.Rows[e.RowIndex].Cells["nickname"].FormattedValue.ToString();
                freeSpacesTextBox.Text = greenhousesDataGridView.Rows[e.RowIndex].Cells["free_spaces"].FormattedValue
                    .ToString();
                isFullTextBox.Text =
                    greenhousesDataGridView.Rows[e.RowIndex].Cells["is_full"].FormattedValue.ToString();
                sectorIdTextBox.Text =
                    greenhousesDataGridView.Rows[e.RowIndex].Cells["sector_id"].FormattedValue.ToString();
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
                if (nicknameTextBox.Text == "" || freeSpacesTextBox.Text == "" || isFullTextBox.Text == "" ||
                    sectorIdTextBox.Text == "")
                    throw new Exception("empty or incorrect data given");

                _greenhousesAdapter.InsertCommand =
                    new SqlCommand(
                        "insert into Greenhouses(nickname, free_spaces, is_full, sector_id) values(@nickname, @free_spaces, @is_full, @sector_id)",
                        _connection);
                _greenhousesAdapter.InsertCommand.Parameters.AddWithValue("@nickname", nicknameTextBox.Text);
                _greenhousesAdapter.InsertCommand.Parameters.AddWithValue("@free_spaces", freeSpacesTextBox.Text);
                _greenhousesAdapter.InsertCommand.Parameters.AddWithValue("@is_full", isFullTextBox.Text);
                _greenhousesAdapter.InsertCommand.Parameters.AddWithValue("@sector_id", sectorIdTextBox.Text);

                _connection.Open();
                _greenhousesAdapter.InsertCommand.ExecuteNonQuery();
                _connection.Close();

                MessageBox.Show("greenhouse added");

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
                var selected = greenhousesDataGridView.SelectedRows;
                if (selected.Count == 0)
                    throw new Exception("no selected greenhouse");

                var greenhouseId = selected[0].Cells["greenhouse_id"].FormattedValue.ToString();

                _greenhousesAdapter.DeleteCommand =
                    new SqlCommand("delete from Greenhouses where greenhouse_id = @greenhouse_id", _connection);
                _greenhousesAdapter.DeleteCommand.Parameters.AddWithValue("@greenhouse_id", greenhouseId);

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
                if (greenhouseIdTextBox.Text == "" || nicknameTextBox.Text == "" || freeSpacesTextBox.Text == "" ||
                    isFullTextBox.Text == "" ||
                    sectorIdTextBox.Text == "")
                    throw new Exception("empty or incorrect data given");

                _greenhousesAdapter.UpdateCommand =
                    new SqlCommand(
                        "update Greenhouses set nickname = @nickname, free_spaces = @free_spaces, is_full = @is_full, sector_id = @sector_id where greenhouse_id = @greenhouse_id",
                        _connection);
                _greenhousesAdapter.UpdateCommand.Parameters.AddWithValue("@greenhouse_id", greenhouseIdTextBox.Text);
                _greenhousesAdapter.UpdateCommand.Parameters.AddWithValue("@nickname", nicknameTextBox.Text);
                _greenhousesAdapter.UpdateCommand.Parameters.AddWithValue("@free_spaces", freeSpacesTextBox.Text);
                _greenhousesAdapter.UpdateCommand.Parameters.AddWithValue("@is_full", isFullTextBox.Text);
                _greenhousesAdapter.UpdateCommand.Parameters.AddWithValue("@sector_id", sectorIdTextBox.Text);

                _connection.Open();
                _greenhousesAdapter.UpdateCommand.ExecuteNonQuery();
                _connection.Close();

                MessageBox.Show("greenhouse modified");

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
                _sectorsAdapter.SelectCommand = new SqlCommand("select * from Sectors", _connection);
                _sectorsDataSet.Clear();
                _sectorsAdapter.Fill(_sectorsDataSet);
                sectorsDataGridView.DataSource = _sectorsDataSet.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                _connection.Close();
            }
        }

        private void ClearFields()
        {
            greenhouseIdTextBox.Text = "";
            nicknameTextBox.Text = "";
            freeSpacesTextBox.Text = "";
            isFullTextBox.Text = "";
            sectorIdTextBox.Text = "";
        }
    }
}