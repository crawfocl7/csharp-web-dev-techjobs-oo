using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechJobsOO;
using System;

namespace TechJobTests
{
    [TestClass]
    public class JobTests
    {
        [TestMethod]
        public void TestSettingJobId()
        {
            Job test_job1 = new Job();
            Job test_job2 = new Job();
            int differBy1 = test_job2.Id - test_job1.Id;
            //Test that job object id's are not the same.
            Assert.IsFalse(test_job1.Id == test_job2.Id);

            //Test that job object id's are different by 1.
            Assert.AreEqual(1, differBy1);

        }

        [TestMethod]
        public void TestJobConstructorSetsAllFields()
        {
            Job test_job3 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            Assert.AreEqual("Product tester", test_job3.Name);
            Assert.AreEqual("ACME", test_job3.EmployerName.Value);
            Assert.AreEqual("Desert", test_job3.EmployerLocation.Value);
            Assert.AreEqual("Quality control", test_job3.JobType.Value);
            Assert.AreEqual("Persistence", test_job3.JobCoreCompetency.Value);
        }

        [TestMethod]

        public void TestJobsForEquality()
        {
            Job test_job4 = new Job("Santa's helper", new Employer("Santa Clause, Inc."), new Location("North Pole"), new PositionType("Elf"), new CoreCompetency("On the Good List"));
            Job test_job5 = new Job("Santa's helper", new Employer("Santa Clause, Inc."), new Location("North Pole"), new PositionType("Elf"), new CoreCompetency("On the Good List"));
            bool testJobEquality = test_job4.Equals(test_job5);
            Assert.AreEqual(false, testJobEquality);
        }

        [TestMethod]

        public void TestToString()
        {
            bool correctNewLineEntries = false;
            Job test_job6 = new Job("Reindeer Specialist", new Employer("Santa Clause, Inc."), new Location("North Pole"), new PositionType("Reindeer Support"), new CoreCompetency("Veterinarian"));
            string jobToString = test_job6.ToString();
            if (jobToString[0] == '\n' && jobToString[jobToString.Length - 1] == '\n')
            {
                correctNewLineEntries = true;
            }
            Assert.IsTrue(correctNewLineEntries);
        }
    }
}
