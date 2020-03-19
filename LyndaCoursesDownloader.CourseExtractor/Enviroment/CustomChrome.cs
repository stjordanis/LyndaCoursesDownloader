﻿using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Text;

namespace LyndaCoursesDownloader.CourseExtractor
{
    public class CustomChrome : CustomEnviroment
    {
        public override IWebDriver CreateWebDriver()
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            var service = ChromeDriverService.CreateDefaultService("./");
            var chromeOptions = new ChromeOptions();

            chromeOptions.PageLoadStrategy = PageLoadStrategy.Eager;
            chromeOptions.AddArgument("-headless");
            chromeOptions.AddArgument("--log-level=OFF");
            chromeOptions.AddArgument("--mute-audio");
            service.HideCommandPromptWindow = true;
            IWebDriver driver = null;
            driver = new ChromeDriver(service, chromeOptions);
            FixDriverCommandExecutionDelay(driver);


            return driver;
        }


    }
}