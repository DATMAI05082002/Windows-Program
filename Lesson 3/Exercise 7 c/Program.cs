namespace Exercise_7_c
{
    public class User
    {

        public string firstname { get; set; }

        public string lastname { get; set; }

        public float salary { get; set; }

        internal class Program
        {
            static void Main(string[] args)
            {
                List<User> Users = new List<User>
                {
                    new User { firstname = "John",lastname = "Doe",salary = 1230},
                    new User { firstname = "Lucy", lastname = "Novak", salary = 670},
                    new User { firstname = "Ben", lastname = "Walter", salary = 2050},
                    new User { firstname = "Robin", lastname = "Brown", salary = 2300},
                    new User { firstname = "Amy", lastname = "Doe", salary = 1250},
                    new User { firstname = "Joe", lastname = "Draker", salary = 1190},
                    new User { firstname = "Janet", lastname = "Doe", salary = 980},
                    new User { firstname = "Albert", lastname = "Novak", salary = 1930},


                };
                var sortedUsers = Users.OrderBy(user => user.lastname).ThenBy(user => user.salary).ToList();
                Console.WriteLine("Sorted Users (ascending by last name and salary):");
                foreach (var user in sortedUsers)
                {
                    Console.WriteLine($"First Name: {user.firstname}, Last Name: {user.lastname}, Salary: {user.salary}");
                }
                var usersWithHighSalary = Users.Where(user => user.salary > 1500).ToList();
                Console.WriteLine("\nUsers with salary higher than 1500:");
                foreach (var user in usersWithHighSalary)
                {
                    Console.WriteLine($"First Name: {user.firstname}, Last Name: {user.lastname}, Salary: {user.salary}");
                }

            }
        }
    }
}
