using AdventOfCodeDay2;
using NUnit.Framework;

namespace AdventOfCodeDay2UnitTests
{
    public class Tests
    {
        private PasswordManager pwdManager;
        private AlgorithmManager algoManager;
        private string[] passwords;

        [SetUp]
        public void Setup()
        {
        }

        /// <summary>
        /// Naming convention: [methodName]_[input]_[expectedOutput]()
        /// </summary>

        [Test]
        public void GetPasswords_None_IsNotNull()
        {
            //Arrange
            pwdManager = new PasswordManager();
            
            //Act:
            var passwords = pwdManager.GetPasswords();

            //Assert:
            Assert.NotNull(passwords);
        }

        [Test]
        public void SplitPasswordString_PasswordString_ArrayWith4Records()
        {
            //Arrange:
            pwdManager = new PasswordManager();
            string password = "9-12 q: qqqxhnhdmqqqqjz";

            //Act:
            var result = pwdManager.SplitPasswordString(password);
            //Assert:
            Assert.AreEqual(4, result.Length);
        }

        //569 & 346 are the correct answers for my day 2 problem, hence the specific outcome.
        [Test]
        public void StartFirstAssigment_AOCPasswordFile_569ValidPasswords()
        {
            //Arrange:
            pwdManager = new PasswordManager();
            algoManager = new AlgorithmManager();

            //Act: 
            int result = algoManager.StartFirstAssignment(pwdManager);

            //Assert:
            Assert.AreEqual(569, result);
        }

        [Test]
        public void StartSecondAssignment_AOCPasswordFile_342ValidPasswords()
        {
            //Arrange:
            pwdManager = new PasswordManager();
            algoManager = new AlgorithmManager();

            //Act:
            int result = algoManager.StartSecondAssignment(pwdManager);

            //Assert:
            Assert.AreEqual(346, result);
        }
    }
}