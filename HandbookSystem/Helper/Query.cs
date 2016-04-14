using System;
using System.Linq;
using HandbookSystem.Dal;

namespace HandbookSystem.Helper
{
    public static class Query
    {
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
    }
}