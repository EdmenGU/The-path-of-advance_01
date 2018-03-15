using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyMVC_Project1.Models
{
    public class SkyZenTask
    {
        public int id { get; set; }

        public string TaskName { get; set; }

        public string TaskDesc { get; set; }

        public int TaskOwner { get; set; }

        public string TaskOwnerCount { get; set; }

        public int TaskDistributor { get; set; }

        public string TaskDistributorCount { get; set; }

        public int TaskIteration { get; set; }

        public string TaskIterationName { get; set; }

        public decimal TaskEstimate { get; set; }

        public decimal ExeEstimate { get; set; }

        //开发任务总估时
        public decimal developEstimate { get; set; }

        //联调任务总估时
        public decimal unitDebugEstimate { get; set; }

        //测试任务总估时
        public decimal testEstimate { get; set; }

        //杂项任务总沽时
        public decimal misEstimate { get; set; }

        public string WorkIds { get; set; }

        public int WorkId { get; set; }

        public string TaskGroupId { get; set; }

        public DateTime TaskStartTime { get; set; }

        public DateTime TaskEndTime { get; set; }

        public DateTime taskBeginDat { get; set; }

        public DateTime taskEndDate { get; set; }

        //0-未完成；1-开发完成；2-自测完成；4-QA测试未通过；5-审查未通过
        public int TaskStatus { get; set; }

        public int TaskType { get; set; }

        public int IsValid { get; set; }

        public string EAttribute1 { get; set; }

        public string EAttribute2 { get; set; }

        public string EAttribute3 { get; set; }

        public string EAttribute4 { get; set; }

        public string EAttribute5 { get; set; }

        public int StoryId { get; set; }

        public string StoryName { get; set; }

        public int DepartmentId { get; set; }

        public int startSize { get; set; }

        public int endSize { get; set; }

        public int CompletionRate { get; set; }

        public int PlanCompletionRate { get; set; }

        public decimal RemainTasks { get; set; }

        public int IterationId { get; set; }

        public string IterationName { get; set; }
        //已填工作量
        public decimal exeTime { get; set; }

    }
}