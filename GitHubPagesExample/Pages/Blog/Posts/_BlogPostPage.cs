﻿using Microsoft.AspNetCore.Components;

namespace GitHubPagesExample.Pages.Blog.Posts
{
    public abstract class BlogPostPage : ComponentBase
    {
        public string PostTitle { get; set; }

        public DateTime PostDate { get; set; }
    }
}