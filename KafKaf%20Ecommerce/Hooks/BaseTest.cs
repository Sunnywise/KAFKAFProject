using AventStack.ExtentReports;
using AventStack.ExtentReports.Gherkin.Model;
using AventStack.ExtentReports.Reporter;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
namespace KafKafProject.Hooks
{
    [Binding]
    public sealed class BaseTest
    {
        public static IWebDriver driver;

        // Define global variables for ExtentReports
        private static ExtentReports extent;
        private static ExtentTest featureName;
        private static ExtentTest scenarioName;
        private readonly FeatureContext _featureContext;
        private readonly ScenarioContext _scenarioContext;

        // Project-specific details
        private const string ProjectName = "KafKaf Automation Testing";
        private const string QALead = "Olusegun Yakubu";

        //Constructor for Dependency Injection
        public BaseTest(FeatureContext featureContext, ScenarioContext scenarioContext)
        {
            _featureContext = featureContext;
            _scenarioContext = scenarioContext;
        }

        [BeforeTestRun]
        public static void BeforeTestRun()
        {
            // Setup ExtentReports
            string projectDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName;
            string reportDirectory = Path.Combine(projectDirectory, "Reports");
            Directory.CreateDirectory(reportDirectory);
            string reportPath = Path.Combine(reportDirectory, $"TestReport_{DateTime.Now:yyyyMMdd_HHmmss}.html");

            var spark = new ExtentSparkReporter(reportPath)
            {
                Config = { Theme = AventStack.ExtentReports.Reporter.Config.Theme.Standard }
            };

            extent = new ExtentReports();
            extent.AttachReporter(spark);

            // Add system information
            extent.AddSystemInfo("Project Name", ProjectName);
            extent.AddSystemInfo("QA Lead", QALead);
            extent.AddSystemInfo("Operating System", Environment.OSVersion.ToString());
            extent.AddSystemInfo("Browser", GetSimpleBrowserVersion());
        }

        [AfterTestRun]
        public static void AfterTestRun()
        {
            extent.Flush();
        }

        [BeforeFeature]
        public static void BeforeFeature(FeatureContext featureContext)
        {
            featureName = extent.CreateTest<Feature>(featureContext.FeatureInfo.Title);
        }

        [BeforeScenario]
        public void BeforeScenario()
        {
            // Create a node for the scenario
            scenarioName = featureName.CreateNode<Scenario>(_scenarioContext.ScenarioInfo.Title);

            // Initialize the WebDriver
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://kafkaf.reteicons.com/");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }

        [AfterScenario]
        public void AfterScenario()
        {
            // Close and quit the WebDriver
            driver.Close();
            driver.Quit();
        }

        [BeforeStep]
        public void BeforeStep()
        {
            // Optional: Log information before each step
            string stepText = _scenarioContext.StepContext.StepInfo.Text;
            Console.WriteLine($"Starting step: {stepText}");
        }

        [AfterStep]
        public void AfterStep()
        {
            // Determine the step type (Given, When, Then, And)
            var stepType = _scenarioContext.StepContext.StepInfo.StepDefinitionType.ToString();
            var stepText = _scenarioContext.StepContext.StepInfo.Text;
            var error = _scenarioContext.TestError;

            if (error == null)
            {
                // Add screenshot for passed steps
                var screenshotPath = CaptureScreenshot("PassedStep");
                CreateStepNode(stepType, stepText).Pass("Step passed").AddScreenCaptureFromPath(screenshotPath);
            }
            else
            {
                // Add screenshot for failed steps
                var screenshotPath = CaptureScreenshot("FailedStep");
                CreateStepNode(stepType, stepText).Fail(error.Message).AddScreenCaptureFromPath(screenshotPath);
            }
        }

        private ExtentTest CreateStepNode(string stepType, string stepText)
        {
            return stepType switch
            {
                "Given" => scenarioName.CreateNode<Given>(stepText),
                "When" => scenarioName.CreateNode<When>(stepText),
                "Then" => scenarioName.CreateNode<Then>(stepText),
                "And" => scenarioName.CreateNode<And>(stepText),
                //_ => scenarioName.CreateNode<Generic>(stepText) // Fallback for unexpected step types
            };
        }

        private string CaptureScreenshot(string fileNamePrefix)
        {
            try
            {
                // Define directories and file path
                string projectDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName;
                string screenshotsDirectory = Path.Combine(projectDirectory, "Screenshots");
                Directory.CreateDirectory(screenshotsDirectory);
                string filePath = Path.Combine(screenshotsDirectory, $"{fileNamePrefix}_{DateTime.Now:yyyyMMdd_HHmmss}.png");

                // Capture and save the screenshot
                Screenshot screenshot = ((ITakesScreenshot)driver).GetScreenshot();
                screenshot.SaveAsFile(filePath);

                return filePath;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error capturing screenshot: {ex.Message}");
                return string.Empty;
            }
        }
        private static string GetSimpleBrowserVersion()
        {
            return new ChromeDriver().Capabilities.GetCapability("browserName") + " " +
                   new ChromeDriver().Capabilities.GetCapability("browserVersion");
        }
    }
}