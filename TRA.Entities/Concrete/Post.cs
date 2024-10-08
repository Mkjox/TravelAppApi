﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using TRA.Shared.Entities.Abstract;

namespace TRA.Entities.Concrete
{
    public class Post : EntityBase, IEntity
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public string Location {  get; set; }
        public string Thumbnail { get; set; }
        public int Balance { get; set; }
        public int Rating { get; set; }
        public int Duration { get; set; }
        public DateTime Date { get; set; }
        public int ViewCount { get; set; } = 0;
        public int CommentCount { get; set; } = 0;
        public int CategoryId { get; set; }
        public Category? Category { get; set; }
        public int UserId { get; set; }
        [JsonIgnore]
        public User User { get; set; }
        public ICollection<Comment> Comments { get; set; }
        public bool IsPinned { get; set; } = false;

        public ICollection<Like> Likes { get; set; }
    }
}
