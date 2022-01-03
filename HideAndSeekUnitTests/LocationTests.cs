using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HideAndSeekUnitTests
{
    using HideAndSeekApp;
    using System.Collections.Generic;
    using System.Linq;

    [TestClass]
    public class LocationTests
    {
        private Location center;
        
        /// <summary>
        /// Initializes each unit test by creating a new center location
        /// and adding a room in each direction before the test
        /// </summary>
        [TestInitialize]
        public void Initialize()
        {
            // You'll use this to create a bunch of locations before each test
        }

        /// <summary>
        /// Makes sure GetExit returns the location in a direction only if it exists
        /// </summary>
        [TestMethod]
        public void TestGetExit()
        {
            // This test will make sure the GetExit method works
        }

        /// <summary>
        /// Validates that the exit lists are working
        /// </summary>
        [TestMethod]
        public void TestExitList()
        {
            //This test will make sure the ExitList property works
        }

        /// <summary>
        /// Validates that each room's name and return exit is created correctly
        /// </summary>
        [TestMethod]
        public void TestReturnExits()
        {
            // This test will test navigating through the center Location
        }

        /// <summary>
        /// Add a hall to one of the rooms and make sure the hall room's names
        /// and return exits are created correctly
        /// </summary>
        [TestMethod]
        public void TestAddHall()
        {
            //This test will add a hallway with two locations and make sure they work
        }
    }
}
