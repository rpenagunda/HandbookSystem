using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
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
                    return db.People.Include("Modules").Single(x => x.UserName == HttpContext.Current.User.Identity.Name);
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
                                        Enabled = x.Enabled.ToString(),
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
                    module.Enabled = mi.Enabled == "True";
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

        // Method to return all modules that were enabled
        public static List<ModuleInfo> AllModules()
        {
            try
            {
                using (var db = new AppDbEntities())
                {
                    // Return module info for the given module code
                    return
                        db.Modules.Where(x => x.Enabled).Select(
                                x =>
                                    new ModuleInfo
                                    {
                                        ModuleCode = x.ModuleCode,
                                        ModuleTitle = x.ModuleTitle,
                                        Enabled = x.Enabled.ToString(),
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
                                    }).ToList();
                }
            }
            catch
            {
                // Error message
                throw new Exception();
            }
        }

        // Get roles for the specific user
        public static string[] GetRoles(string username)
        {
            try
            {
                using (var db = new AppDbEntities())
                {
                    // Return role(s) for given username
                    return
                        db.People.Where(x => x.UserName == username).Select(x => new[] { x.Role }).Single();
                }
            }
            catch
            {
                // Error message
                throw new Exception();
            }
        }

        // Get roles for the specific user
        public static string GetRole(string username)
        {
            try
            {
                using (var db = new AppDbEntities())
                {
                    // Return role for given username
                    return
                        db.People.Where(x => x.UserName == username).Select(x => x.Role).Single();
                }
            }
            catch
            {
                // Error message
                throw new Exception();
            }
        }

        // Check if the username and password match
        public static bool IsLoginValid(LoginModel login)
        {
            try
            {
                using (var db = new AppDbEntities())
                {
                    // Check if the username and password combination exist in the database
                    var result = db.People.Where(x => x.UserName == login.UserName && x.Password == login.Password);

                    if (result.Count() == 1)
                    {
                        return true;
                    }
                }

                return false;
            }
            catch
            {
                // Error message
                throw new Exception();
            }
        }
    }
}