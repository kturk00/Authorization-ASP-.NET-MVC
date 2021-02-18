using ProjectCRUD.Models;
using System;
using System.Linq;
using Microsoft.AspNetCore.Identity;


namespace ProjectCRUD.Data
{
    public static class DbInitializer
    {

        public static void Initialize(LibraryContex context)
        {
            

            context.Database.EnsureCreated();

            // Look for any students.
            if (context.Authors.Any())
            {
                return;   // DB has been seeded
            }

            var authors = new Author[]
            {
            new Author{FirstName="Adam",LastName="Mickiewicz",Code="MI2435"},
            new Author{FirstName="Henryk",LastName="Sienkiewicz",Code="SI1578"},
            new Author{FirstName="Juliusz",LastName="Słowacki",Code="SŁ4525"},
            new Author{FirstName="Władysław",LastName="Reymont",Code="RE1298"},
            new Author{FirstName="Yan",LastName="Li",Code="LI2435"},
            new Author{FirstName="Peggy",LastName="Justice",Code="JU2214"},
            new Author{FirstName="Laura",LastName="Norman",Code="NO8891"},
            };
            foreach (Author a in authors)
            {
                context.Authors.Add(a);
            }
            context.SaveChanges();

      

            var books = new Book[]
            {
            new Book{AuthorID=2,Title="Quo Vadis",ReleaseDate=DateTime.Parse("1896-03-26")},
            new Book{AuthorID=1,Title="Dziady",ReleaseDate=DateTime.Parse("1822-01-01")},
            new Book{AuthorID=2,Title="Krzyżacy",ReleaseDate=DateTime.Parse("1897-02-03")},
            new Book{AuthorID=4,Title="Chłopi",ReleaseDate=DateTime.Parse("1902-09-22")},
            new Book{AuthorID=4,Title="Ziemia obiecana",ReleaseDate=DateTime.Parse("1897-04-11")},
            new Book{AuthorID=3,Title="Koridan",ReleaseDate=DateTime.Parse("1834-03-12")},
            };
            foreach (Book b in books)
            {
                context.Books.Add(b);
            }
            context.SaveChanges();

            
      
        }
    }
}