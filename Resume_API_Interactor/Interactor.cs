using resume_MODELS.API;
using resume_MODELS.DTO;
using resume_REPOSITORY;

namespace Resume_API_Interactor
{
    public class Interactor
    {
        private Repository _db;
        public Interactor()
        {
            _db = new Repository();
        }
        public bool AddResumeToDb(Root root)
        {
            Root_DTO dto = Root.GetDTOFromAPI(root);
            if(dto == null)
            {
                return false;
            }
            _db.AddResumeToDb(dto);
            return true;
        }
        public Root GetResumeFromDb()
        {
            return _db.GetResumeFromDb();
        }
    }
}