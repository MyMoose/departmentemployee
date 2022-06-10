using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Data;
using System.Data.SqlClient;
using WebApplication1.Models.Requests;
using WebApplication1.Models.Responses;
using WebApplication1.Services;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController : ControllerBase
    {
        //private IDepartmentServices _service = null;
        private readonly IConfiguration _configuration;
        public DepartmentController(IConfiguration configuration
            //,IDepartmentServices service
            )
        {
            _configuration = configuration;
            //_service = service;
        }

        [HttpGet]
        public JsonResult Get()
        {
            string procName = "[dbo].[Department_SelectAll]";
            DataTable table = new DataTable();
            string sqlDataSource = _configuration.GetConnectionString("EmployeeAppCon");
            SqlDataReader sqlDataReader;
            using(SqlConnection sqlConnection = new SqlConnection(sqlDataSource))
            {
                sqlConnection.Open();
                using (SqlCommand sqlCommand = new SqlCommand(procName, sqlConnection))
                {
                    sqlDataReader = sqlCommand.ExecuteReader();
                    table.Load(sqlDataReader);
                    sqlDataReader.Close();
                    sqlConnection.Close();
                }
            }
            return new JsonResult(table);
        }

        [HttpPost]
        public JsonResult Post(DepartmentAddRequest model, int id)
        {
            string procName = "[dbo].[Department_Insert]";
            
            DataTable table = new DataTable();
            string sqlDataSource = _configuration.GetConnectionString("EmployeeAppCon");
            SqlDataReader sqlDataReader;
            using (SqlConnection sqlConnection = new SqlConnection(sqlDataSource))
            {
                sqlConnection.Open();
                using (SqlCommand sqlCommand = new SqlCommand(procName, sqlConnection))
                {
                    SqlParameter parameterId = new SqlParameter("@DepartmentId", id);
                    parameterId.Direction = ParameterDirection.Output;
                    sqlCommand.Parameters.Add(parameterId);

                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.Parameters.AddWithValue("@DepartmentName", model.DepartmentName);                    
                    

                    sqlDataReader = sqlCommand.ExecuteReader();
                    table.Load(sqlDataReader);
                    sqlDataReader.Close();
                    sqlConnection.Close();
                    
                }
            }
            return new JsonResult("Added Successfully");
        }

        [HttpPut]
        public JsonResult Put(DepartmentUpdateRequest model)
        {
            string procName = "[dbo].[Department_Update]";
            DataTable table = new DataTable();
            string sqlDataSource = _configuration.GetConnectionString("EmployeeAppCon");
            SqlDataReader sqlDataReader;
            using (SqlConnection sqlConnection = new SqlConnection(sqlDataSource))
            {
                sqlConnection.Open();
                using (SqlCommand sqlCommand = new SqlCommand(procName, sqlConnection))
                {
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.Parameters.AddWithValue("@DepartmentId", model.DepartmentId);
                    sqlCommand.Parameters.AddWithValue("@DepartmentName",model.DepartmentName);
                    sqlDataReader = sqlCommand.ExecuteReader();
                    table.Load(sqlDataReader);
                    sqlDataReader.Close();
                    sqlConnection.Close();
                }
            }
            return new JsonResult("Updated Successfully");
        }

        [HttpDelete("{id:int}")]
        public JsonResult Delete(int id)
        {
            string procName = "[dbo].[Department_Delete]";
            DataTable table = new DataTable();
            string sqlDataSource = _configuration.GetConnectionString("EmployeeAppCon");
            SqlDataReader sqlDataReader;
            using (SqlConnection sqlConnection = new SqlConnection(sqlDataSource))
            {
                sqlConnection.Open();
                using (SqlCommand sqlCommand = new SqlCommand(procName, sqlConnection))
                {
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.Parameters.AddWithValue("@DepartmentId", id);
                    sqlDataReader = sqlCommand.ExecuteReader();
                    table.Load(sqlDataReader);
                    sqlDataReader.Close();
                    sqlConnection.Close();
                }
            }
            return new JsonResult("Deleted Successfully");
        }

        //[HttpDelete("{id:int}")]
        //public ActionResult<SuccessResponse> Delete(int id)
        //{
        //    int code = 200;
        //    BaseResponse response = null;

        //    try
        //    {
        //        _service.Delete(id);

        //        response = new SuccessResponse();
        //    }
        //    catch (Exception ex)
        //    {
        //        code = 500;
        //        response = new ErrorResponse(ex.Message);
        //    }

        //    return StatusCode(code, response);
        //}
    }
}
