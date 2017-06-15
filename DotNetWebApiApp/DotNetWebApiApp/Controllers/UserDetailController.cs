using System.Collections.Generic;
using System.Web.Http;
using DotNetWebApiApp.Models;
using App.DomainModels;
using App.Business.Interfaces;
namespace DotNetWebApiApp.Controllers
{
    [RoutePrefix("api/UserDetail")]
    public class UserDetailController : BaseController
    {
        #region Properties
        private readonly IUserDetailManager userDetailManager;
        #endregion

        #region Constructors
        public UserDetailController(IUserDetailManager userDetailMgr)
        {
            this.userDetailManager = userDetailMgr;
        }
        #endregion

        #region Public Methods
        [Route("GetAll")]
        [HttpGet]
        public IHttpActionResult GetAllRecords()
        {
            var response = new ApiResponse<IEnumerable<UserDetailItem>>();
            response.Data = userDetailManager.GetAllAvailableUsers();
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
        #endregion
    }
}
