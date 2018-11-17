using BeatAppEver.API.Generator.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BestAppEver.API.Models
{
    public class Task
    {
        public int Id { get; set; }

        public int DificultyGradeByWorker { get; set; }
        public int DificultyGradeByLeader { get; set; }

        public int TimeEstimatedByWorker { get; set; }
        public int ActualTimePassed { get; set; }

        public int ResultGradeByWorker { get; set; }
        public int ResultGradeByLeader { get; set; }

        public string username { get; set; }

        public bool IsCompleted { get; set; }
        public DateTime CompletedAt { get; set; }

        public DateTime CreatedAt { get; set; }

        public string Title { get; set; }
        public string Description { get; set; }

    }
}
