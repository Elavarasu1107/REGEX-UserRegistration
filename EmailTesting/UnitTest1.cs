namespace UserRegistration
{
    [TestClass]
    public class UnitTest1
    {
        User getMethod = new User();
        //UC 9:
        [TestMethod]
        public void ReadInputFile_CheckEmail_ReturnValid()
        {
            string[] userInput = System.IO.File.ReadAllLines(@"D:\BridgeLabz\REGEX-UserRegistration\UserRegistration\ValidEmail.txt");
            for (int i = 0; i < userInput.Length; i++)
            {
                Assert.AreEqual("Valid", getMethod.EmailChecker(userInput[i]));
            }
        }
        [TestMethod]
        public void ReadInputFile_CheckEmail_ReturnInvalid()
        {
            string[] userInput = System.IO.File.ReadAllLines(@"D:\BridgeLabz\REGEX-UserRegistration\UserRegistration\InvalidEmail.txt");
            for (int i = 0; i < userInput.Length; i++)
            {
                Assert.AreEqual("Invalid", getMethod.EmailChecker(userInput[i]));
            }
        }
        //UC 10:
        [TestMethod]
        public void GetFirstName_CheckRegexPattern_ReturnResult()
        {
            string firstName = "Elavarasu";
            Assert.AreEqual("Valid", getMethod.NameChecker(firstName));
        }
        [TestMethod]
        public void GetLastName_CheckRegexPattern_ReturnResult()
        {
            string lastName = "Appusamy";
            Assert.AreEqual("Valid", getMethod.NameChecker(lastName));
        }
        [TestMethod]
        public void GetEmail_CheckRegexPattern_ReturnResult()
        {
            string email = "abc.xyz@bl.com";
            Assert.AreEqual("Valid", getMethod.EmailChecker(email));
        }
        [TestMethod]
        public void GetPhoneNumber_CheckRegexPattern_ReturnResult()
        {
            string phone = "91 6123457890";
            Assert.AreEqual("Valid", getMethod.Phone(phone));
        }
        [TestMethod]
        public void GetPassword_CheckRegexPattern_ReturnResult()
        {
            string password = "Summa@123";
            Assert.AreEqual("Valid", getMethod.Password(password));
        }
    }
}