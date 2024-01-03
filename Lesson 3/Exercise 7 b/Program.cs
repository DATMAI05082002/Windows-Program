namespace Exercise_7_b
{
    public class Car
    {

        public string Name { get; set; }

        public float Price { get; set; }

        internal class Program
        {
            static void Main(string[] args)
            {
                List<Car> Cars = new List<Car>
                {
                    new Car { Name = "Audi", Price = 52642 },
                    new Car { Name = "Mercedes", Price = 57127 },
                    new Car { Name = "Skoda", Price = 9000 },
                    new Car { Name = "Volvo", Price = 29000 },
                    new Car { Name = "Bently", Price = 350000 },
                    new Car { Name = "Citroen", Price = 21000 },
                    new Car { Name = "Hummer", Price = 41400 },
                    new Car { Name = "Volkswagen", Price = 21600 }
                };
                var carsInRange = Cars.Where(car => car.Price >= 30000 && car.Price <= 100000).ToList();

                // Hiển thị thông tin của những xe nằm trong khoảng giá đó
                Console.WriteLine("Cars in the price range of 30000 to 100000:");
                foreach (var car in carsInRange)
                {
                    Console.WriteLine($"Name: {car.Name}, Price: {car.Price}");
                }
            }
        }
    }
}
        
    

