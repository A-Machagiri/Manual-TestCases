// Test_Layer/Hooks/Hooks.cs
using TechTalk.SpecFlow;
using YourNamespace.Utilities.WebUtilities;

namespace YourNamespace.Test_Layer.Hooks
{
    [Binding]
    public class Hooks
    {
        private readonly WebUtilities webUtilities = new WebUtilities();

        [BeforeScenario]
        public void BeforeScenario()
        {
            webUtilities.InitializeDriver("chrome");
        }

        [AfterScenario]
        public void AfterScenario()
        {
            webUtilities.Quit();
        }
    }
}