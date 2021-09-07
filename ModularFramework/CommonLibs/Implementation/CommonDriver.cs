using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;

namespace CommonLibs.implmentation
{
    public class CommonDriver
    {
        public IWebDriver Driver{get; private set;}
        public int PageLoadTimeout { private get => pageLoadTimeout; set => pageLoadTimeout = value; }
        public int ElementDetectiontimeout { private get => elementDetectiontimeout; set => elementDetectiontimeout = value; }

        private int pageLoadTimeout;

        private int elementDetectiontimeout;

       public CommonDriver(string browserType)
       {
           browserType = browserType.Trim();
           pageLoadTimeout =60;
           elementDetectiontimeout=10;

           if(browserType.Equals("chrome")){
               Driver =new ChromeDriver();
           }else if(browserType.Equals("edge")){
                 Driver =new EdgeDriver();
           }else{
               throw new Exception("Invalid Browser Type"+browserType);
           }

       }
public void NavigateToFirstURL(string url){
    url = url.Trim();
    Driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(pageLoadTimeout);
    Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(elementDetectiontimeout);
    Driver.Url=url;

    }
}
}