using LibraryGUI.Models;
using Org.BouncyCastle.Asn1.X509;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryGUI.Datas
{
    internal class Create
    {
        LibraryResults libraryResults = new LibraryResults();
        public LibraryResults DeleteAuthor(string name)
        {
            using (var context = new librarydbContext())
            {
                var author = new Authors
                {
                    AuthorName = name
                };

                context.Authors.Remove(author);
                context.SaveChanges();
                libraryResults.Message = "Sikeres szerző törlés";
                libraryResults.Result = author.AuthorName;


                return libraryResults;
            }

        }

        public LibraryResults DeleteCategory(string categoryName)
        {
            using (var context = new librarydbContext())
            {
                var category = new Categories
                {
                    CategoryName = categoryName
                };

                context.Categories.Remove(category);
                context.SaveChanges();
                libraryResults.Message = "Sikeres kategória törlés";
                libraryResults.Result = category.CategoryName;


                return libraryResults;
            }

        }

        public LibraryResults DeleteBooks(string title, DateTime date, int authId, int categoryId)
        {
            using (var context = new librarydbContext())
            {
                var book = new Books
                {
                    Title = title,
                    PublishDate = date,
                    AuthorId = authId,
                    CategoryId = categoryId
                };

                context.Books.Remove(book);
                context.SaveChanges();
                libraryResults.Message = "Sikeres könyv törlés";
                libraryResults.Result = book;


                return libraryResults;
            }

        }
    }
}
