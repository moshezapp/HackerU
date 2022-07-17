using HackeruLecturers.Data;
using HackeruLecturers.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;

namespace HackeruLecturers.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class LecturersController : ControllerBase
    {
        private readonly IDAL _dalProvider;

        public LecturersController(IDAL dalProvider)
        {
            _dalProvider = dalProvider;
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpGet(Name = "GetAllLecturers")]
        public ActionResult<List<Lecturer>> GetAllLecturers()
        {
            try
            {
                return _dalProvider.GetAllLectures();
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }


        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpGet(Name = "GetAllLanguages")]
        public ActionResult<List<Language>> GetAllLanguages()
        {
            try
            {
                return _dalProvider.GetAllLanguages();
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }
    }
}
