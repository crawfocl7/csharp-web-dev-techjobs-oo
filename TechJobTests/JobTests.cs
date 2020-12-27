using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechJobsOO;

namespace TechJobTests
{
    [TestClass]
    public class JobTests
    {
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
            bool hasCorrectNewLines = false;
            Job test_job6 = new Job("Reindeer Specialist", new Employer("Santa Clause, Inc."), new Location("North Pole"), new PositionType("Reindeer Support"), new CoreCompetency("Veterinarian"));
            string jobToString = test_job6.ToString();
            if (jobToString.StartsWith('\n') && jobToString.EndsWith('\n'))
            {
                hasCorrectNewLines = true;
            }
            Assert.IsTrue(hasCorrectNewLines);
        }

        [TestMethod]
        public void TestToStringLabels()
        {
            Job test_job7 = new Job("Reindeer Specialist", new Employer("Santa Clause, Inc."), new Location("North Pole"), new PositionType("Reindeer Support"), new CoreCompetency("Veterinarian"));
            string correctStringLabels = $"\nID: {test_job7.Id}\nName: {test_job7.Name}\nEmployer: {test_job7.EmployerName.Value}\nLocation: {test_job7.EmployerLocation.Value}\nPosition Type: {test_job7.JobType.Value}\nCore Competency: {test_job7.JobCoreCompetency.Value}\n";
            Assert.AreEqual(correctStringLabels, test_job7.ToString());
        }

        [TestMethod]
        public void TestToStringFieldsEmpty()
        {
            Job test_job8 = new Job("", new Employer(""), new Location(""), new PositionType(""), new CoreCompetency(""));
            string testEmptyFields = $"\nID: {test_job8.Id}\nName: Data not available\nEmployer: Data not available\nLocation: Data not available\nPosition Type: Data not available\nCore Competency: Data not available\n";
            Assert.AreEqual(testEmptyFields, test_job8.ToString());
        }

        [TestMethod]
        public void TestToStringOnlyId()
        {
            Job test_job9 = new Job();
            string testOnlyId = "OOPS! This job does not seem to exist.";
            Assert.AreEqual(testOnlyId, test_job9.ToString());
        }
    }
}