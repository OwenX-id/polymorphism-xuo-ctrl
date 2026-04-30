namespace PeopleLib
{
    /// <summary>
    /// Represents a teacher
    /// </summary>
    public class Teacher : Person
    {
        public string Subject { get; set; }

        public Teacher(string first, string last, DateTime dob, string subject)
            : base(first, last, dob)
        {
            Subject = subject;
        }

        public Teacher() { }

        /// <summary>
        /// Override screen name
        /// </summary>
        public override string GetScreenName()
        {
            return $"staff_{LastName.ToLower()}_{Subject.ToLower()}";
        }

        /// <summary>
        /// NEW method (to test behaviour)
        /// </summary>
        public new string GetFullName()
        {
            return $"Teacher: {FirstName} {LastName}";
        }
    }
}