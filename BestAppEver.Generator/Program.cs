using BestAppEver.Generator.TaskClasses;
using System;

namespace BestAppEver.Generator
{
    class Program
    {
        static void Main(string[] args)
        {
            Worker worker1 = new Worker("Worker 1", DataType.Quick_Easy, ResultType.Good)
            {
                CompletedTasks = TasksGenerator.GenTasks(DataType.Quick_Easy, ResultType.Good, 1000)
            };
            Console.WriteLine(worker1.Introduce());
            Console.WriteLine(worker1.Stats());
            Console.WriteLine();

            Worker worker2 = new Worker("Worker 2", DataType.Quick_Hard, ResultType.Neutral)
            {
                CompletedTasks = TasksGenerator.GenTasks(DataType.Quick_Hard, ResultType.Neutral, 1000)
            };
            Console.WriteLine(worker2.Introduce());
            Console.WriteLine(worker2.Stats());
            Console.WriteLine();

            Worker worker3 = new Worker("Worker 3", DataType.Long_Easy, ResultType.Bad)
            {
                CompletedTasks = TasksGenerator.GenTasks(DataType.Long_Easy, ResultType.Bad, 1000)
            };
            Console.WriteLine(worker3.Introduce());
            Console.WriteLine(worker3.Stats());
            Console.WriteLine();

            Worker worker4 = new Worker("Worker 4", DataType.Long_Hard, ResultType.Terrible)
            {
                CompletedTasks = TasksGenerator.GenTasks(DataType.Long_Hard, ResultType.Terrible, 1000)
            };
            Console.WriteLine(worker4.Introduce());
            Console.WriteLine(worker4.Stats());

            Console.ReadKey();
        }
    }
}
