using System.Collections.Generic;

namespace CustomCare.Services
{
    public interface IClient
    {
        public Queue<string> CreateCola1();
        public Queue<string> getCola1();
        public Queue<string> AddItemCola1(string cola);
    }
}
