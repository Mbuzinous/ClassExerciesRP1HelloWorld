using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using HelloWorld.Model;

namespace HelloWorld.Pages
{
    public class PersonModel : PageModel
    {
        List<Person> people = new List<Person>();
        public PersonModel()
        {
            Person p1 = new Person("Lone", "Andersen");
            Person p2 = new Person("Lotte", "Anderson");
            Person p3 = new Person("Jens", "Hansen");
            Person p4 = new Person("Børge", "Jensen");

            People.Add(p1);
            People.Add(p2);
            People.Add(p3);
            People.Add(p4);
        }

        public List<Person> People { get => people; set => people = value; }

        public void OnGet()
        {
        }
    }
}
