using advProj_BusinessObjects;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace advProj_WebProjectManager.ViewModels
{
    public class NewTaskModelView
    {
        public AdvProjTask? projectTask { get; set; }
        public IEnumerable<AdvProjUser>? Users { get; set; }
        public string[]? selectIdArray { get; set; }
    }
}
