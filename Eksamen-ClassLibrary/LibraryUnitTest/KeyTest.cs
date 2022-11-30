using Eksamen_ClassLibrary;

namespace LibraryUnitTest
{
    [TestClass]
    public class KeyTest
    {
        Key keyNameNull = new Key { Id = 1, Name = null, Email = "Key1@gmail.com", Phone = "12345678" };
        Key keyNameTooShort = new Key { Id = 1, Name = "K", Email = "Key1@gmail.com", Phone = "12345678" };
        Key keyNameTooLong = new Key { Id = 1, Name = "KeyNavnErAltForLangtDetGårSletIkkeDetHer", Email = };


        [TestMethod]
        public void ValidateNameTest()
        {
            keyNameNull.ValidateName();
            Assert.ThrowsException<ArgumentNullException>(() => keyNameNull.ValidateName());
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => keyNameTooShort.ValidateName());

        }

        [TestMethod]
        public void ValidateEmail()
        {

        }

        [TestMethod]
        public void ValidatePhone()
        {

        }

        [TestMethod]
        public void ValidateTest()
        {

        }
    }
}