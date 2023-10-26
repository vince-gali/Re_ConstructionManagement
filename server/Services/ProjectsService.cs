namespace Re_ConstructionManagement.Services
{
     public class ProjectsService 
    {
        private readonly ProjectsRepo _repo;
        
        public ProjectsService (ProjectsRepo repo)
        {
            _repo = repo;
        }

        //STUB - methods below


        internal Project CreateProject(Project projectData)
        {
            Project project = _repo.CreateProject(projectData);
            return project;
        }


    }
}