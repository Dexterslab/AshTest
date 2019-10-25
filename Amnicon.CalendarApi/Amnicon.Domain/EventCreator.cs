namespace Amnicon.Domain
{
    public class EventCreator
    {
        // primary key id
        public int Id { get; set; }

        public string Email { get; set; }

        public string DisplayName { get; set; } // name to show on the UI
    }
}