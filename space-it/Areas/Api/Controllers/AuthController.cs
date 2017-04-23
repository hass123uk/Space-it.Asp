using System;
using System.Collections.Generic;
using System.Net;
using System.Web.Http;
using Space_it.Core.Entities;
using Space_it.Core.Services;
using Space_it.Web.Areas.Api.ApiModels;
using System.Net.Http;
using System.Web.Security;

namespace Space_it.Web.Areas.Api.Controllers
{
    [Authorize]
    [RoutePrefix("api/auth")]
    public class AuthController : ApiController
    {
        private readonly IAuthService _authService;

        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }

        [Route("me")]
        public HttpResponseMessage Me()
        {
            if (User.Identity.IsAuthenticated)
            {
                var user = _authService.GetByEmail(User.Identity.Name);
                return Request.CreateResponse(new ApiUserModel(user));
            }
            return Request.CreateResponse();
        }

        [AllowAnonymous]
        [HttpPost]
        [Route("login")]
        public HttpResponseMessage Login([FromBody] ApiLoginModel model)
        {
            if (!ModelState.IsValid)
                return Request.CreateResponse(HttpStatusCode.BadRequest);

            if (!Membership.ValidateUser(model.Email, model.Password))
                return Request.CreateResponse(HttpStatusCode.Unauthorized);

            FormsAuthentication.SetAuthCookie(model.Email, model.RememberMe);
            return Request.CreateResponse(HttpStatusCode.OK);
        }

        [AllowAnonymous]
        [HttpPost]
        [Route("register")]
        public HttpResponseMessage Register(ApiRegisterModel model)
        {
            if (!ModelState.IsValid)
                return Request.CreateResponse(HttpStatusCode.BadRequest);

            var user = _authService.RegisterUser(model.Email, model.Password);
            if (user != null)
            {
                FormsAuthentication.SetAuthCookie(user.Email, model.RememberMe);
                return Request.CreateResponse("/");
            }
            else
            {
                if (!Membership.ValidateUser(model.Email, model.Password))
                    return Request.CreateResponse(HttpStatusCode.Unauthorized);

                FormsAuthentication.SetAuthCookie(model.Email, model.RememberMe);
                return Request.CreateResponse("/");
            }

        }

        [HttpGet]
        [Route("logout")]
        public HttpResponseMessage Logout()
        {
            FormsAuthentication.SignOut();
            return Request.CreateResponse(HttpStatusCode.OK);
        }
    }
}