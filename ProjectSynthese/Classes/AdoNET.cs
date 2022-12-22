using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace ProjetSynthese.Classes
{
    class AdoNET
    {
        //Attribus privés
        private SqlConnection connection;
        private SqlCommand command;
        private SqlDataAdapter adapter;
        private string connectionString;
        private DataTable dtOiseau;
        private DataTable dtSerpent;
        private DataTable dtEnclos;
        private DataSet dsZoo;

        //Propriétés
        public SqlConnection Connection { get => connection; set => connection = value; }
        public SqlCommand Command { get => command; set => command = value; }
        public SqlDataAdapter Adapter { get => adapter; set => adapter = value; }
        public string ConnectionString { get => connectionString; }
        public DataTable DtOiseau { get => dtOiseau; set => dtOiseau = value; }
        public DataTable DtSerpent { get => dtSerpent; set => dtSerpent = value; }
        public DataTable DtEnclos { get => dtEnclos; set => dtEnclos = value; }
        public DataSet DsZoo { get => dsZoo; set => dsZoo = value; }

        //Constructeur
        public AdoNET()
        {
            connectionString = "Data Source=1085R3PC4;Initial Catalog=Zoo;User ID=sa;Password=sql";
            connection = new SqlConnection(connectionString);
            command = new SqlCommand();
            adapter = new SqlDataAdapter();
            dtOiseau = new DataTable();
            dtSerpent = new DataTable();
            dtEnclos = new DataTable();
            dsZoo = new DataSet();

        }
    }
}
