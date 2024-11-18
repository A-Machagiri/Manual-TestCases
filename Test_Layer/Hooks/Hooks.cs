using TechTalk.SpecFlow;
using Utilities.WebUtilities;

namespace Test_Layer.Hooks
{
    [Binding]
    public class Hooks
    {
        private WebUtilities webUtilities;

        [BeforeScenario]
        public void BeforeScenario()
        {
            webUtilities = new WebUtilities();
            webUtilities.InitializeDriver("chrome"); // You can change the browser type here
        }

        [AfterScenario]
        public void AfterScenario()
        {
            webUtilities.Quit();
        }
    }
}