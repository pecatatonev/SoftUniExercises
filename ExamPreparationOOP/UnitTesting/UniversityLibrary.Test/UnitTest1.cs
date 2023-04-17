namespace UniversityLibrary.Test
{
    using Microsoft.VisualStudio.TestPlatform.ObjectModel.Client;
    using NUnit.Framework;
    using System;

    public class Tests
    {
        private TextBook textBook;
        private string title = "1984";
        private string author = "George Orwell";
        private string category = "Disthopy";


        private UniversityLibrary lib;
        [SetUp]
        public void Setup()
        {
            textBook = new TextBook(title, author, category);
            lib = new UniversityLibrary();
        }

        [Test]
        public void TestTextbook_SetsValuesCorrectly()
        {
            textBook.Category = "1";
            textBook.Author = "2";
            textBook.Title = "3";
            textBook.InventoryNumber = 4;
            textBook.Holder = "5";
            Assert.AreEqual(textBook.Category, "1");
            Assert.AreEqual(textBook.Author, "2");
            Assert.AreEqual(textBook.Title,"3");
            Assert.AreEqual(textBook.InventoryNumber,4);
            Assert.AreEqual(textBook.Holder,"5");

            Assert.AreEqual(textBook.ToString(), $"Book: 3 - 4{Environment.NewLine}Category: 1{Environment.NewLine}Author: 2".TrimEnd());
        }

        [Test]
        public void TestTextbookConstructor_SetsValuesCorrectly()
        {
            Assert.AreEqual(textBook.Category, category);
            Assert.AreEqual(textBook.Author, author);
            Assert.AreEqual(textBook.Title, title);

            Assert.AreEqual(textBook.ToString(), $"Book: 1984 - 0{Environment.NewLine}Category: Disthopy{Environment.NewLine}Author: George Orwell".TrimEnd());

            Assert.AreEqual(textBook.Holder, null);
        }

        [Test]
        public void UniLibraryIsEmptyWhenNEw()
        {
            Assert.AreEqual(lib.Catalogue.Count, 0);
        }


        [Test]
        public void ReturnAndLoanThrowErrorWhenTextBookNotFound()
        {
            Assert.Throws<System.NullReferenceException>(() =>
            {
                lib.LoanTextBook(55, "test");
            }
            );

            Assert.Throws<System.NullReferenceException>(() =>
            {
                lib.ReturnTextBook(55);
            }
            );
        }

            [Test]
        public void AddManyTextbookWorksCorrectly()
        {
            for (int i = 0; i < 10; i++)
            {
                lib.AddTextBookToLibrary(textBook);
            }
            string result = lib.AddTextBookToLibrary(textBook);
            Assert.AreEqual(textBook.InventoryNumber, 11);
        }

            [Test]
        public void AddTextbookWorksCorrectly()
        {
            string result = lib.AddTextBookToLibrary(textBook);
            Assert.AreEqual(textBook.InventoryNumber, 1);
            Assert.AreEqual(lib.Catalogue.Count, 1);
            Assert.AreEqual(lib.Catalogue[0].Title, title);

            Assert.AreEqual(result, $"Book: 1984 - 1{Environment.NewLine}Category: Disthopy{Environment.NewLine}Author: George Orwell".TrimEnd());
        }

        [Test]
        public void LoanTextbookTests()
        {
            lib.AddTextBookToLibrary(textBook);
            Assert.AreEqual(textBook.Holder, null);

            string result = lib.LoanTextBook(1, "Dimitrichko");

            Assert.AreEqual(textBook.Holder, "Dimitrichko");
            Assert.AreEqual(result, $"{title} loaned to Dimitrichko.");

            result = lib.LoanTextBook(1, "Dimitrichko");
            Assert.AreEqual(result, $"Dimitrichko still hasn't returned {textBook.Title}!");
        }

        [Test]
        public void ReturnTextbookTests()
        {
            lib.AddTextBookToLibrary(textBook);
            string result = lib.LoanTextBook(1, "Dimitrichko");

            result = lib.ReturnTextBook(1);

            Assert.AreEqual("", textBook.Holder);
            Assert.AreEqual($"{textBook.Title} is returned to the library.", result);
        }
    }
}