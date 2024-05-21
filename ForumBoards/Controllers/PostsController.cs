using API.Client.Models;
using ForumBoards.Core.Generics;
using ForumBoards.Core.Queries;
using ForumBoards.Core.Results;
using ForumBoards.QueryHandlers.Models.Abstraction;
using ForumBoards.QueryHandlers.Models.Posts;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API.Client.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class PostsController : ControllerBase
    {
        private readonly IHandleQuery<PostRequestQuery, QueryResult<IEnumerable<PostRequestResult>>> _postRequestHandler;

        public PostsController(
            IHandleQuery<PostRequestQuery, QueryResult<IEnumerable<PostRequestResult>>> postRequestHandler)
        {
            _postRequestHandler = postRequestHandler;
        }
        // GET: api/<ValuesController>
        [HttpGet]
        public IActionResult Get([FromForm]  PostRequestModel request)
        {
            PostRequestQuery postRequestQuery = new (request.Id);
            var result = _postRequestHandler.Handle(postRequestQuery);

            if (!result.Successful)
                return BadRequest();

            //Create Factory Pattern
            return Ok(result.Result);
        }

        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ValuesController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
