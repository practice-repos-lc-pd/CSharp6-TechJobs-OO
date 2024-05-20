﻿
namespace TechJobsOOAutoGraded6
{
    public class Job
    {
        public int Id { get; }
        private static int nextId = 1;
        public string? Name { get; set; }
        public Employer? EmployerName { get; set; }
        public Location? EmployerLocation { get; set; }
        public PositionType? JobType { get; set; }
        public CoreCompetency? JobCoreCompetency { get; set; }

        // TODO: Task 3: Add the two necessary constructors.
        public Job()
        {
            Id = nextId;
            nextId++;
            Name = "Data not available";
        }

        public Job(
            string name,
            Employer employerName,
            Location employerLocation,
            PositionType jobType,
            CoreCompetency jobCoreCompetency
        )
            : this()
        {
            Name = name;
            EmployerName = employerName;
            EmployerLocation = employerLocation;
            JobType = jobType;
            JobCoreCompetency = jobCoreCompetency;
        }

        public override bool Equals(object? obj)
        {
            return obj is Job job &&
                   Id == job.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }

        // TODO: Task 3: Generate Equals() and GetHashCode() methods.

        // TODO: Task 5: Generate custom ToString() method.
        //Until you create this method, you will not be able to print a job to the console.
        public override string ToString()
        {
            string newLine = Environment.NewLine;
            return newLine + $"ID: {Id}" +
                newLine + $"Name: {Name}" + 
                newLine + $"Employer: {EmployerName}" + 
                newLine + $"Location: {EmployerLocation}" + 
                newLine + $"Position Type: {JobType}" + 
                newLine + $"Core Competency: {JobCoreCompetency}" + 
                newLine;
        }
    }
}
