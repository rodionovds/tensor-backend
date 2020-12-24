using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Museum.Dtos;
using Museum.Dtos.Doll;
using MuseumData;
using MuseumData.Models;

namespace Museum.Controllers
{
    [Route("v1/[controller]")]
    [ApiController]
    public class DollsController : Controller
    {
        private readonly IDoll _doll;
        private readonly IMapper _mapper;

        public DollsController(IDoll doll, IMapper mapper)
        {
            _doll = doll;
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult<IEnumerable<DollReadDto>> GetAll(int limit = 0)
        {
            IEnumerable<Doll> dolls;
            if (limit > 0)
                dolls = _doll.GetWithLimit(limit);
            else if (limit == 0)
            {
                dolls = _doll.GetAll();
            }
            else
                return NotFound(new ErrorModel()
                {
                    Code = 404,
                    Message = "Dolls list is empty."
                });

            return Ok(_mapper.Map<IEnumerable<DollReadDto>>(dolls));
        }
    }
}