namespace ResumeApp.Models
{
    public class CommitsResult
    {
        public required string Sha { get; set; }
        public string? NodeId { get; set; }
        public required CommitDetails Commit { get; set; }
        public required string Url { get; set; }
        public string? HtmlUrl { get; set; }
        public string? CommentsUrl { get; set; }
        public required Author Author { get; set; }
        public required Author Committer { get; set; }
        public Parent[]? Parents { get; set; }
    }

    public class Author
    {
        public required string Login { get; set; }
        public required ulong? Id { get; set; }
        public string? NodeId { get; set; }
        public string? AvatarUrl { get; set; }
        public string? GravatarId { get; set; }
        public required string Url { get; set; }
        public string? HtmlUrl { get; set; }
        public string? FollowersUrl { get; set; }
        public string? FollowingUrl { get; set; }
        public string? GistsUrl { get; set; }
        public string? StarredUrl { get; set; }
        public string? SubscriptionsUrl { get; set; }
        public string? OrganizationsUrl { get; set; }
        public string? ReposUrl { get; set; }
        public string? EventsUrl { get; set; }
        public string? ReceivedEventsUrl { get; set; }
        public required string Type { get; set; }
        public bool? SiteAdmin { get; set; }
    }

    public class Parent
    {
        public required string Sha { get; set; }
        public required string Url { get; set; }
        public string? HtmlUrl { get; set; }
    }

    public class CommitDetails
    {
        public required CommitAuthor Author { get; set; }
        public required CommitAuthor Committer { get; set; }
        public required string Message { get; set; }
        public required Tree Tree { get; set; }
        public required string Url { get; set; }
        public int? CommentCount { get; set; }
        public Verification? Verification { get; set; }
    }

    public class Verification
    {
        public required bool Verified { get; set; }
        public required string Reason { get; set; }
        public required string Signature { get; set; }
        public required string Payload { get; set; }
    }

    public class Tree
    {
        public required string Sha { get; set; }
        public required string Url { get; set; }
    }

    public class CommitAuthor
    {
        public required string Name { get; set; }
        public required string Email { get; set; }
        public required DateTime Date { get; set; }
    }
}
