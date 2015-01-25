using NUnit.Framework;
using Orchestra.DataLayer;
using Orchestra.Site.Models.Divisions;
using Orchestra.Site.Models.Layout;
using Orchestra.Test.Utilities;
using Rhino.Mocks;

namespace Orchestra.Test.Models.Divisions
{
    public class DivisionViewModelBuilderTest : MockingTest
    {
        [Test]
        public void TestBuild()
        {
            const string path = "path";
            var division = new Division();
            var layoutModel = new LayoutModel(new Division[0]);

            var divisionValidator = Mock<IDivisionValidator>(r => r
                .Expect(e => e.Validate(path))
                .Return(division));

            var layoutModelBuilder = Mock<ILayoutModelBuilder>(r => r
                .Expect(e => e.Build())
                .Return(layoutModel));

            ReplayAll();

            var builder = new DivisionViewModelBuilder(divisionValidator, layoutModelBuilder);
            var actual = builder.Build(path);

            VerifyAll();

            Assert.AreSame(division, actual.Division);
            Assert.AreSame(layoutModel, actual.LayoutModel);

        }
    }
}