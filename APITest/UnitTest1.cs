using API.Controllers;
using NUnit.Framework;

namespace APITest
{
    public class Tests
    {

        [Test]
        public void Test1()
        {
            // Arrange
            var controller = new HelloWorldController();
            
            // Act
            var response = controller.Get();

            // Assert
            Assert.AreEqual(response, "Hello World");
        }
    }
}