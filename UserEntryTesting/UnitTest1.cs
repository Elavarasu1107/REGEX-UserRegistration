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
                try
                {
                    User getMethod = new User(userInput[i]);
                    Assert.AreEqual("Invalid", getMethod.EmailChecker());
                }
                catch (Exception ex)
                {
                    Assert.AreEqual("Invalid Email", ex.Message);
                }
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
        //UC12:
        [TestMethod]
        public void GetInvalidFirstName_checkRegexPattern_ShouldThrowInvalidNameException()
        {
            try
            {
                string firstName = "elavarasu...";
                string excepted = "Valid";
                User getMethod = new User(firstName);
                string actual = getMethod.NameChecker();
                excepted.Equals(actual);
            }
            catch (Exception ex)
            {
                Assert.AreEqual("Invalid Name", ex.Message);
            }
        }
        [TestMethod]
        public void GetInvalidLastName_checkRegexPattern_ShouldThrowInvalidNameException()
        {
            try
            {
                string lastName = "appusamy...";
                string excepted = "Valid";
                User getMethod = new User(lastName);
                string actual = getMethod.NameChecker();
                excepted.Equals(actual);
            }
            catch (Exception ex)
            {
                Assert.AreEqual("Invalid Name", ex.Message);
            }
        }
        [TestMethod]
        public void GetInvalidEmail_checkRegexPattern_ShouldThrowInvalidEmailException()
        {
            try
            {
                string email = "xyz@abc@bl.com";
                string excepted = "Valid";
                User getMethod = new User(email);
                string actual = getMethod.EmailChecker();
                excepted.Equals(actual);
            }
            catch (Exception ex)
            {
                Assert.AreEqual("Invalid Email", ex.Message);
            }
        }
        [TestMethod]
        public void GetInvalidPhoneNumber_CheckRegexPattern_ShouldThrowInvalidNumberException()
        {
            try
            {
                string number = "987654321200";
                string excepted = "Valid";
                User getMethod = new User(number);
                string actual = getMethod.Phone();
                excepted.Equals(actual);
            }
            catch (Exception ex)
            {
                Assert.AreEqual("Invalid PhoneNumber", ex.Message);
            }
        }
        [TestMethod]
        public void GetInvalidPassword_CheckRegexPattern_ShouldThrowInvalidPasswordException()
        {
            try
            {
                string password = "Summa@123#";
                string excepted = "Valid";
                User getMethod = new User(password);
                string actual = getMethod.Password();
                excepted.Equals(actual);
            }
            catch (Exception ex)
            {
                Assert.AreEqual("Invalid Password", ex.Message);
            }
        }
    }
}