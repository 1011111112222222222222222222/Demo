using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using EF.Models;
namespace EF.Controllers
{
    
    public class API_WebController : ApiController
    {
        DataClasses2DataContext da = new DataClasses2DataContext();
        
    }
}
