using BestAppEver.API.Models;
using BestAppEver.Generator.TaskClasses;
using System;
using System.Collections.Generic;
using System.Text;

namespace BestAppEver.Generator
{
    public class TasksGenerator
    {
        public static ICollection<TaskClasses.Task> GenTasks(DataType dataType, ResultType resultType, int amountOfTasks)
        {
            var taskList = new List<TaskClasses.Task>();
            Random randomizer = new Random();

            for (int i = 0; i < amountOfTasks; i++)
            {

                if (randomizer.Next(1, 100) < 70)
                {
                    taskList.Add(new TaskClasses.Task(dataType, resultType));
                }
                else
                {
                    Array enums = Enum.GetValues(typeof(DataType));
                    var randomDataType = (DataType)enums.GetValue(randomizer.Next(enums.Length));
                    Array resultEnums = Enum.GetValues(typeof(ResultType));
                    var randomOtherResult = (ResultType)resultEnums.GetValue(randomizer.Next(resultEnums.Length));

                    taskList.Add(new TaskClasses.Task(randomDataType, randomOtherResult));
                }
            }
            return taskList;
        }
    }
}
