namespace SystemManegementUniversity
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a List Of Person
            List<Person> people = new List<Person>();

            // Add Multiple Students To The List
            people.Add(new Student("Behnam", 32, "S12345", "Computer Science"));
            people.Add(new Student("Ahmad", 22, "S54321", "Mathematics"));
            people.Add(new Student("Behrooz", 22, "S54321", "Phisics"));

            // Add Multiple Teachers To The List
            people.Add(new Professor("Beygi", 40, "P67890", "Computer Science"));
            people.Add(new Professor("Panahpoor", 30, "P09876", "Computer Science"));

            Console.WriteLine("\nUniversity Management System:\n");
            foreach (var person in people)
            {
                Console.WriteLine(person.GetDetails());
            }
            Console.WriteLine("-------------------------------------------------------------------------------------------");
            Console.ReadKey();
        }
    }
}