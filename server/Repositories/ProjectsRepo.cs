namespace Re_ConstructionManagement.Repositories
{

        public class ProjectsRepo 
    {
        private readonly IDbConnection _db;

        public ProjectsRepo(IDbConnection db)
        {
            _db = db;
        }


//STUB - Methods below
        internal Project CreateProject(Project projectData)
        {
            throw new NotImplementedException();
        }


    }
}