using SharpObjToXmlServiceProg.AAPublic;
using SharpObjToXmlServiceProg.Service;
using SharpObjToXmlServiceTests.Extensions;

namespace SharpObjToXmlServiceTests
{
    [TestClass]
    public class UnitTest1
    {
        private readonly IObjToXmlService subject;

        public UnitTest1()
        {
            subject = OutBorder.ObjToXmlService();
        }

        [TestMethod]
        public void TestMethod1()
        {
            // arrange
            var patient = new Patient()
            {
                ID = 232323,
                FirstName = "John",
                LastName = "Doe",
                Birthday = new DateTime(1990, 12, 30),
                RoomNo = 310
            };

            var expected = GetFirstXmlString();

            // act
            var success =  subject.Serialize(patient, out var result);

            // assert
            Assert.AreEqual(true, success);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestMethod2()
        {
            // arrange
            var input = GetFirstXmlString();

            var expected = new Patient()
            {
                ID = 232323,
                FirstName = "John",
                LastName = "Doe",
                Birthday = new DateTime(1990, 12, 30),
                RoomNo = 310
            };

            // act
            var success = subject.Deserialize<Patient>(input, out var result);

            // assert
            var objsEqual = result.PublicPropertiesEqual<Patient>(expected);
            Assert.AreEqual(true, objsEqual);
            Assert.AreEqual(true, success);
        }

        private string GetFirstXmlString()
        {
            return """
<?xml version="1.0" encoding="utf-16"?>
<Patient xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance" xmlns:xsd="http://www.w3.org/2001/XMLSchema">
  <ID>232323</ID>
  <FirstName>John</FirstName>
  <LastName>Doe</LastName>
  <Birthday>1990-12-30T00:00:00</Birthday>
  <RoomNo>310</RoomNo>
</Patient>
""";
        }
    }
}