using System.Collections.Generic;
using System.Web.Http;
using DotNetWebApiApp.Models;
using App.DomainModels;
namespace DotNetWebApiApp.Controllers
{
    [RoutePrefix("api/Form")]
    public class FormController : BaseController
    {
        [Route("GetAll")]
        [HttpGet]
        public IHttpActionResult GetAllRecords()
        {
            var response = new ApiResponse<IEnumerable<FormModel>>();
            response.Data = new List<FormModel>();
            return Ok(response);
        }

        [Route("CreateNewUser")]
        [HttpPost]
        public IHttpActionResult CreateUser()
        {
            var response = new ApiResponse<int>();
            response.Data = 5;
            return Ok();
        }

    }
}
