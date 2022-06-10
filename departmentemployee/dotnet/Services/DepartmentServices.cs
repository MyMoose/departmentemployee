using System.Data.SqlClient;
using WebApplication1.Models.Interfaces;

namespace WebApplication1.Services
{
    public class DepartmentServices : IDepartmentServices
    {
        IDataProvider _data = null;

        public DepartmentServices(IDataProvider data)
        {
            _data = data;
        }

        public void Delete(int id)
        {

            string procName = "[dbo].[Department_Delete]";

            _data.ExecuteNonQuery(procName, delegate (SqlParameterCollection paramCollection)
            {

                paramCollection.AddWithValue("@id", id);

            });

        }
    }


}
