using APISimber.Entitys;
using APISimber.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APISimber.Controllers
{
    [ApiController]
    [Route("ReaderTicket")]
    public class ReaderTicketController : ControllerBase
    {
        private readonly IReaderTicketRepository repository;

        public ReaderTicketController(IReaderTicketRepository repository)
        {
            this.repository = repository;
        }
        [HttpPost]
        public ActionResult<LibraryTicket> CreateLibraryTicket(LibraryTicket ticket)
        {
            repository.CreateLibrariTicket(ticket);
            return Ok();
        }
        [HttpGet]
        public ActionResult<LibraryTicket> GetLibraryTicket()
        {
            repository.GetReaderTocket();
            return Ok();
        }
    }
}