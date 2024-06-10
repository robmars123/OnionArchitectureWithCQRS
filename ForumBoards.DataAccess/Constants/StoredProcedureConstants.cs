using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForumBoards.DataAccess.Constants
{
    public static class StoredProcedureConstants
    {
        public const string GetPosts = "GetPosts";

        public static class Parameters
        {
            public const string Id = "Id";
        }
    }
}
