using advProj_BusinessObjects;
namespace advProj_WebProjectManager.ViewModels
{
    // a model view class for the project's page, also used to incorpriate searching. 
    public class ProjectIndexViewModel
    {
        // variables to hold the objects passed to the view
        public IEnumerable<AdvProjProject>? Projects { get; set; }
        public IEnumerable<AdvProjPStatus>? Status { get; set; }
        
        // varaibles to hold the sreach items 
        public string? ProductName { get; set; }
        public int? StatusInput { get; set; }
    }
}
