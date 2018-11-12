using Microsoft.VisualStudio.TestTools.UnitTesting;

using FluxDayAutomation.PageObjects;

namespace FluxDayAutomation
{
    [TestClass]
    public class Default_UnitTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            var p = new POLogin();
            var s = p.GetElementType("user_email");
            var s2 = p.GetElementType("btn-login");
            var s3 = p.GetElementType("user_password");

            var b1 = p.IsElementPresent("user_email", "inputbox");
            var b2 = p.IsElementPresent("user_password", "checkbox");
        }
    }
}
