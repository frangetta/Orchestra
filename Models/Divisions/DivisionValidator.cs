using Orchestra.DataLayer;
using Orchestra.Models.Utilities;

namespace Orchestra.Models.Divisions
{
    public class DivisionValidator : IDivisionValidator
    {
        private readonly IDivisionRepository divisionRepository;

        public DivisionValidator(IDivisionRepository divisionRepository)
        {
            this.divisionRepository = divisionRepository;
        }

        public Division Validate(string path)
        {
            var division = divisionRepository.FindDivisionByPath(path);
            if (division == null)
            {
                throw new ResourceNotFoundException();
            }

            return division;
        }
    }
}