using Autofac;
using CardGameExecutor.Config;
using Microsoft.Extensions.Configuration;
using System;
using System.Threading;

namespace CardGameExecutor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Thread.Sleep(1000);
            Console.WriteLine("Welcome to the Card Game!");
            Thread.Sleep(1000);

            //var builder = new ContainerBuilder();
            //builder.RegisterModule(new AppAutoFacModule());
            //var container = builder.Build();
            //var game = container.Resolve<GameExecutor>();
            var game = new GameExecutor();
            game.StartGame();
        }
    }
}
