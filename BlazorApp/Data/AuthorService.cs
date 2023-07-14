using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Threading.Tasks;

namespace BlazorApp.Data
{
    public class AuthorService :IAuthorService
    {
   

        public IList<Author>? authors;
        public DateTime CreationTime { get; set; }  




        public void Seed()
        {
            authors = new List<Author>();

            authors.Add(new Author(1,"mohamed","fatehi","@gmail", 5555,"06674","casa"));
            authors.Add(new Author(2, "mohamed2", "fatehi2" , "@gmail", 5555888, "06674", "casa"));

        }

        public IList<Author>? GetAuthors()
        {
            return authors; 
        }

        public Author? GetAuthorById(int Id)
        {

            authors ??= new List<Author>();

           
            return authors.Where(x => x.AuthorId == Id).FirstOrDefault();
            
        }
        public DateTime GetCreationTime()
        {
            return CreationTime;    
        }
        public void SaveAuthor(Author author)
        {
            authors.Add(author);
        }
    }
}