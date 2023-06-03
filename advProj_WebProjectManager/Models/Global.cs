using advProj_BusinessObjects;

namespace advProj_WebProjectManager.Models
{
    public static class Global
    {
        
        public static int? userID { get; set; }
        public static string? userAspID { get; set; }

        public static void setNormalId(string aspID)
        {
            AdvProg_DatabaseContext databaseContext = new AdvProg_DatabaseContext();
            userAspID = aspID;
            var user = databaseContext.AdvProjUsers.Where(a => a.AspUserId == aspID).FirstOrDefault();
            userID = user.UserId;
        }
    }
}
