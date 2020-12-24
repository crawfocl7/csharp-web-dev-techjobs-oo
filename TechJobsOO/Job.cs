using System;
using System.Collections.Generic;

namespace TechJobsOO
{
    public class Job
    {
        public int Id { get; }
        private static int nextId = 1;

        public string Name { get; set; }
        public Employer EmployerName { get; set; }
        public Location EmployerLocation { get; set; }
        public PositionType JobType { get; set; }
        public CoreCompetency JobCoreCompetency { get; set; }

        // TODO: Add the two necessary constructors.
        public Job()
        {
            Id = nextId;
            nextId++;
        }

        public Job(string name, Employer employerName, Location employerLocation, PositionType jobType, CoreCompetency coreComptency) : this()
        {
            Name = name;
            EmployerName = employerName;
            EmployerLocation = employerLocation;
            JobType = jobType;
            JobCoreCompetency = coreComptency;
        }

        public override bool Equals(object obj)
        {
            return obj is Job job &&
                    Id == job.Id;
        }

        // TODO: Generate Equals() and GetHashCode() methods.
        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }

        public override string ToString()
        {
            if (Name == null)
            {
                return String.Format("OOPS! This job does not seem to exist.");
            }
            else
            {
                string name = String.IsNullOrEmpty(Name) ? "Data not available" : Name;
                string employer = String.IsNullOrEmpty(EmployerName.Value) ? "Data not available" : EmployerName.Value;
                string location = String.IsNullOrEmpty(EmployerLocation.Value) ? "Data not available" : EmployerLocation.Value;
                string jobtype = String.IsNullOrEmpty(JobType.Value) ? "Data not available" : JobType.Value;
                string competency = String.IsNullOrEmpty(JobCoreCompetency.Value) ? "Data not available" : JobCoreCompetency.Value;
                return String.Format("\nID: {0}\nName: {1}\nEmployer: {2}\nLocation: {3}\nPosition Type: {4}\nCore Competency: {5}\n", Id, name, employer, location, jobtype, competency);
            }
            }
        }
}
