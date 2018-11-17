using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace BestAppEver.Generator.TaskClasses
{
    public class TaskData
    {
        public int TimeExpected { get; set; }
        public int TimeReal { get; set; }
        public int DifficultyWorker { get; set; }
        public int DifficultyLeader { get; set; }

        public TaskData(DataType type)
        {
            Random randomizer = new Random();

            switch (type)
            {
                case DataType.Quick_Hard:
                    this.TimeExpected = randomizer.Next(1, 10);
                    this.TimeReal = randomizer.Next(1, 10);
                    this.DifficultyWorker = randomizer.Next(50, 100);
                    this.DifficultyLeader = randomizer.Next(50, 100);
                    break;
                case DataType.Quick_Easy:
                    this.TimeExpected = randomizer.Next(1, 10);
                    this.TimeReal = randomizer.Next(1, 10);
                    this.DifficultyWorker = randomizer.Next(1, 50);
                    this.DifficultyLeader = randomizer.Next(1, 50);
                    break;
                case DataType.Long_Hard:
                    this.TimeExpected = randomizer.Next(10, 20);
                    this.TimeReal = randomizer.Next(10, 20);
                    this.DifficultyWorker = randomizer.Next(50, 100);
                    this.DifficultyLeader = randomizer.Next(50, 100);
                    break;
                case DataType.Long_Easy:
                    this.TimeExpected = randomizer.Next(10, 20);
                    this.TimeReal = randomizer.Next(10, 20);
                    this.DifficultyWorker = randomizer.Next(1, 50);
                    this.DifficultyLeader = randomizer.Next(1, 50);
                    break;
                default:
                    break;
            }

            Thread.Sleep(1);
        }
    }
}
