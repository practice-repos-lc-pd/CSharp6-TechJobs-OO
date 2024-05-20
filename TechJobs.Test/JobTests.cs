namespace TechJobs.Tests
{
    [TestClass]
    public class JobTests
    {
        //Testing Objects
        //initalize your testing objects here
        Job job1;
        Job job2;
        Job job3;
        Job job4;
        Job job5;
        string newLine = Environment.NewLine;

        [TestInitialize]
        public void InitializeTests()
        {
            job1 = new();
            job2 = new();
            job3 = new(
                "Product tester",
                new Employer("ACME"),
                new Location("Desert"),
                new PositionType("Quality Control"),
                new CoreCompetency("Persistence")
            );
            job4 = new(
                "Product Tester",
                new Employer("ACME"),
                new Location("Desert"),
                new PositionType("Quality Control"),
                new CoreCompetency("Persistence")
            );
            job5 = new(
                "Job with null values",
                new Employer(""),
                new Location(null),
                new PositionType(null),
                new CoreCompetency("")
            );
        }

        [TestMethod]
        public void TestSettingJobId()
        {
            IsFalse(job1.Id == job2.Id);
        }

        [TestMethod]
        public void TestJobConstructorSetsAllFields()
        {
            AreEqual(job3.Name, "Product tester");
            AreEqual(job3.EmployerName.ToString(), "ACME");
            AreEqual(job3.EmployerLocation.ToString(), "Desert");
            AreEqual(job3.JobType.ToString(), "Quality Control");
            AreEqual(job3.JobCoreCompetency.ToString(), "Persistence");
        }

        [TestMethod]
        public void TestJobsForEquality()
        {
            AreNotEqual(job3, job4);
        }

        [TestMethod]
        public void TestToStringStartsAndEndsWithNewLine()
        {
            IsTrue(job3.ToString().StartsWith(Environment.NewLine));
            IsTrue(job3.ToString().EndsWith(Environment.NewLine));
        }

        [TestMethod]
        public void TestToStringContainsCorrectLabelsAndData()
        {
            string expected =
                newLine
                + $"ID: {job3.Id}"
                + newLine
                + $"Name: Product tester"
                + newLine
                + $"Employer: ACME"
                + newLine
                + $"Location: Desert"
                + newLine
                + $"Position Type: Quality Control"
                + newLine
                + $"Core Competency: Persistence"
                + newLine;

            AreEqual(expected, job3.ToString());
        }

        [TestMethod]
        public void TestToStringHandlesEmptyField()
        {
            string expected =
                newLine
                + $"ID: {job5.Id}"
                + newLine
                + $"Name: Job with null values"
                + newLine
                + $"Employer: Data not available"
                + newLine
                + $"Location: Data not available"
                + newLine
                + $"Position Type: Data not available"
                + newLine
                + $"Core Competency: Data not available"
                + newLine;
        }
    }
}
