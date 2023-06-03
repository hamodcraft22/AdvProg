using advProj_BusinessObjects;

namespace advProj_WebProjectManager.ViewModels
{
    // a model view class for the project's page, also used to incorpriate searching. 
    public class ProjectTasksViewModel
    {
        // variables to hold the objects passed to the view
        public AdvProjProject? Project { get; set; }
        public IEnumerable<AdvProjTask>? projTasks { get; set; }
        public IEnumerable<AdvProjPStatus>? Status { get; set; }

        // varaibles to hold the sreach items 
        public string? TaskName { get; set; }
        public int? StatusInput { get; set; }
    }
}
