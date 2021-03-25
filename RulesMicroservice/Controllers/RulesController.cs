using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RulesMicroservice.Controllers
{
    //https://localhost:44374/api/rules

    [Route("api/[controller]")]
    [ApiController]
    public class RulesController : ControllerBase
    {
        [HttpGet]
        public string EvaluateMinBal(double balance, int AccountId)
        {
            string ruleStatus = "Denied";
            double minBalance = 1000;
            if(balance < minBalance)
            {
                ruleStatus = "Denied";
            }
            else if(balance > minBalance)
            {
                ruleStatus = "Allowed";
            }
            return ruleStatus;
        }

        //[HttpGet]
        //public float GetServiceCharges()
        //{
        //    float serviceCharge = 550;
        //    return serviceCharge;
        //}
    }
}
