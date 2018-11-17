using AForge.Neuro;
using AForge.Neuro.Learning;
using System;
using System.Linq;
using AForge.Neuro;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using BestAppEver.Generator.TaskClasses;
using BestAppEver.Generator;

namespace BestAppEver.NNApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [HttpGet("{PersonId}/{TimeExpected}/{TimeReal}/{DifficultyWorker}/{DifficultyLeader}")]
        public double[] Get(string PersonId, int TimeExpected, int TimeRealint, int DifficultyWorker, int DifficultyLeader)
        {
            var net = Network.Load(PersonId);
            var input = new double[4] { (double)TimeExpected / 100, (double)TimeRealint / 100, (double)DifficultyWorker / 100, (double)DifficultyLeader / 100 };
            return net.Compute(input);
        }

        [HttpGet("{PersonId}/{DataType}/{ResultType}")]
        public bool Get(string PersonId, Generator.TaskClasses.DataType DataType, ResultType ResultType)
        {
            var tasks = TasksGenerator.GenTasks(DataType, ResultType, 400);
            var input = tasks.Select(n => n.GetDataArray()).ToArray();
            var output = tasks.Select(n => n.GetResultArray()).ToArray();

            var function = new SigmoidFunction();
            var network1 = new ActivationNetwork(function, 4, 9, 15, 30, 15, 9, 2);
            var teacher1 = new ResilientBackpropagationLearning(network1);

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 1000; j++)
                {
                    teacher1.RunEpoch(input, output);
                }
            }
            network1.Save(PersonId);
            return true;
        }
    }
}
