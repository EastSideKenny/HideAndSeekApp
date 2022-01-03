using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HideAndSeekApp
{
    public static class House
    {
        /// <summary>
        /// Returns the starting location for the palyer
        /// </summary>
        public static readonly Location Entry;

        /// <summary>
        /// Sets up the house data structure
        /// </summary>
        static House()
        {
            Entry = new Location("Entry");
            var garage = new Location("Garage");
            var hallway = new Location("Hallway");
            var kitchen = new Location("Kitchen");
            var bathroom = new Location("Bathroom");
            var livingRoom = new Location("Living Room");
            var landing = new Location("Landing");
            var masterBedroom = new Location("Master Bedroom");
            var masterBath = new Location("Master Bath");
            var secondBathroom = new Location("Second Bathroom");
            var nursery = new Location("Nursery");
            var pantry = new Location("Pantry");
            var kidsRoom = new Location("Kids Room");
            var attic = new Location("Attic");

            Entry.AddExit(Direction.East, hallway);
            Entry.AddExit(Direction.Out, garage);
            hallway.AddExit(Direction.Northwest, kitchen);
            hallway.AddExit(Direction.North, bathroom);
            hallway.AddExit(Direction.South, livingRoom);
            hallway.AddExit(Direction.Up, landing);
            landing.AddExit(Direction.Northwest, masterBedroom);
            masterBedroom.AddExit(Direction.East, masterBath);
            landing.AddExit(Direction.West, secondBathroom);
            landing.AddExit(Direction.Southwest, nursery);
            landing.AddExit(Direction.South, pantry);
            landing.AddExit(Direction.Southeast, kidsRoom);
            landing.AddExit(Direction.Up, attic);
        }
    }
}
