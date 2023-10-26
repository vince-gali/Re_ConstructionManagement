using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProjectsController : ControllerBase
    {
        private readonly ProjectsService _projectsService;
        private readonly Auth0Provider _auth;

        public ProjectsController(ProjectsService projectsService, Auth0Provider auth)
        {
            _projectsService = projectsService;
            _auth = auth;
        }

        public async Task<ActionResult<Project>> CreateProject ([FromBody] Project projectData)
        {
            try
            {
                Account userInfo = await _auth.GetUserInfoAsync<Account>(HttpContext);
                projectData.CreatorId = userInfo.Id;
                Project project = _projectsService.CreateProject(projectData);
                return Ok(project);
            }
            catch (Exception e)
            {
                
                return new ActionResult<Project>(BadRequest(e.Message));
            }
        }

    }
}