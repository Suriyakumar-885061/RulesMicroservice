using System;
using RulesMicroservice.Controllers;
using NUnit.Framework;

namespace RulesTest
{
    public class Class1
    {
        [Test]
        public void EvaluateMinBal_InvalidData()
        {
            var balance = 500;
            var accountid = 1001;
            RulesController controller = new RulesController();
            string result = controller.EvaluateMinBal(balance, accountid);
            Assert.AreEqual(result,"Denied");
        }

        [Test]
        public void EvaluateMinBal_validData()
        {
            var balance = 5500;
            var accountid = 1001;
            RulesController controller = new RulesController();
            string result = controller.EvaluateMinBal(balance, accountid);
            Assert.AreEqual(result, "Allowed");
        }
    }
}
