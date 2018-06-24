using OpenQA.Selenium;

namespace SeleniumCSharpProject
{
    enum PropertyType
    {
        Id,
        Name,
        ClassName,
        CSSProperty,
        Xpath,
    }
    class CommonUtility
    {
        
        //Auto-implemented property
        public static IWebDriver driver{ get; set; }
    }
}
