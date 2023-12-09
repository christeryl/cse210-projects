public class Comment
{
    // Properties
    public string CommenterName { get; private set; }
    public string CommentText { get; private set; }

    // Constructor
    public Comment(string commenterName, string commentText)
    {
        CommenterName = commenterName;
        CommentText = commentText;
    }
}
