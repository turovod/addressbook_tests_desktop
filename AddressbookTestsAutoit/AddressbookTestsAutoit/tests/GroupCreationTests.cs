using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace AddressbookTestsAutoit
{
    [TestFixture]
    public class GroupCreationTests : TestBase
    {
        [Test]
        public void GroupCreationTest()
        {
            List<GroupData> oldGroups = app.Groups.GetGroupList();

            GroupData newGroup = new GroupData()
            {
                Name = "Test"
            };

            app.Groups.Add(newGroup);
            oldGroups.Add(newGroup);

            List<GroupData> newGroups = app.Groups.GetGroupList();

            oldGroups.Sort();
            newGroups.Sort();

            Assert.AreEqual(oldGroups, newGroups);

        }
    }
}
