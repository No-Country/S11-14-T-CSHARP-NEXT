namespace S11.Common.Enums
{
    public static class IssueType
    {
        public static string Done { get; } = nameof(Done);
        public static string ToDo { get;  }=nameof(ToDo);
        public static string Cancelled { get; } = nameof(Cancelled);
        public static string InProgress { get; } = nameof(InProgress);
    }
}
