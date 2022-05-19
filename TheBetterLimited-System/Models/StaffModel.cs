namespace TheBetterLimited.Models
{
    public class StaffModel
    {
        private string firstName;
        private string lastName;
        private string email;
        private string age;
        private string phone;
        private string sex;

        public StaffModel(string firstName, string lastName, string email, string age, string phone, string sex)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.email = email;
            this.age = age;
            this.phone = phone;
            this.sex = sex;
        }

        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string Email { get => email; set => email = value; }
        public string Age { get => age; set => age = value; }
        public string Phone { get => phone; set => phone = value; }
        public string Sex { get => sex; set => sex = value; }
    }
}
