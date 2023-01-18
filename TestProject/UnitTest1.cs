using Day24UserRegistration;
using UserRegistration;
namespace TEST
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CheckFirstName()
        {
            Validation code = new Validation();
            string input = "Amol";
            string output = code.TestName(input);
            Assert.AreEqual(input, output);
        }

        [TestMethod]
        public void CheckLastName()
        {
            Validation code = new Validation();
            string input = "Salunke";
            string output = code.TestName(input);
            Assert.AreEqual(input, output);
        }

        [TestMethod]
        public void CheckEmailId()
        {
            Validation code = new Validation();
            string input = "amolsalunke1097@gmail.com";
            string output = code.TestName(input);
            Assert.AreEqual(input, output);
        }

        [TestMethod]
        public void Checkphone()
        {
            Validation code = new Validation();
            string input = "9112712717";
            string output = code.TestName(input);
            Assert.AreEqual(input, output);
        }

        [TestMethod]
        public void CheckPassword()
        {
            Validation code = new Validation();
            string input = "Amol@1234";
            string output = code.TestName(input);
            Assert.AreEqual(input, output);
        }
        
       //UC11 

        [TestMethod]
        public void CheckGiven_Email_Validation_usingParamerterisum()
        {
            string input = "abc@xyzhg.com";
            RefactorData emailRefactor = new RefactorData(input);

            string output = emailRefactor.TestEmail_Refector();
            Assert.AreEqual("Email  matches", output);
        }
    }
}