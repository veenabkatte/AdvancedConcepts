using System;
using System.Collections.Generic;
using System.Text;

namespace AdvancedConcepts
{
    class CompositionDemo1
    {
        static void Main()
        {
            List<Room> rooms = new List<Room> {
                new Room(200),
                new Room(300)
            };

            Home home1 = new Home(rooms);
            home1.Dispose();
            Console.ReadLine();
        }
    }

    class Home : IDisposable
    {
        public List<Room> Rooms { get; set; }

        public Home(List<Room> rooms)
        {
            this.Rooms = rooms;
        }

        public void Dispose()
        {
            foreach (var room in Rooms)
            {
                room.Dispose();
            }
            this.Dispose();
        }
    }
    class Room : IDisposable
    {
        public int Sqrft { get; set; }
        public Room(int sqrft)
        {
            this.Sqrft = sqrft;
        }

        public void Dispose()
        {
            this.Dispose();
        }
    }
}
