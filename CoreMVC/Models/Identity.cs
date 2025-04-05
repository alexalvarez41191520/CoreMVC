namespace CoreMVC.Models
{
    public class Identity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public String Active { get; set; }
        public string Term { get; set; }
        public string Group { get; set; }
        public string Role { get; set; }
        public Identity(int id, string Name, String Active, String Term, String Group, String Role)
        {
            this.Id = id;
            this.Name = Name;
            this.Active = Active;
            this.Term = Term;
            this.Group = Group;
            this.Role = Role;
        }
    }

    public class Years
    {
        public int StartYear { get; set; }
        public int EndYear { get; set; }
    }
}
