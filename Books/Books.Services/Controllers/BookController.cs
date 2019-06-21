using System;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Net;
using System.Security.Claims;
using System.Text;
using Books.Business.Abstract;
using Books.Entities.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using Microsoft.AspNetCore.Cors;

namespace Books.Services.Controllers
{
   
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly IBookService _bookService;
        public BookController(IBookService bookService)
        {

            _bookService = bookService;
        }
        
        [HttpPost]
        public IActionResult Post([FromBody]Book model)
        {

            if (ModelState.IsValid)
            {

                _bookService.Add(model);
               
            }

            return Ok(model);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id,[FromBody]Book model)
        {
            model = _bookService.GetByBook(id);
            if (ModelState.IsValid)
            {

                _bookService.Update(model);

            }

            return Ok(model);
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {

         _bookService.Delete(id);

          return Ok();
        }
        [HttpGet]
        public IEnumerable<Book> Get()
        {

            var Books = _bookService.GetAll();
            return _bookService.GetAll(); 
        }




    }
}