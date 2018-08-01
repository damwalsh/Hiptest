using System;
using TechTalk.SpecFlow;

namespace UnitTestProject1...................GitHub.Hiptest
{
    [Binding]
    public class HipTestDemoV_1Steps
    {
        [Given(@"I have a website: http://secure\.smartbearsoftware\.com/samples/TestComplete(.*)/WebOrders/Login\.aspx\?ReturnUrl=%(.*)fsamples%(.*)fTestComplete(.*)fWebOrders%(.*)fDefault\.aspx")]
        public void GivenIHaveAWebsiteHttpSecure_Smartbearsoftware_ComSamplesTestCompleteWebOrdersLogin_AspxReturnUrlFsamplesFTestCompletefWebOrdersFDefault_Aspx(int p0, int p1, int p2, string p3, int p4)
        {
            ScenarioContext.Current.Pending();
        }
        #sample updat
        [Given(@"I want to login with the username of tester and password of test")]
        public void GivenIWantToLoginWithTheUsernameOfTesterAndPasswordOfTest()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"I have reached the Orders page")]
        public void GivenIHaveReachedTheOrdersPage()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"I want to place an order using the Customer name of ""(.*)""")]
        public void GivenIWantToPlaceAnOrderUsingTheCustomerNameOf(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"I want to use the addresses of my parameters")]
        public void GivenIWantToUseTheAddressesOfMyParameters(Table table)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I should successfully login")]
        public void ThenIShouldSuccessfullyLogin()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"a")]
        public void ThenA()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
