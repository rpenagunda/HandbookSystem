using System;
using System.Linq;
using HandbookSystem.Dal;
using HandbookSystem.Models;

namespace HandbookSystem.Helper
{
    public static class Query
    {
        // Comment
        public static Person PersonInfo()
        {
            try
            {
                using (var db = new AppDbEntities())
                {
                    // Return person info for the given ID
                    return db.People.Include("Modules").Single(x => x.UserName == Extensions.Username);
                }
            }
            catch
            {
                // Error message
                throw new Exception();
            }
        }

        // Comment
        public static ModuleInfo ModuleInfo(int moduleCode)
        {
            try
            {
                using (var db = new AppDbEntities())
                {
                    // Return module info for the given module code
                    return
                        db.Modules.Where(x => x.ModuleCode == moduleCode)
                            .Select(
                                x =>
                                    new ModuleInfo
                                    {
                                        ModuleCode = x.ModuleCode,
                                        ModuleTitle = x.ModuleTitle,
                                        Department = x.Department,
                                        Credits = x.Credits,
                                        Coursework = x.Coursework,
                                        VleBlackboard = x.VleBlackboard,
                                        ModuleRoom = x.ModuleRoom,
                                        ModuleLeader = x.ModuleLeader,
                                        ModuleLeaderEmail = x.ModuleLeaderEmail,
                                        Advice = x.Advice,
                                        ModuleLeaderPhone = x.ModuleLeaderPhone,
                                        AdministratorPhone = x.AdministratorPhone,
                                        Assessment = x.Assessment,
                                        ReadingList = x.ReadingList,
                                        ModuleOverview = x.ModuleOverview,
                                        LearningOutcomes = x.LearningOutcomes,
                                        InclusiveServices = x.InclusiveServices,
                                        OutlineContent = x.OutlineContent,
                                        OtherInfo = x.OtherInfo
                                    })
                            .Single();
                }
            }
            catch
            {
                // Error message
                throw new Exception();
            }
        }

        // Comment
        public static void EditHandbook(ModuleInfo mi)
        {
            try
            {
                using (var db = new AppDbEntities())
                {
                    // Find the module
                    var module = db.Modules.Find(mi.ModuleCode);

                    // Map the data/fields
                    module.ModuleLeader = mi.ModuleLeader;
                    module.ModuleLeaderEmail = mi.ModuleLeaderEmail;
                    module.AdministratorPhone = mi.AdministratorPhone;
                    module.Advice = mi.Advice;
                    module.Assessment = mi.Assessment;
                    module.Coursework = mi.Coursework;
                    module.Credits = mi.Credits;
                    module.Department = mi.Department;
                    module.InclusiveServices = mi.InclusiveServices;
                    module.LearningOutcomes = mi.LearningOutcomes;
                    module.ModuleLeaderPhone = mi.ModuleLeaderPhone;
                    module.ModuleOverview = mi.ModuleOverview;
                    module.ModuleRoom = mi.ModuleRoom;
                    module.VleBlackboard = mi.VleBlackboard;
                    module.ReadingList = mi.ReadingList;
                    module.OutlineContent = mi.OutlineContent;
                    module.OtherInfo = mi.OtherInfo;

                    // Save changes
                    db.SaveChanges();
                }
            }
            catch
            {
                // Error message
                throw new Exception();
            }
        }
    }
}