namespace TheAlgorithms.Greedy
{
    using FluentAssertions;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using Xunit;

    public class GreedyTest
    {
        private readonly Greedy greedy = new Greedy();

        [Fact]
        public void Should_Schedule_Jobs()
        {
            // arrange
            IEnumerable<Job> jobs = GetJobs();

            // act
            IEnumerable<string> scheduledJobIds =  greedy.ScheduleJobs(jobs, 5);

            // assert
            scheduledJobIds.Should().HaveCount(3);
            scheduledJobIds.ToArray()[0].Should().Be("c");
            scheduledJobIds.ToArray()[1].Should().Be("a");
            scheduledJobIds.ToArray()[2].Should().Be("e");
        }

        public IEnumerable<Job> GetJobs()
        {
            var job1 = new Job
            {
                JobId = "a",
                Deadline = 2,
                Profit = 100
            };

            var job2 = new Job
            {
                JobId = "b",
                Deadline = 1,
                Profit = 19
            };

            var job3 = new Job
            {
                JobId = "c",
                Deadline = 2,
                Profit = 27
            };

            var job4 = new Job
            {
                JobId = "d",
                Deadline = 1,
                Profit = 25
            };

            var job5 = new Job
            {
                JobId = "e",
                Deadline = 3,
                Profit = 15
            };

            return new[] { job1, job2, job3, job4, job5};
        }
    }
}
