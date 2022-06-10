namespace UserRegistration
{
    [TestClass]
    public class UnitTest1
    {
        //UC 9 & UC11
        [TestMethod]
        public void ReadInputFile_CheckEmail_ReturnValid()
        {
            string[] userInput = System.IO.File.ReadAllLines(@"D:\BridgeLabz\REGEX-UserRegistration\UserRegistration\ValidEmail.txt");
            for (int i = 0; i < userInput.Length; i++)
            {
                User getMethod = new User(userInput[i]);
                Assert.AreEqual("Valid", getMethod.EmailChecker());
            }
        }
        [TestMethod]
        public void ReadInputFile_CheckEmail_ReturnInvalid()
        {
            string[] userInput = System.IO.File.ReadAllLines(@"D:\BridgeLabz\REGEX-UserRegistration\UserRegistration\InvalidEmail.txt");
            for (int i = 0; i < userInput.Length; i++)
            {
                User getMethod = new User(userInput[i]);
                Assert.AreEqual("Invalid", getMethod.EmailChecker());
            }
        }
        //UC 10:
        [TestMethod]
        public void GetFirstName_CheckRegexPattern_ReturnResult()
        {
            string firstName = "Elavarasu";
            User getMethod = new User(firstName);
            Assert.AreEqual("Valid", getMethod.NameChecker());
        }
        [TestMethod]
        public void GetLastName_CheckRegexPattern_ReturnResult()
        {
            string lastName = "Appusamy";
            User getMethod = new User(lastName);
            Assert.AreEqual("Valid", getMethod.NameChecker());
        }
        [TestMethod]
        public void GetEmail_CheckRegexPattern_ReturnResult()
        {
            string email = "abc.xyz@bl.com";
            User getMethod = new User(email);
            Assert.AreEqual("Valid", getMethod.EmailChecker());
        }
        [TestMethod]
        public void GetPhoneNumber_CheckRegexPattern_ReturnResult()
        {
            string phone = "91 6123457890";
            User getMethod = new User(phone);
            Assert.AreEqual("Valid", getMethod.Phone());
        }
        [TestMethod]
        public void GetPassword_CheckRegexPattern_ReturnResult()
        {
            string password = "Summa@123";
            User getMethod = new User(password);
            Assert.AreEqual("Valid", getMethod.Password());
        }
    }
}