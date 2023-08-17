namespace ElevatorControlExample.Services
{
    public interface IElevatorService
    {
        (int min, int max) GetFloorRange();
        Boolean CallToFloor(int floor);
        Boolean UserFloorSelect(int floor);
        IEnumerable<int> FloorsSelected();
        int NextFloor();
    }
}
