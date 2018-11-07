using StoryQ;

namespace Xunit.StoryQ.Tests
{
    public class SampleTest
    {
        [Fact]
        public void StoryQTest1()
        {
            Feature story = new Story("Feature 1")
                .InOrderTo("Do something 1")
                .AsA("user")
                .IWant("Verify feature one");

            story.WithScenario("Given When Then Test 1")
                .Given(GivenMethod)
                .When(WhenMethod)
                .Then(ThenMethod);

            story.WithScenario("Given When Then Test 2")
                .Given(GivenMethod)
                .When(WhenMethod)
                .Then(ThenMethod);

            story.Execute();
        }

        private void GivenMethod() { }
        private void WhenMethod() { }
        private void ThenMethod() { }
    }
}
