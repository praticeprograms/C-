using CommonLibs.implmentation;
using NUnit.Framework;

namespace Guru99Tests.tests
{
    public class LoginPageTests
    {
        private const string BrowserType = "chrome";

        [Test]
        public void Test1()
        {
            CommonDriver CmnDriver =new CommonDriver("chrome");
            CmnDriver.NavigateToFirstURL("http://demo.guru99.com/v4");

        }
    }
}