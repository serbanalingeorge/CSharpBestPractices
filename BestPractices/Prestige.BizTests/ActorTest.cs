using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Prestige.Biz;

namespace Prestige.BizTests
{
    [TestClass]
    public class ActorTest
    {
        [TestMethod]
        public void TestGetOccupation()
        {
            //Arrange
            var actor = new Actor();
            const string expected = "Actor";

            //Act
            var result = actor.GetOccupation();

            //Assert
            Assert.AreEqual(expected,result);
        }

        [TestMethod]
        public void TestSettingObjectProperty()
        {
            //Arrange
            var currentActor = new Actor();
            currentActor.ActorName = "Johnny Boy";
            const string expected = "Johnny Boy";
            //Act
            var result = currentActor.ActorName;
            //Assert
            Assert.AreEqual(expected,result);
        }

        [TestMethod]
        public void TestParameterizedConstructor()
        {
            //Arrange
            var currentActor = new Actor("Johnny Boy");
            const string expected = "Johnny Boy";
            //Act
            var result = currentActor.ActorName;
            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestBookActor()
        {
            //Arrange
            var details = "Booking can change if actor starts trouble.";
            var currentActor = new Actor("Johnny Boy");
            var expected = "Actor Johnny Boy is booked. " + details;
            //Act
            var result = currentActor.BookActor();
            //Assert
            Assert.AreEqual(expected,result);
        }

        [TestMethod]
        public void TestBookActorOnSpecificDate()
        {
            //Arrange
            var details = "Booking can change if actor starts trouble.";
            var currentActor = new Actor("Johnny Boy");
            var expected = "Actor Johnny Boy is booked on " + DateTime.Today.ToShortDateString() + ". " + details;
            //Act
            var result = currentActor.BookActor(DateTime.Today.ToShortDateString());
            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestFormattingOnSetterBookActor()
        {
            //Arrange
            var details = "Booking can change if actor starts trouble.";
            var currentActor = new Actor("Johnny Boy      ");
            var expected = "Actor Johnny Boy is booked. " + details;
            //Act
            var result = currentActor.BookActor();
            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestAutoPropActorDescription()
        {
            //Arrange
            var currentActor = new Actor {ActorName = "Sandy Love"};
            var expected = "Regular actor";
            //Act
            var result = currentActor.ActorDescription;
            //Assert
            Assert.AreEqual(expected,result);
        }

        [TestMethod]
        public void TestAutoPropInitActorAge()
        {
            //Arrange
            var currentActor = new Actor {ActorName = "Sandy Love", ActorAge = 46};
            var expected = 46;
            //Act
            var result = currentActor.ActorAge;
            //Assert
            Assert.AreEqual(expected,result);
        }

        [TestMethod]
        public void TestGetAgency()
        {
            //Arrange
            var currentActor = new Actor();
            var expected = "Prestige Talent";
            //Act
            var result = currentActor.GetAgency();
            //Assert
            Assert.AreEqual(expected,result);
        }
    }
}
