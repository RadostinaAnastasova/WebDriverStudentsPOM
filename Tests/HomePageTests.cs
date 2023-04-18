﻿using NUnit.Framework;
using WebDriverStudentsPOM.Pages;

namespace WebDriverStudentsPOM.Tests
{
    public class HomePageTests : BaseTest
    {
        private HomePage page;

        [SetUp]
        public void Setup() 
        {
            this.page = new HomePage(driver);
        }

        [Test]
        public void Test_HomePage_CheckTitle()
        {
            page.Open();
            Assert.That(page.GetPageTitle(), Is.EqualTo("MVC Example"));
        }
    }
}
