using OpenQA.Selenium;

namespace PageObjectHM.Pages
{
    public class DashboardPage : BasePage
    {
        private static string END_POINT = "/inventory.html";
        
        // Описание элементов
        private static readonly By SidebarProjectsAddButtonBy = By.Id("add-to-cart-sauce-labs-backpack");
        
        public DashboardPage(IWebDriver driver, bool openPageByUrl) : base(driver, openPageByUrl)
        {
        }

        public DashboardPage(IWebDriver driver) : base(driver)
        {
        }

        public override bool IsPageOpened()
        {
            try
            {
                return SidebarProjectsAddButton.Displayed;
            }
            catch (Exception)
            {
                return false;
            }
            
        }

        protected override string GetEndpoint()
        {
            return END_POINT;
        }

        public IWebElement SidebarProjectsAddButton => WaitsHelper.WaitForExists(SidebarProjectsAddButtonBy);
    }
}