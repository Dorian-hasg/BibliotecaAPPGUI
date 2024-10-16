using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BibliotecaApp
{
    public partial class Form1 : Form
    {
      
        private string connectionString = "Data Source=.;Initial Catalog=BibliotecaDB;Integrated Security=True";

        public Form1()
        {
            InitializeComponent();  
        }

     
        private void btnCargarLibros_Click(object sender, EventArgs e)
        {
            CargarLibros();  
        }

       
        private void CargarLibros()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM Libros";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    dataGridViewLibros.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
    }
}
