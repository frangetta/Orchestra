using NUnit.Framework;
using Orchestra.DataLayer;
using Orchestra.Site.Models.Divisions;
using Orchestra.Site.Models.Utilities;
using Orchestra.Test.Utilities;
using Rhino.Mocks;

namespace Orchestra.Test.Models.Divisions
{
    public class DivisionValidatorTest : MockingTest
    {
        [Test]
        public void TestValidate_WhenDivisionExists_ShouldReturnIt()
        {
            const string path = "path";
            var division = new Division();

            var divisionRepository = Mock<IDivisionRepository>(r => r
                .Expect(e => e.FindDivisionByPath(path))
                .Return(division));

            ReplayAll();

            var validator = new DivisionValidator(divisionRepository);
            var actual = validator.Validate(path);

            VerifyAll();

            Assert.AreSame(division, actual);
        }

        [Test]
        public void TestValidate_WhenNoDivision_ShouldThrowResourceNotFound()
        {
            const string path = "path";

            var divisionRepository = Mock<IDivisionRepository>(r => r
                .Expect(e => e.FindDivisionByPath(path))
                .Return(null));

            ReplayAll();

            var validator = new DivisionValidator(divisionRepository);
            Assert.Throws<ResourceNotFoundException>(() => validator.Validate(path));

            VerifyAll();
        }
    }
}