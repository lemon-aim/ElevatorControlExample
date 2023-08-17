namespace ElevatorControlExample.Services
{
    /// <summary>
    /// A class that represents the elevator state
    /// </summary>
    public class MockElevatorService : IElevatorService
    {
        private const int MinFloor = 1;
        private const int MaxFloor = 10;

        /// <summary>
        /// Requests the minimum and maximum valid floors this elevator can access
        /// </summary>
        /// <returns> A tuple of ints, first value is minimum floor, second value is maximum floor</returns>
        public (int min, int max) GetFloorRange()
        {
            return (MinFloor, MaxFloor);
        }

        /// <summary>
        /// Call for elevator when user requests an elevator to pick them up
        /// </summary>
        /// <param name="floor">Floor the user is at when they call an elevator</param>
        /// <returns>True if operation was successful</returns>
        public Boolean CallToFloor(int floor)
        {
            return true;
        }

        /// <summary>
        /// Call for elevator when user selects the floor inside of the elevator
        /// </summary>
        /// <param name="floor">Floor the user requested</param>
        /// <returns>True if operation was successful</returns>
        public Boolean UserFloorSelect(int floor)
        {
            return true;
        }

        /// <summary>
        /// Returns all user selected floors
        /// </summary>
        /// <returns>Contains all user selected floors</returns>
        public IEnumerable<int> FloorsSelected()
        {
            var selectedFloors = new List<int>();

            //Generating mock data
            var random = new Random();
            for(var i = MinFloor; i <= MaxFloor; i++)
            {
                if (random.Next(2) == 0) 
                {
                    selectedFloors.Add(i);
                }
            }
            return selectedFloors;
        }

        /// <summary>
        /// Returns the next floor the elevator should go to
        /// </summary>
        /// <returns></returns>
        public int NextFloor()
        {
            var random = new Random();
            return random.Next(10) + 1;
        }
    }
}
