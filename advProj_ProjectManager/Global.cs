using advProj_BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace advProj_ProjectManager
{
    internal static class Global
    {
        public static AdvProjUser? loggedUser {  get; set; }
        public static bool isAdmin { get; set; } = false;
    }
}
