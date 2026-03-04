using LibraryGUI.Models;
using Org.BouncyCastle.Asn1.X509;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryGUI.Datas
{
    internal class Delete
    {
        
        public object DeleteAuthors(int id)
        {

            LibraryResults results = new LibraryResults();
            using (var context = new librarydbContext())
            {
                var author = context.Categories.Find(id);
                if (author != null)
                {
                    context.Categories.Remove(author);
                    context.SaveChanges();
                    results.Message = "Author deleted successfully.";
                    results.Result = true;
                    return results;
                }
                else
                {
                    results.Message = "Author not found.";
                    results.Result = false;
                    return results;
                }
            }

        }

        public object DeleteBooks(int id)
        {

            LibraryResults results = new LibraryResults();
            using (var context = new librarydbContext())
            {
                var book = context.Categories.Find(id);
                if (book != null)
                {
                    context.Categories.Remove(book);
                    context.SaveChanges();
                    results.Message = "Book deleted successfully.";
                    results.Result = true;
                    return results;
                }
                else
                {
                    results.Message = "Book not found.";
                    results.Result = false;
                    return results;
                }
            }

        }

        public object DeleteCategory(int id)
        {

            LibraryResults results = new LibraryResults();
            using (var context = new librarydbContext())
            {
                var category = context.Categories.Find(id);
                if (category != null)
                {
                    context.Categories.Remove(category);
                    context.SaveChanges();
                    results.Message = "Category deleted successfully.";
                    results.Result = true;
                    return results;
                }
                else
                {
                    results.Message = "Category not found.";
                    results.Result = false;
                    return results;
                }
            }

        }

    }
}
