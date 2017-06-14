using System.Collections.Generic;
using System.Web.Http;
using DotNetWebApiApp.Models;
using App.DomainModels;
using App.Business.Interfaces;
namespace DotNetWebApiApp.Controllers
{
    [RoutePrefix("api/Form")]
    public class FormController : BaseController
    {
        #region Properties
        private readonly IUserDetailManager userDetailManager;
        #endregion

        [Route("GetAll")]
        [HttpGet]
        public IHttpActionResult GetAllRecords()
        {
            var response = new ApiResponse<IEnumerable<UserDetailItem>>();
            response.Data = new List<UserDetailItem>();
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
