using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Win_Form_28_03_17
{
   public class Library
    {
        
        static public List<Book> listBooks = new List<Book>();
        static public List<Journal> listJournals = new List<Journal>();
        static public List<Newspaper> listNewspaper = new List<Newspaper >();

        public void CreateLibraryBooks()
        {
            listBooks.Add(new Book() { Author = "Mikhail Bulgakov", name = "Master i Margo", year = 1891, number = 1000 });
            listBooks.Add(new Book() { Author = "Lev Tolstoi", name = "Mertvye Dushi", year = 1865, number = 835 });
            listBooks.Add(new Book() { Author = "Nikolai Gogol ", name = "Mertvye Dushi", year = 1842, number = 933 });
            listBooks.Add(new Book() { Author = "Alexander Pushki ", name = "Evgenyi Onegin", year = 1825, number = 1114 });
            listBooks.Add(new Book() { Author = "Anton Chekhov ", name = "Palata №6", year = 1892, number = 753 });
        }
        public void CreateLibraryJournals()
        {
            listJournals.Add(new Journal() { name = "Cosmopolitan", numberEdition = "№ 147", numberOfPages = 25 });
            listJournals.Add(new Journal() { name = "Vogue", numberEdition = "№ 45", numberOfPages = 63 });
            listJournals.Add(new Journal() { name = "GQ ", numberEdition = "№ 96", numberOfPages = 15 });
            listJournals.Add(new Journal() { name = "Vanity Fair ", numberEdition = "№ 521", numberOfPages = 42 });
            listJournals.Add(new Journal() { name = "Marie Claire ", numberEdition = "№ 313", numberOfPages = 28 });
        }
        public void CreateLibraryNewspaper()
        {
            listNewspaper.Add(new Newspaper() { name = "The New Yourk Times", rating = "65 %", numberOfPages = 42 });
            listNewspaper.Add(new Newspaper() { name = "The Wall Street Journal", rating = "48 %", numberOfPages = 53 });
            listNewspaper.Add(new Newspaper() { name = "Los Angeles Times", rating = "39 %", numberOfPages = 37 });
        }
    }
}
