using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1
{
        public class Beaf
        {

        }

        public class Soup
        {

        }

        public class Tea
        {

        }

        public class SideDish
        {

        }

        public class Lunch
        {
            private Beaf MakeBeaf()
            {
                Thread.Sleep(5000);
                return new Beaf();
            }

            private Soup MakeSoup()
            {
                Thread.Sleep(7000);
                return new Soup();
            }

            private Tea MakeTea()
            {
                Thread.Sleep(2000);
                return new Tea();
            }

            private SideDish MakeSideDish()
            {
                Thread.Sleep(3000);
                return new SideDish();
            }

            private Task<Beaf> StartMakeBeaf()
            {
                var taskForMakeBeaf = Task.Run(() => MakeBeaf());
                return taskForMakeBeaf;
            }

            private Task<Soup> StartMakeSoup()
            {
                var taskForMakeSoup = Task.Run(() => MakeSoup());
                return taskForMakeSoup;
            }   
            
            private Task<Tea> StartMakeTea()
            {
                var taskForMakeTea = Task.Run(() => MakeTea());
                return taskForMakeTea;
            }

            private Task<SideDish> StartMakeSideDish()
            {
                var taskForMakeSideDish = Task.Run(() => MakeSideDish());
                return taskForMakeSideDish;
            }

            public async void MakeLunchAsync()
            {
                Console.WriteLine("Мы начали готовить обед " + DateTime.Now);
                Console.WriteLine("Мы начали готовить мясо " + DateTime.Now);
                var TaskBeaf = StartMakeBeaf();
                Console.WriteLine("Мы начали готовить суп " + DateTime.Now);
                var TaskSoup = StartMakeSoup();
                Console.WriteLine("Мы начали готовить чай " + DateTime.Now);
                var TaskTea = StartMakeTea();
                Console.WriteLine("Мы начали готовить гарнир " + DateTime.Now);
                var TaskSideDish = StartMakeSideDish();


                var Beaf = await TaskBeaf;
                Console.WriteLine("Мы закончили готовить мясо " + DateTime.Now);

                var Soup = await TaskSoup;
                Console.WriteLine("Мы закончили готовить суп " + DateTime.Now);

                var Tea = await TaskTea;
                Console.WriteLine("Мы закончили готовить чай " + DateTime.Now);

                var SideDish = await TaskSideDish;
                Console.WriteLine("Мы закончили готовить гарнир " + DateTime.Now);

            }

        }
}
