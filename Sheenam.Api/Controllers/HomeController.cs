//======================
// Copyright (c) Coalition of Good-Hearted Engineers 
// Free ToUse Comfort and Peace 
//======================

using Microsoft.AspNetCore.Mvc;
using RESTFulSense.Controllers; 

namespace Sheenam.Api.Controllers
{
    [ApiController]
    [Route("api/Controller")]
    public class HomeController : RESTFulController
    {
        [HttpGet]
        public ActionResult <string> Get() =>
            Ok("Hello marion, the princess is in another castle:");
    }
}
