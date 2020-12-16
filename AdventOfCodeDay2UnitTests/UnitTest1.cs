using AdventOfCodeDay2;
using NUnit.Framework;

namespace AdventOfCodeDay2UnitTests
{
    public class Tests
    {
        private PasswordManager pwdManager;
        private AlgorithmManager algoManager;

        [SetUp]
        public void Setup()
        {
            //Arrange:
            pwdManager = new PasswordManager();
            algoManager = new AlgorithmManager();

        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }
    }
}