namespace HelloWorld.Model
{
    public class Person
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public Person(string name, string lastname)
        {
            Firstname = name;
            Lastname = lastname;
        }
    }
}
