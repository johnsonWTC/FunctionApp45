using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace FunctionApp45
{
    public  class FindUserByID
    {

        private readonly ICrud _crud;
        public FindUserByID(ICrud crud)
        {
            _crud = crud;
        }


        [FunctionName("FindUserByID")]
        public  async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Function, "get", "post", Route = "FindUserById/{id}")] HttpRequest req, int id)
        {
          
            return new OkObjectResult(_crud.FindUserNameByID(id));
        }
    }
}
