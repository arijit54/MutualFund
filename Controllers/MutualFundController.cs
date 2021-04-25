using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MutualFund.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace MutualFund.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MutualFundController : ControllerBase
    {
        private IMutualFundDb MutualFundDbObj;

        public MutualFundController(IMutualFundDb obj)
        {
            MutualFundDbObj = obj;
        }
        [HttpGet]
        public ActionResult<MutualFundDb> GetMutualFunds()
        {
            var temp = new List<dynamic>();
            foreach(var x in MutualFundDb.mutualFundDetailList)
            {
                x.ToString();
                temp.Add(x);
            }
            if (temp != null)
                return Ok(temp);
            else
                return BadRequest();
        }
    }
}
