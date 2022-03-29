using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiTiemp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OperationController : ControllerBase
    {
        [HttpGet]
        [Route("Sum")]

        public int Sum(
            int numa,
            int numb)
        {
            return numa + numb;
        }
        [HttpPost]
        [Route("Sum")]

        public int SumPost(
            [FromHeader] int numa,
            [FromHeader] int numb)
        {
            return numa + numb;
        }
        [HttpGet]
        [Route("Mul")]

        public int Mul(
            int numa,
            int numb)
        {
            return numa * numb;
        }
        [HttpPost]
        [Route("Mul")]

        public int MulPost(
            [FromHeader] int numa,
            [FromHeader] int numb)
        {
            return numa * numb;
        }
        [HttpGet]
        [Route("Res")]
        public int Res(
            int numa,
            int numb)
        {
            return numa - numb;
        }
        [HttpPost]
        [Route("Res")]

        public int ResPost(
            [FromHeader] int numa,
            [FromHeader] int numb)
        {
            return numa - numb;
        }
        [HttpGet]
        [Route("Div")]

        public int Div(
            int numa,
            int numb)
        {
            return numa / numb;
        }
        [HttpPost]
        [Route("Div")]

        public int DivPost(
            [FromHeader] int numa,
            [FromHeader] int numb)
        {
            return numa / numb;
        }
    }
}
