using Day24UserRegistration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserRegistration;

namespace UserRegistrationTesting
{
    [TestClass]
    public class UnitTest2
    {    
        // Refractor CK Invalid data UC12
        
        [TestMethod]
        public void CheckGiven_FirstName_Validation_usingParamerterisum()
        {
            try
            {
                RefactorData FirstRefactor = new RefactorData(string.Empty);

                string output = FirstRefactor.TestName_Refactor();
            }
            catch (ExceptionRegularRegistration ex)
            {
                Assert.AreEqual("Name is empty", ex.Message);
            }

        } 
        
        //moblie Uc12        
        [TestMethod]
        public void CheckGiven_MobileNumber_Validation_usingParamerterisum()
        {
            try
            {
                RefactorData MobileRefactor = new RefactorData(string.Empty);

                string output = MobileRefactor.TestMobile_Refactor();
            }
            catch (ExceptionRegularRegistration ex)
            {
                Assert.AreEqual("Phone number is empty", ex.Message);
            }

        }

        //Email Uc12 
        [TestMethod]
        public void CheckGiven_Email_Validation_usingParamerterisum()
        {
            try
            {
                RefactorData EmailRefactor = new RefactorData(string.Empty);

                string output = EmailRefactor.TestEmail_Refector();
            }
            catch (ExceptionRegularRegistration ex)
            {
                Assert.AreEqual("Email is empty", ex.Message);
            }

        }
     
        //Password Uc12 
        [TestMethod]
        public void CheckGiven_Password_Validation_usingParamerterisum()
        {
            try
            {
                RefactorData passwordRefactor = new RefactorData(string.Empty);

                string output = passwordRefactor.TestPassword_Refactor();
            }
            catch (ExceptionRegularRegistration ex)
            {
                Assert.AreEqual("Password is empty", ex.Message);
            }

        }

    }
}