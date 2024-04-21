namespace APITask.Models
{
    public class User
    {
        public int User_Id { get; set; }
        public string User_Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Full_Name { get; set; }
        public string Number_Phone { get; set; }
        public string? PhotoProfileUrl { get; set; }
        public string Nationlity_Id { get; set; }
        public int Age { get; set; }
        public string Nationality { get; set; }
        public string? Address { get; set; }
        public string UserType { get; set; }
        public bool IsLoggedIn { get; set; }
        public bool IsActive { get; set; }
    }
}
