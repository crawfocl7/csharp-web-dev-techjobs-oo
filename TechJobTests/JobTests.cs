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
            Assert.AreEqual(1, differBy1, .001);

        }

        public void TestJobConstructorSetsAllFields()
        {
            Job test_job3 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            Assert.AreEqual("Product tester", test_job3.EmployerName);
            //Assert.IsFalse( );
        //    Assert.AreEqual("ACME", test_job1.EmployerName);
        //    Assert.AreEqual("Desert", test_job1.Name);
        //    Assert.AreEqual("Product tester", test_job1.Name);
        //    Assert.AreEqual("Product tester", test_job1.Name);
        }
    }
}
