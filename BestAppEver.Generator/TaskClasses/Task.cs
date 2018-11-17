using System;
using System.Collections.Generic;
using System.Text;

namespace BestAppEver.Generator.TaskClasses
{
    public class Task
    {
        public TaskData Data { get; set; }
        public TaskResult Result { get; set; }

        public Task(DataType dataType, ResultType resultType)
        {
            this.Data = new TaskData(dataType);
            this.Result = new TaskResult(resultType);
        }

        public Task(DataType dataType)
        {
            this.Data = new TaskData(dataType);
            this.Result = null;
        }

        public double[] GetDataArray()
        {
            return new double[] { (double)Data.TimeExpected / 100, (double)Data.TimeReal / 100, (double)Data.DifficultyWorker / 100, (double)Data.DifficultyLeader / 100 };
        }

        public double[] GetResultArray()
        {
            return new double[] { (double)Result.ResultWorker / 100, (double)Result.ResultLeader / 100 };
        }

        public String Display()
        {
            var data = $"Czas oczekiwany: [{Data.TimeExpected}], Czas rzeczywisty: [{Data.TimeReal}], Trudnosc (pracownik): [{Data.DifficultyWorker}], Trudność (lider): [{Data.DifficultyLeader}],";
            var result = Result != null ? $"Ocena pracownika: [{Result.ResultWorker}], Ocena lidera: [{Result.ResultLeader}]" : "Brak rezultatu";
            return data + "\t" + result;
        }
    }
}
