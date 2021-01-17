using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ресторан.DataBaseAcc
{

    class DBConnection : IDisposable
    {


        public string connectString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Ресторан.mdb;";

        // поле - ссылка на экземпляр класса OleDbConnection для соединения с БД
        public OleDbConnection myConnection;

        //Конструктор для создания подключения
        public DBConnection ()
        {
            // создаем экземпляр класса OleDbConnection
            myConnection = new OleDbConnection(connectString);

            // открываем соединение с БД
            myConnection.Open();

        }



       



        //Деструктор для завершения работы с бд
        ~DBConnection()
        {
            myConnection.Close();
        }

        public void Dispose()
        {
            myConnection.Close();
           // throw new NotImplementedException();
        }
    }
}
