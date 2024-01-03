namespace Exercise_7
{
    public class User
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public string Birthdate { get; set; }

    }

    internal class Program
    {
        public static void Main()
        {
            List<User> Users = new List<User>
            {
                new User { ID = 1, Name = "Jhon", City = "London", Birthdate = "2001-04-01" },
                new User { ID = 2, Name = "Lenny", City = "New York", Birthdate = "1997-12-11" },
                new User { ID = 3, Name = "Andrew", City = "Boston", Birthdate = "1987-02-22" },
                new User { ID = 4, Name = "Peter", City = "Prague", Birthdate = "1936-03-24" },
                new User { ID = 5, Name = "Anna", City = "Bratislava", Birthdate = "1973-11-18" },
                new User { ID = 6, Name = "Alber", City = "Bratislava", Birthdate = "1940-12-11" },
                new User { ID = 7, Name = "Adam", City = "Trnava", Birthdate = "1983-12-01" },
                new User { ID = 8, Name = "Robert", City = "Bratislava", Birthdate = "1935-05-15" },
                new User { ID = 9, Name = "Robert", City = "Prague", Birthdate = "1998-03-14" },
            };

            var usersInBratislava = Users.Where(user => user.City == "Bratislava").ToList();
            Console.WriteLine("Users in Bratislava:");
            foreach (var user in usersInBratislava)
            {
                Console.WriteLine($"ID: {user.ID}, Name: {user.Name}, City: {user.City}, Birthdate: {user.Birthdate}");
            }

        }


    }
}
