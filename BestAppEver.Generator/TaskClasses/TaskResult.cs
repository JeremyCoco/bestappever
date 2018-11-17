using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace BestAppEver.Generator.TaskClasses
{
    public class TaskResult
    {
        public int ResultWorker { get; }
        public int ResultLeader { get; }
        public ResultType Type { get; }

        public TaskResult(ResultType type)
        {
            this.Type = type;
            Random randomizer = new Random();
            switch (type)
            {
                case ResultType.Good:
                    this.ResultWorker = randomizer.Next(75, 100);
                    this.ResultLeader = randomizer.Next(75, 100);
                    break;
                case ResultType.Neutral:
                    this.ResultWorker = randomizer.Next(50, 75);
                    this.ResultLeader = randomizer.Next(50, 75);
                    break;
                case ResultType.Bad:
                    this.ResultWorker = randomizer.Next(25, 50);
                    this.ResultLeader = randomizer.Next(25, 50);
                    break;
                case ResultType.Terrible:
                    this.ResultWorker = randomizer.Next(0, 25);
                    this.ResultLeader = randomizer.Next(0, 25);
                    break;
                default:
                    break;
            }
            Thread.Sleep(1);
        }
    }
}
