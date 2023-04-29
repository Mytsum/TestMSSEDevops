using TestDevOpsWebApp.Pages;

namespace TestProjectMSSEDevops
{
    [TestClass]
    public class IndexTest
    {
        private readonly IndexModel _indexModel;

        public IndexTest()
        {
            _indexModel = new IndexModel(null);
            Authenticate_My_Login_Credentials();
        }

        [TestMethod]
        public void Authenticate_My_Login_Credentials()
        {
            // Assert.Fail();
            string user = "test";
            string password = "passcode";
            var result = _indexModel.Authenticate(user, password);
            Assert.IsNull(result);
        }
        [TestMethod]
        public void Add_Two_Numbers()
        {
            int a = 4;
            int b = 5;
            var result = _indexModel.Add(a, b);
            Assert.AreEqual(9, result);
        }
    }
}