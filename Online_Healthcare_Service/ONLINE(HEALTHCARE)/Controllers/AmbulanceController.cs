using BLL.DTOs;
using BLL.Services;
using ONLINE_HEALTHCARE_.AuthFilters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace ONLINE_HEALTHCARE_.Controllers
{
    public class AmbulanceController : ApiController
    {
        [EnableCors("*", "*", "*")]
        [HttpGet]
        [Route("api/Ambulances")]
        [Logged]
        public HttpResponseMessage Get()
        {
            try
            {
                var data = AmbulanceService.Get().Take(10);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex);
            }

        }
        [EnableCors("*", "*", "*")]
        [HttpGet]
        [Route("api/Ambulance/{id}")]
        [Logged]
        public HttpResponseMessage Get(int id)
        {
            var data = AmbulanceService.Get(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }
        [EnableCors("*", "*", "*")]
        [Route("api/Ambulance/add")]
        [HttpPost]
        [Logged]
        public HttpResponseMessage Add(AmbulanceDTO obj)
        {
            var data = AmbulanceService.Add(obj);
            return Request.CreateResponse(HttpStatusCode.OK, data);

        }
        [EnableCors("*", "*", "*")]
        [Route("api/Ambulance/update")]
        [HttpPost]
        [Logged]
        public HttpResponseMessage Update(AmbulanceDTO Ambulance)
        {

            try
            {
                var isUpdated = AmbulanceService.Update(Ambulance);
                return Request.CreateResponse(HttpStatusCode.OK, isUpdated);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex);
            }

        }
        [EnableCors("*", "*", "*")]
        [Route("api/Ambulance/Delete/{id}")]
        [HttpPost]
        [Logged]
        public HttpResponseMessage DeleteAmbulance(int id)
        {
            var isDeleted = AmbulanceService.Delete(id);

            return isDeleted ? Request.CreateResponse(
                    HttpStatusCode.OK,
                    new
                    {
                        Message = "Ambulance Deleted successfully"
                    }
                ) : Request.CreateResponse(
                    HttpStatusCode.BadRequest,
                    new
                    {
                        Message = "Ambulance Delete unsuccessfull"
                    }
                );
        }



        [EnableCors("*", "*", "*")]
        [HttpGet]
        [Route("api/ambulances/pid/{id}")]
        [Logged]
        public HttpResponseMessage GetById(int id)
        {
            try
            {
                var data = AmbulanceService.GetByPid(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex);
            }

        }
    }
}
