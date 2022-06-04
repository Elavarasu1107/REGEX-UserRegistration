namespace UserRegistration
{
    [TestClass]
    public class UnitTest1
    {
        User getMethod = new User();
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
    }
}