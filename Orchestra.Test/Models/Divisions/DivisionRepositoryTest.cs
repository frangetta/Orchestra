using System.Linq;
using NUnit.Framework;
using Orchestra.DataLayer;
using Orchestra.Site.Models.Divisions;
using Orchestra.Test.Utilities;
using Rhino.Mocks;

namespace Orchestra.Test.Models.Divisions
{
    public class DivisionRepositoryTest : MockingTest
    {
        [Test]
        public void TestGetMenuDivisionsFiltering()
        {
            var divisions = new []
            {
                new Division {DivisionId = 1, ShowMenu = true, Publish = true},
                new Division {DivisionId = 2, ShowMenu = false, Publish = true},
                new Division {DivisionId = 3, ShowMenu = true, Publish = false}
            }.AsQueryable();

            var context = Mock<IDatabaseContext>(r => r
                .Expect(e => e.GetTable<Division>())
                .Return(divisions));

            ReplayAll();

            var repository = new DivisionRepository(context);
            var actual = repository.GetMenuDivisions();

            VerifyAll();

            CollectionAssert.AreEqual(new [] {1}, actual.Select(e => e.DivisionId).ToArray());
        }

        [Test]
        public void TestGetMenuDivisionsOrdering()
        {
            var divisions = new[]
            {
                new Division {DivisionId = 1, ShowMenu = true, Publish = true, Priority = 2},
                new Division {DivisionId = 2, ShowMenu = true, Publish = true, Priority = 1},
                new Division {DivisionId = 3, ShowMenu = true, Publish = true, Priority = 0}
            }.AsQueryable();

            var context = Mock<IDatabaseContext>(r => r
                .Expect(e => e.GetTable<Division>())
                .Return(divisions));

            ReplayAll();

            var repository = new DivisionRepository(context);
            var actual = repository.GetMenuDivisions();

            VerifyAll();

            CollectionAssert.AreEqual(new[] { 3, 2, 1 }, actual.Select(e => e.DivisionId).ToArray());
        }
    }
}