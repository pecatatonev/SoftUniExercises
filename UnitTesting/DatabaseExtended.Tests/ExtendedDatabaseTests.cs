namespace DatabaseExtended.Tests
{
    using ExtendedDatabase;
    using NUnit.Framework;
    using System;

    [TestFixture]
    public class ExtendedDatabaseTests
    {
        private Database defDb;
        private Person person1;
        private Person person2;
        private Person person3;
        private Person[] people;
        [SetUp]
        public void SetUp()
        {
            this.defDb = new Database();
            person1 = new Person(0500710056, "Dimitrichko");
            person2 = new Person(0500710054, "Goshko");
            person3 = new Person(0500710055, "Pesho");
            this.people = new Person[] { person1, person2 };
        }

        [Test]
        public void PersonClassConstructorShouldSetAndGetValue()
        {
            long id = 05007100056;
            string username = "test";
            Person person = new Person(05007100056, "test");

            Assert.AreEqual(id, person.Id);
            Assert.AreEqual(username, person.UserName);
        }

        [Test]
        public void ConstructorShouldIntializeDataWithCorrectCount()
        {
            Database db = new Database(people);
            int expectedCount = people.Length;
            int actualCount = db.Count;
            Assert.AreEqual(expectedCount, actualCount);
        }

        [Test]
        public void DatabaseClassShouldInitializeTheConstructor()
        {
            Database database = new Database(people);
            // I assume count field work
            int expectedCount = people.Length;
            int actualCount = database.Count;

            Assert.AreEqual(expectedCount, actualCount);
        }

        [Test]
        public void CheckAddRangeMethodThrowExceptionAboutDataLenght()
        {
            Person[] people = new Person[] { person1, person2, person3 };
        }
    }
}