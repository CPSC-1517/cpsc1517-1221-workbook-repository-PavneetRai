
using NhlSystem;
namespace TestNhlSystem
{
    [TestClass]
    public class PersonTest
    {
        [TestMethod]
        [DataRow("Connor Mcdavid")]
        [DataRow("Leon Draistal")]

        //[DataRow(null)]
        //[DataRow("")]
        public void FullName_ValidName_FullNameSet(string fullname)
        {
            var validPerson = new Person(fullname);
            Assert.AreEqual(fullname, validPerson.FullName);

            //var validPerson = new Person("Connor McDavid");
            //Assert.AreEqual("Connor McDavid", validPerson.FullName);


        }
        [TestMethod]
        

        [DataRow(null)]
        [DataRow("")]
        [DataRow("     ")]
        public void FullName_InvalidName_ArguementNullException(string fullname)
        {
            
            //var invalidPerson = new Person(fullname);
            var ex = Assert.ThrowsException<ArgumentNullException>(() => new Person(fullname));
            Assert.AreEqual("FullName value is required", ex.ParamName);
            //Assert.AreEqual(fullname, validPerson.FullName);

            //var validPerson = new Person("Connor McDavid");
            //Assert.AreEqual("Connor McDavid", validPerson.FullName);


        }
        [DataRow(null)]
        [DataRow("A")]
        [DataRow("AB")]
        [DataRow(" A ")]

        public void FullName_InvalidNameLength_ArguementException(string fullname)
        {

            var ex = Assert.ThrowsException<ArgumentException>(() => new Person(fullname));
            Assert.AreEqual("FullName must contain 3 or more characters", ex.ParamName);


        }
    }
}