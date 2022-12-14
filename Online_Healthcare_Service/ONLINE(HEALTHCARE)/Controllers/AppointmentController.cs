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
    public class AppointmentController : ApiController
    {
        [EnableCors("*", "*", "*")]
        [HttpGet]
        [Route("api/Appointments")]
        [Logged]
        public HttpResponseMessage Get()
        {
            try
            {
                var data = AppointmentService.Get().Take(10);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex);
            }

        }



        [EnableCors("*", "*", "*")]
        [HttpGet]
        [Route("api/Appointments/pid/{id}")]
        [Logged]
        public HttpResponseMessage GetById(int id)
        {
            try
            {
                var data = AppointmentService.GetByPid(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex);
            }

        }




        [EnableCors("*", "*", "*")]
        [HttpGet]
        [Route("api/Appointment/{id}")]
        [Logged]
        public HttpResponseMessage Get(int id)
        {
            var data = AppointmentService.Get(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }
        [EnableCors("*", "*", "*")]
        [Route("api/Appointment/add")]
        [HttpPost]
        [Logged]
        public HttpResponseMessage Add(AppointmentDTO obj)
        {
            var data = AppointmentService.Add(obj);
            return Request.CreateResponse(HttpStatusCode.OK, data);

        }
        [EnableCors("*", "*", "*")]
        [Route("api/Appointment/update")]
        [HttpPost]
        [Logged]
        public HttpResponseMessage Update(AppointmentDTO Appointment)
        {

            try
            {
                var isUpdated = AppointmentService.Update(Appointment);
                return Request.CreateResponse(HttpStatusCode.OK, isUpdated);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex);
            }

        }
        [EnableCors("*", "*", "*")]
        [Route("api/appointment/delete/{id}")]
        [HttpPost]
        [Logged]
        public HttpResponseMessage DeleteAppointment(int id)
        {
            var isDeleted = AppointmentService.Delete(id);

            return isDeleted ? Request.CreateResponse(
                    HttpStatusCode.OK,
                    new
                    {
                        Message = "Appointment Deleted successfully"
                    }
                ) : Request.CreateResponse(
                    HttpStatusCode.BadRequest,
                    new
                    {
                        Message = "Appointment Delete unsuccessfully"
                    }
                );
        }
    }
}
