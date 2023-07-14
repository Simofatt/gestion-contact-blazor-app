using System.ComponentModel.DataAnnotations;

namespace BlazorApp.Data
{
    public class Publisher
    {

        public int Id { get; set; }
        [MaxLength(30,ErrorMessage ="The max lenght is 30 chara!")]
        public string? FullName { get; set; }
        [MaxLength(30, ErrorMessage = "The max lenght is 30 chara!")]
        public string? City { get; set; }


        public Publisher(int id , string fullName,string city) 
        {
             Id = id;
            FullName = fullName;
            City = city;
        }
        public Publisher() { }
    }

}
