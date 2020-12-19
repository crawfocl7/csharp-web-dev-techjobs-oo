using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechJobsOO;

namespace TechJobTests
{
    [TestClass]
    public class JobTests
    {
        [TestMethod]
        public void TestSettingJobId()
        {
            Job test_jobOne = new Job();
            Job test_jobTwo = new Job();
            int differByOne = test_jobTwo.Id - test_jobOne.Id;
            //Test that job object id's are not the same.
            Assert.IsFalse(test_jobOne.Id == test_jobTwo.Id);

            //Test that job object id's are different by 1.
            Assert.AreEqual(1, differByOne, .001);

        }
    }
}




//Job test_jobOne = new TechJobsOO.Job("Santa's Assistant", new TechJobsOO.Employer("Santa Clause"), new TechJobsOO.Location("North Pole"), new TechJobsOO.PositionType("Elf"), new TechJobsOO.CoreCompetency("On the Good List"));
//Job test_jobTwo = new TechJobsOO.Job("Reindeer Attendant", new TechJobsOO.Employer("Santa Clause"), new TechJobsOO.Location("North Pole"), new TechJobsOO.PositionType("Reindeer Support"), new TechJobsOO.CoreCompetency("Veterinarian"));