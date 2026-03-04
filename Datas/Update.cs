using LibraryGUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryGUI.Datas
{
    internal class Update
    {

        LibraryResults LibraryResults = new LibraryResults();

        public object UpdateAuthor(int id, Authors authors)
        {
            
            using (var context = new librarydbContext())
            {
                
                var extendedauthor = context.Authors.Find(id);

                if(extendedauthor != null)
                {

                    extendedauthor.AuthorName = authors.AuthorName;

                    context.Authors.Update(extendedauthor);
                    context.SaveChanges();

                    LibraryResults.Result = "Sikeres módosítás!";
                    LibraryResults.Result = extendedauthor;

                    return LibraryResults;

                }

                else
                {
                    LibraryResults.Result = "Sikertelen módosítás!";
                    LibraryResults.Result = extendedauthor;

                    return LibraryResults;
                }

            }

        }

        public object UpdateBooks(int id, Books books)
        {

            using (var context = new librarydbContext())
            {

                var extendedbooks = context.Books.Find(id);

                if (extendedbooks != null)
                {

                    extendedbooks.BookId = books.Title;

                    context.Authors.Update(extendedbooks);
                    context.SaveChanges();

                    LibraryResults.Result = "Sikeres módosítás!";
                    LibraryResults.Result = extendedbooks;

                    return LibraryResults;

                }

                else
                {
                    LibraryResults.Result = "Sikertelen módosítás!";
                    LibraryResults.Result = extendedbooks;

                    return LibraryResults;
                }

            }

        }

        public object UpdateCategory(int id, Authors authors)
        {

            using (var context = new librarydbContext())
            {

                var extendedauthor = context.Authors.Find(id);

                if (extendedauthor != null)
                {

                    extendedauthor.AuthorName = authors.AuthorName;

                    context.Authors.Update(extendedauthor);
                    context.SaveChanges();

                    LibraryResults.Result = "Sikeres módosítás!";
                    LibraryResults.Result = extendedauthor;

                    return LibraryResults;

                }

                else
                {
                    LibraryResults.Result = "Sikertelen módosítás!";
                    LibraryResults.Result = extendedauthor;

                    return LibraryResults;
                }

            }

        }

    }
}
