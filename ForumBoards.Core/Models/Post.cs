using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForumBoards.Core.Models
{
    public class Post
    {
        public int Id { get; set; }
        public string MessageTextRaw { get; set; }
        public int UserId { get; set; }
    }
}
