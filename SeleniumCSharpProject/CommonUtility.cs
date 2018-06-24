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
    public class CommonUtility
    {
        
        //Auto-implemented property
        public IWebDriver driver{ get; set; }
    }
}
