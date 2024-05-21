using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForumBoards.Core.Results
{
    public class PostRequestResult
    {
        public PostRequestResult(int? id, int? userId, string? messageTextRaw)
        {
            Id = id;
            UserId = userId;
            MessageTextRaw = messageTextRaw;
        }
        public int? Id { get; set; }
        public string? MessageTextRaw { get; set; }
        public int? UserId { get; set; }
    }
}
