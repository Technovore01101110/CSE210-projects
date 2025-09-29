public class Resume
{
    // attributes
    public string person_name;
    public List<Job> _Jobs = new List<Job>();

    // behaviors
    public void Display()
    {
        Console.WriteLine($"Name: {person_name}");

        Console.WriteLine("Jobs:");

        foreach (Job job in _Jobs)
        {
            job.Display();
        }
    }
}