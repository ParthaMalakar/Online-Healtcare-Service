using BLL.DTOs;
using BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net;
using System.Web;
using System.Web.Http.Cors;
using System.Web.Http;
using ONLINE_HEALTHCARE_.AuthFilters;

namespace ONLINE_HEALTHCARE_.Controllers
{
    public class FeedbackController : ApiController
    {

        [EnableCors("*", "*", "*")]
        [HttpGet]
        [Route("api/feedbacks")]
        [Logged]
        public HttpResponseMessage Get()
        {
            try
            {
                var data = PatientFeedbackService.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex);
            }

        }
        [EnableCors("*", "*", "*")]
        [HttpGet]
        [Route("api/feedbacak/{id}")]
        [Logged]
        public HttpResponseMessage Get(int id)
        {
            var data = PatientFeedbackService.Get(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }
        [EnableCors("*", "*", "*")]
        [Route("api/feedback/add")]
        [HttpPost]
        [Logged]
        public HttpResponseMessage Add(PatientFeedbackDTO obj)
        {
            var data = PatientFeedbackService.Add(obj);
            return Request.CreateResponse(HttpStatusCode.OK, data);

        }
       
        [EnableCors("*", "*", "*")]
        [Route("api/feedback/delete/{id}")]
        [HttpPost]
        [Logged]
        public HttpResponseMessage Delete(int id)
        {
            var isDeleted = PatientFeedbackService.Delete(id);

            return isDeleted ? Request.CreateResponse(
                    HttpStatusCode.OK,
                    new
                    {
                        Message = " Deleted successfully"
                    }
                ) : Request.CreateResponse(
                    HttpStatusCode.BadRequest,
                    new
                    {
                        Message = " Delete unsuccessful"
                    }
                );
        }

    }
}