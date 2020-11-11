/*
Find the maximum profit job sequence from a given array of jobs
with deadlines and profits.
*/
namespace TheAlgorithms.Greedy
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Greedy
    {
        public IEnumerable<string> ScheduleJobs(IEnumerable<Job> jobList, int schedulableJobs)
        {
            int size = jobList.ToArray().Length;

            IOrderedEnumerable<Job> jobs = jobList.OrderByDescending(item => item.Profit);

            var result = new bool[schedulableJobs];
            var JobsIdList = new string[schedulableJobs];

            foreach(Job job in jobs)
            {
                for (int j = Math.Min(schedulableJobs - 1, job.Deadline - 1); j >= 0; j-- )
                {
                    // free slot found (start from last possible slot)
                    if (!result[j])
                    {
                        result[j] = true;
                        JobsIdList[j] = job.JobId;
                        break;
                    }
                }
            }

            return JobsIdList.Where(item => item != null);
        }
    }

    public class Job
    {
        public string JobId { get; set; }
        public int Deadline { get; set; }
        public int Profit { get; set; }
    }
}
