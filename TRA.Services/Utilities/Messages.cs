﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRA.Services.Utilities
{
    public class Messages
    {
        public static class Category
        {
            public static string NotFound(bool isPlural)
            {
                if (isPlural)
                {
                    return "Couldn't find any category.";
                }
                return "Couldn't find this category.";
            }

            public static string OperationError(string categoryName)
            {
                return $"There has been an error while adding {categoryName} named category.";
            }

            public static string Add(string categoryName)
            {
                return $"{categoryName} named category has been added.";
            }

            public static string Update(string categoryName)
            {
                return $"{categoryName} named category has been updated.";
            }

            public static string Delete(string categoryName)
            {
                return $"{categoryName} named category has been successfully deleted.";
            }

            public static string HardDelete(string categoryName)
            {
                return $"{categoryName} named category has been successfully deleted from the database.";
            }

            public static string UndoDelete(string categoryName)
            {
                return $"{categoryName} named category has been successfully retrieved from the archive.";
            }

        }

        public static class Post
        {
            public static string NotFound(bool isPlural)
            {
                if (isPlural)
                {
                    return "Couldn't find the Posts.";
                }
                return "Couldn't find this post.";
            }

            public static string OperationError(string PostTitle)
            {
                return $"There has been an error while adding {PostTitle} named post.";
            }

            public static string Add(string PostTitle)
            {
                return $"{PostTitle} titled post added successfully.";
            }

            public static string Update(string PostTitle)
            {
                return $"{PostTitle} titled post updated successfully.";
            }

            public static string Delete(string PostTitle)
            {
                return $"{PostTitle} titled post deleted successfully.";
            }

            public static string HardDelete(string PostTitle)
            {
                return $"{PostTitle} titled post deleted from the database successfully.";
            }

            public static string UndoDelete(string PostTitle)
            {
                return $"{PostTitle} titled post has been retrieved from the archive successfully.";
            }

            public static string IncreaseViewCount(string postTitle)
            {
                return $"{postTitle} titled post's view count has been increased.";
            }

        }

        public static class Comment
        {
            public static string NotFound(bool isPlural)
            {
                if (isPlural)
                {
                    return "Couldn't find any comments.";
                }
                return "Couldn't find this comment.";
            }

            public static string OperationError()
            {
                return "There has been an error while adding your comment.";
            }

            public static string Approve(int commentId)
            {
                return $"comment with {commentId} id added successfully.";
            }

            public static string Add(string createdByName)
            {
                return $"Dear {createdByName}, your comment has added succesfully.";
            }

            public static string Update(string createdByName)
            {
                return $"Comment added by {createdByName} has been updated successfully.";
            }

            public static string Delete(string createdByName)
            {
                return $"Comment added by {createdByName} has been deleted successfully.";
            }

            public static string HardDelete(string createdByName)
            {
                return $"Comment added by {createdByName} has been deleted from the database succesfully.";
            }

            public static string UndoDelete(string createdByName)
            {
                return $"Comment added by {createdByName} has been retrieved from the archive successfully.";
            }
        }
    }
}

