using System.Collections.Generic;
using System.Threading;
using CustomCare.Context;
using CustomCare.Services;

namespace CustomerCare.Services
{
    public class ClientService:IClient
    {
        string[] stringArray = new string[] { "Pedro", "Juan", "Messi" };
        Queue<string> Cola1 = new Queue<string>();
        private readonly ApplicationDbContext _context;
        public ClientService(ApplicationDbContext dbContext)
        {
            _context = dbContext;
        }

        public Queue<string> CreateCola1()
        {
            foreach (string cadena in stringArray)
            {
                Cola1.Enqueue(cadena);
                //Thread.Sleep(10000);
            }

            return Cola1;
        }

        public Queue<string> AddItemCola1(string cadena)
        {
            Cola1.Enqueue(cadena);
            return Cola1;
        }

        public Queue<string> getCola1()
        {
            return Cola1;
        }
    }
}
