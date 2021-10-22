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
    public  class UpdateUser
    {
        private readonly ICrud _crud;
        public UpdateUser(ICrud crud)
        {
            _crud = crud;
        }
        [FunctionName("UpdateUser")]
        public async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Function, "get", "post", Route = "{newUserName}/{id}")] HttpRequest req, string newUserName, int id)
        {

            return new OkObjectResult(_crud.UpdateUser(newUserName,id));
        }
    }
}
