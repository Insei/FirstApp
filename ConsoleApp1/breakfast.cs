using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1
{

    public class Omelette
    {

    }
    public class Coffe
    {

    }

    public class ButterBread
    {

    }
    public class breakfast
    {

        private Omelette MakeOmelette()
        {
            Thread.Sleep(3000);
            return new Omelette();
        }

        private Coffe MakeCoffe()
        {
            Thread.Sleep(5500);
            return new Coffe();
        }

        private ButterBread MakeButterBread()
        {
            Thread.Sleep(1000);
            return new ButterBread();
        }

        private Task<Omelette> StartMakeOmelette()
        {
            var taskForMakeOmlet = Task.Run(() => MakeOmelette());
            return taskForMakeOmlet;
        }

        private Task<Coffe> StartMakeCoffe()
        {
            var taskForMakeCoffe = Task.Run(() => MakeCoffe());
            return taskForMakeCoffe;
        }

        private Task<ButterBread> StartMakeButterBread()
        {
            var taskForMakeButterBread = Task.Run(() => MakeButterBread());
            return taskForMakeButterBread;
        }             

        public async void MakeABreakfastAsync()
        {
            Console.WriteLine("Мы начали готовить завтрак " + DateTime.Now);

            Console.WriteLine("Мы начали готовить кофе " + DateTime.Now);
            var TaskCoffe = StartMakeCoffe();
            Console.WriteLine("Мы начали готовить омлет " + DateTime.Now);
            var TaskOmlete = StartMakeOmelette();
            Console.WriteLine("Мы начали готовить бутеры " + DateTime.Now);
            var TaskButterBread = StartMakeButterBread();


            var ButterBread = await TaskButterBread;
            Console.WriteLine("Мы закончили готовить бутеры " + DateTime.Now);
            var Coffe = await TaskCoffe;
            Console.WriteLine("Мы закончили готовить кофе " + DateTime.Now);
            var Omlette = await TaskOmlete;
            Console.WriteLine("Мы закончили готовить омлет " + DateTime.Now);
        }
    }
}
