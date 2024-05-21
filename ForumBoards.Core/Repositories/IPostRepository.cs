﻿using ForumBoards.Core.Models;
using ForumBoards.Core.Results;

namespace ForumBoards.Core.Repositories
{
    public interface IPostRepository
    {
        IEnumerable<PostRequestResult> GetPosts();
    }
}