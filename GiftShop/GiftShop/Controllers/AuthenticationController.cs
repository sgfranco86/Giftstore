using System;
using System.Web.Http;
using System.Net.Http;
using System.Net;
//using Domain;
using Giftshop.Domain;
using GiftShop.core.IDatos;

namespace GiftShop.Controllers
{
    public class AuthenticationController : ApiGiftShop
    {
        private IAuthentication _service;
        private IUser _Uservice;

        public AuthenticationController(IAuthentication service, IUser UService)
        {
            _service = service;
            _Uservice = UService;
        }

        [HttpPost]
        public HttpResponseMessage Logon(User user)
        {
            try
            {
                if (_service.Authenticate(user))
                {
                    User _usr = _Uservice.GetUser(user.USER_ID, user.PASSWORDX);
                    if (_usr != null)
                    {
                        return Request.CreateResponse(HttpStatusCode.OK,
                        new
                        {
                            status = "ok",
                            user = new
                            {
                                user_id = _usr.USER_ID,
                                passwordx = _usr.PASSWORDX,
                                last_name = _usr.LAST_NAME,
                                first_name = _usr.FIRST_NAME,
                                site_id = _usr.SITE_ID,
                                active = _usr.ACTIVE,
                                inactive_date = _usr.INACTIVE_DATE,

                                admin_access = _usr.ADMIN_ACCESS,
                                setup_access = _usr.SETUP_ACCESS
                               

                            }
                        });
                    }
                    else
                    {
                        return this.responseWithError(new Exception("Username does not exist."));
                    }
                }
                else
                {
                    return this.responseWithError(new Exception("Authentication error, verify your data."));
                }
            }
            catch (Exception ex)
            {
                return this.responseWithError(ex);
            }
        }
    }
}