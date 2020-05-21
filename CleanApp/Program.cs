using CleanApp.WireUp;
using Domain.UseCases;
using Ninject;
using System;

namespace CleanApp
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            IKernel kernel = new StandardKernel(new OrderWireUp());
            var useCase = kernel.Get<GetOrderInteractor>();

            var order = useCase.Handle();
            Console.WriteLine("Id :{0} ", order.ID);
            Console.WriteLine("Name :{0} ", order.Name);

            order.DetailEntitys.ForEach(p =>
            {
                Console.WriteLine("--Id :{0} ", p.Id);
                Console.WriteLine("--Tedad :{0} ", p.Tedad);
            });

            Console.ReadLine();
        }
    }
}