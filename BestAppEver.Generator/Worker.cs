using BestAppEver.API.Models;
using BestAppEver.Generator.TaskClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BestAppEver.Generator
{
    class Worker
    {
        public String Name { get; set; }
        public ICollection<TaskClasses.Task> CompletedTasks { get; set; }
        private DataType DataType { get; }
        private ResultType ResultType { get; }

        public Worker(String name, DataType dataType, ResultType resultType)
        {
            Random randomizer = new Random();
            this.Name = name;
            this.DataType = dataType;
            this.ResultType = resultType;
        }

        public String Introduce()
        {
            return $"[{Name}], Typ zadań: [{DataType}], Rezultat zadań: [{ResultType}]";
        }

        public String Stats()
        {
            var shortTasks = CompletedTasks.Where(n => n.Data.TimeExpected < 10);
            var longTasks = CompletedTasks.Where(n => n.Data.TimeExpected > 10);

            var easyTasks = CompletedTasks.Where(n => n.Data.DifficultyWorker < 50);
            var hardTasks = CompletedTasks.Where(n => n.Data.DifficultyWorker > 50);

            var shortData = $"Zadan krotkich: ({shortTasks.Count()}) \t Dobrze: [{shortTasks.Where(n => n.Result.Type == ResultType.Good).Count()}]\t Neutralnie: [{shortTasks.Where(n => n.Result.Type == ResultType.Neutral).Count()}]\t Zle: [{shortTasks.Where(n => n.Result.Type == ResultType.Bad).Count()}]\t Okropnie: [{shortTasks.Where(n => n.Result.Type == ResultType.Terrible).Count()}]\n";
            var longData = $"Zadan dlugich: ({longTasks.Count()}) \t Dobrze: [{longTasks.Where(n => n.Result.Type == ResultType.Good).Count()}]\t Neutralnie: [{longTasks.Where(n => n.Result.Type == ResultType.Neutral).Count()}]\t Zle: [{longTasks.Where(n => n.Result.Type == ResultType.Bad).Count()}]\t Okropnie: [{longTasks.Where(n => n.Result.Type == ResultType.Terrible).Count()}]";

            return shortData + longData;
        }
    }
}
