public class Engine
{
    public int acceleration { get; set; }
    public void Accelerate(int acceleration)
    {
        this.acceleration = acceleration;
        Console.WriteLine("Accelerating with {0} KMH", acceleration);
    }

    public void Brake()
    {
        Console.WriteLine("Braking...");
    }

    public void TurnLeft()
    {
        Console.WriteLine("Turning left...");
    }

    public void TurnRight()
    {
        Console.WriteLine("Turning right...");
    }
}