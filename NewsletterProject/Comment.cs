using System;
namespace NewsletterProject
{
    public class Comment
    {
        public Comment()
        {
        }
        public int Id { get; set; }
        public int NewsId { get; set; }
        public int UserId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Subject { get; set; }
        public string Content { get; set; }
        public bool Status { get; set; }
    }
}
