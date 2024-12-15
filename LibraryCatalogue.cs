using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using static System.Reflection.Metadata.BlobBuilder;
using System.IO;
using System.Text.Json;

namespace LibraryManagementSystem
{
    public static class LibraryCatalogue

    {
        private static readonly string filePath = "LibraryCatalogue.json"; // File path for JSON storage
        private static List<Book> books = new List<Book>
            {
                new Book { Title = "You Cannot Die", Author = "Ian Currie", ISBN = "978-0743273599", PublicationDate = "1998", Genre = "Controversial", Description = "A collection of research on death and dying", ImageName = Image.FromFile("Resources/YouCannotDie.jpg") },
                new Book { Title = "Many Mansions", Author = "Gina Cerminera", ISBN = "978-0446315555", PublicationDate = "1956", Genre = "Biography", Description = "The amazing story of the life of the reluctant seer Edgar Cayce", ImageName = Image.FromFile("Resources/ManyMansions.jpg") },
                new Book { Title = "Destined for Murder", Author = "Edna Rowland", ISBN = "978-0451522232", PublicationDate = "1995", Genre = "True Crime", Description = "An astrologer looks at murder and the nativity", ImageName = Image.FromFile("Resources/Destined.jpg") },
                new Book { Title = "Magic White and Black", Author = "Franz Hartmann", ISBN = "978-07432949194", PublicationDate = "1912", Genre = "Esoteric", Description = "An exploratino of forbidden knowledge and Rosicrucian wisdom", ImageName = Image.FromFile("Resources/Magic.jpg") },
                new Book { Title = "No Great Mischief", Author = "Alastair Macleod", ISBN = "978-0043233735", PublicationDate = "1996", Genre = "Fiction", Description = "A novel that explores the family ties of love, shared history, and fierce loyalty with themes of exile and loss", ImageName = Image.FromFile("Resources/Mischief.jpg") },
                new Book { Title = "Something I've Been Meaning to Tell You", Author = "Alice Munro", ISBN = "978-0673273593", PublicationDate = "1984", Genre = "Fiction", Description = "Short stories that explore the mysteries, dangers, joys, and bewilderment in ordinary lives", ImageName = Image.FromFile("Resources/Something.jpg") },
                new Book { Title = "Till We Have Faces", Author = "C.S. Lewis", ISBN = "978-07562641023", PublicationDate = "1956", Genre = "Mythology", Description = "A retelling of the myth of Cupid and Psyche, based on its telling in a chapter of The Golden Ass of Apuleius", ImageName = Image.FromFile("Resources/Faces.jpg") },
                new Book { Title = "We Keep a Light", Author = "Eleanor Richardson", ISBN = "978-02438482967", PublicationDate = "1946", Genre = "Autobiography", Description = "An exquisitely written, engrossing record of family life set against a glowing lighthouse, the enduring shores of Nova Scotia, and the ever-changing sea", ImageName = Image.FromFile("Resources/Light.jpg") },
                new Book { Title = "The Flaming Door", Author = "Eleanor Merry", ISBN = "978-06722509294", PublicationDate = "1962", Genre = "Mythology", Description = "The secrets of initiation slumber in the ancient legends bridging the threshold between the physical and spiritual worlds", ImageName = Image.FromFile("Resources/FlamingDoor.jpg") },
                new Book { Title = "Tarzan and the Jewels of Opar", Author = "Edgar Rice Burroughs", ISBN = "978-01339295868", PublicationDate = "1916", Genre = "Fiction", Description = "Tarzan returns to Opar and uncovers the secret location of a large stockpile of gold", ImageName = Image.FromFile("Resources/Tarzan.jpg") },
                new Book { Title = "Jake and the Kid", Author = "W.O. Mitchell", ISBN = "978-071770301855", PublicationDate = "1974", Genre = "Fiction", Description = "A classic Canadian story of a lively boy and his cranky old yarn-spinning hero on a Saskatchewan farm", ImageName = Image.FromFile("Resources/Jake.jpg") },
                new Book { Title = "The Water Babies", Author = "Charles Kingsley", ISBN = "978-01222029496", PublicationDate = "1863", Genre = "Fiction", Description = "A young chimney sweep named Tom falls into a river where he is transformed into a water-baby", ImageName = Image.FromFile("Resources/WaterBabies.jpg") },
                new Book { Title = "The Scarlet Pimpernel", Author = "Baroness Orczy", ISBN = "978-0728383838", PublicationDate = "2000", Genre = "Fiction", Description = "A timeless novel of adventure, intrigue, and romance is sparked by one man's defiance in the face of authority", ImageName = Image.FromFile("Resources/Scarlet.jpg") },
                new Book { Title = "I Heard the Owl Call My Name", Author = "Margaret Craven", ISBN = "978-073599687755", PublicationDate = "1967", Genre = "Fiction", Description = "A classic and timeless story of a young man's journey into the Pacific Northwest.", ImageName = Image.FromFile("Resources/Owl.jpg") },
                new Book { Title = "Tong Sing", Author = "Charles Windridge", ISBN = "978-063753321", PublicationDate = "1999", Genre = "Almanac", Description = "The Book of Wisdom Based on the Ancient Chinese Almanac", ImageName = Image.FromFile("Resources/TongSing.jpg") },
                new Book { Title = "A Wrinkle in Time", Author = "Madeleine L'Engle", ISBN = "978-3758673729", PublicationDate = "1963", Genre = "Fiction", Description = "On a wild night, a strange visitor arrives and invites three friends on a most dangerous and extraordinary adventure", ImageName = Image.FromFile("Resources/Wrinkle.jpg") },
                new Book { Title = "Winged Pharaoh", Author = "Joan Grant", ISBN = "978-02037734756", PublicationDate = "1937", Genre = "Fiction", Description = "The story of Sekeeta, the Pharaoh’s daughter set in ancient Egypt", ImageName = Image.FromFile("Resources/Pharoah.jpg") },
                new Book { Title = "Watership Down", Author = "Richard Adams", ISBN = "978-05376937484", PublicationDate = "1972", Genre = "Fiction", Description = "A beloved story of a group of rabbits on an epic journey in search of home.", ImageName = Image.FromFile("Resources/Watership.jpg") },
                new Book { Title = "The Alchemist", Author = "Paulo Coelho", ISBN = "978-0062315007", PublicationDate = "1988", Genre = "Fiction", Description = "A mystical story about following one's dreams", ImageName = Image.FromFile("Resources/Alchemist.jpg") },
                new Book { Title = "The Girl with the Dragon Tattoo", Author = "Stieg Larsson", ISBN = "978-0307454546", PublicationDate = "2005", Genre = "Thriller", Description = "A murder mystery involving a journalist and a computer hacker", ImageName = Image.FromFile("Resources/DragonTattoo.jpg") },
                new Book { Title = "The Kite Runner", Author = "Khaled Hosseini", ISBN = "978-1594631931", PublicationDate = "2003", Genre = "Literary Fiction", Description = "A story of friendship, betrayal, and redemption in Afghanistan", ImageName = Image.FromFile("Resources/KiteRunner.jpg") },
                new Book { Title = "Life of Pi", Author = "Yann Martel", ISBN = "978-0156027328", PublicationDate = "2001", Genre = "Adventure", Description = "A philosophical novel about survival at sea", ImageName = Image.FromFile("Resources/LifeOfPi.jpg") },
                new Book { Title = "The Road", Author = "Cormac McCarthy", ISBN = "978-0307387899", PublicationDate = "2006", Genre = "Post-Apocalyptic", Description = "A father and son's journey through a devastated America", ImageName = Image.FromFile("Resources/TheRoad.jpg") },
                new Book { Title = "The Book Thief", Author = "Markus Zusak", ISBN = "978-0375842207", PublicationDate = "2005", Genre = "Historical Fiction", Description = "A story about a girl in Nazi Germany", ImageName = Image.FromFile("Resources/BookThief.jpg") },
                new Book { Title = "Gone Girl", Author = "Gillian Flynn", ISBN = "978-0307588371", PublicationDate = "2012", Genre = "Thriller", Description = "A psychological thriller about a missing woman", ImageName = Image.FromFile("Resources/GoneGirl.jpg") },
                new Book { Title = "The Help", Author = "Kathryn Stockett", ISBN = "978-0425232200", PublicationDate = "2009", Genre = "Historical Fiction", Description = "African American maids working in white households in 1960s Mississippi", ImageName = Image.FromFile("Resources/TheHelp.jpg") },
                new Book { Title = "The Fault in Our Stars", Author = "John Green", ISBN = "978-0142424179", PublicationDate = "2012", Genre = "Young Adult", Description = "A love story between two teenage cancer patients", ImageName = Image.FromFile("Resources/FaultInOurStars.jpg") },
                new Book { Title = "Dune", Author = "Frank Herbert", ISBN = "978-0441172719", PublicationDate = "1965", Genre = "Science Fiction", Description = "An epic science fiction novel about politics and religion", ImageName = Image.FromFile("Resources/Dune.jpg") },
                new Book { Title = "The Handmaid's Tale", Author = "Margaret Atwood", ISBN = "978-0385490818", PublicationDate = "1985", Genre = "Dystopian", Description = "A dystopian novel about women's rights", ImageName = Image.FromFile("Resources/HandmaidsTale.jpg") },
                new Book { Title = "The Name of the Wind", Author = "Patrick Rothfuss", ISBN = "978-0756404741", PublicationDate = "2007", Genre = "Fantasy", Description = "A fantasy novel about a young magician", ImageName = Image.FromFile("Resources/NameOfWind.jpg") },
                new Book { Title = "The Road Less Traveled", Author = "M. Scott Peck", ISBN = "978-0743243153", PublicationDate = "1978", Genre = "Self-Help", Description = "A book about spiritual and psychological growth", ImageName = Image.FromFile("Resources/RoadLessTraveled.jpg") },
                new Book { Title = "The Silence of the Lambs", Author = "Thomas Harris", ISBN = "978-0312924584", PublicationDate = "1988", Genre = "Thriller", Description = "A psychological horror thriller", ImageName = Image.FromFile("Resources/SilenceOfLambs.jpg") },
                new Book { Title = "The Color Purple", Author = "Alice Walker", ISBN = "978-0156028356", PublicationDate = "1982", Genre = "Literary Fiction", Description = "A powerful story about African American women", ImageName = Image.FromFile("Resources/ColorPurple.jpg") },
                new Book { Title = "The Picture of Dorian Gray", Author = "Oscar Wilde", ISBN = "978-0141439570", PublicationDate = "1890", Genre = "Gothic Fiction", Description = "A philosophical novel about beauty and morality", ImageName = Image.FromFile("Resources/DorianGray.jpg") },
                new Book { Title = "The Odyssey", Author = "Homer", ISBN = "978-0140268867", PublicationDate = "800 BCE", Genre = "Epic Poetry", Description = "An ancient Greek epic poem", ImageName = Image.FromFile("Resources/Odyssey.jpg") },
                
                new Book { Title = "Cloud Atlas", Author = "David Mitchell", ISBN = "978-0375507250", PublicationDate = "2004", Genre = "Science Fiction", Description = "Six nested stories spanning time and space", ImageName = Image.FromFile("Resources/CloudAtlas.jpg") },
                new Book { Title = "The Shadow of the Wind", Author = "Carlos Ruiz Zafón", ISBN = "978-0143034902", PublicationDate = "2001", Genre = "Mystery", Description = "A story about a mysterious book in Barcelona", ImageName = Image.FromFile("Resources/ShadowWind.jpg") },
                new Book { Title = "The Pillars of the Earth", Author = "Ken Follett", ISBN = "978-0451166890", PublicationDate = "1989", Genre = "Historical Fiction", Description = "Epic about building a cathedral in medieval England", ImageName = Image.FromFile("Resources/Pillars.jpg") },
                new Book { Title = "The Night Circus", Author = "Erin Morgenstern", ISBN = "978-0307744432", PublicationDate = "2011", Genre = "Fantasy", Description = "A magical competition between two illusionists", ImageName = Image.FromFile("Resources/NightCircus.jpg") },
                new Book { Title = "Snow Crash", Author = "Neal Stephenson", ISBN = "978-0553380958", PublicationDate = "1992", Genre = "Science Fiction", Description = "Cyberpunk adventure in virtual reality", ImageName = Image.FromFile("Resources/SnowCrash.jpg") },
                new Book { Title = "The Three-Body Problem", Author = "Cixin Liu", ISBN = "978-0765382030", PublicationDate = "2008", Genre = "Science Fiction", Description = "First contact with an alien civilization", ImageName = Image.FromFile("Resources/ThreeBody.jpg") },
                new Book { Title = "Wolf Hall", Author = "Hilary Mantel", ISBN = "978-0805080681", PublicationDate = "2009", Genre = "Historical Fiction", Description = "Tudor England through Thomas Cromwell's eyes", ImageName = Image.FromFile("Resources/WolfHall.jpg") },
                new Book { Title = "The Wind-Up Bird Chronicle", Author = "Haruki Murakami", ISBN = "978-0679775430", PublicationDate = "1994", Genre = "Literary Fiction", Description = "Surreal journey through modern Japan", ImageName = Image.FromFile("Resources/WindUpBird.jpg") },
                new Book { Title = "The Master and Margarita", Author = "Mikhail Bulgakov", ISBN = "978-0679760801", PublicationDate = "1967", Genre = "Satire", Description = "Devil visits Soviet Moscow", ImageName = Image.FromFile("Resources/MasterMargarita.jpg") },
                new Book { Title = "The Blind Assassin", Author = "Margaret Atwood", ISBN = "978-0385720953", PublicationDate = "2000", Genre = "Literary Fiction", Description = "Story within a story about family secrets", ImageName = Image.FromFile("Resources/BlindAssassin.jpg") },
                new Book { Title = "Jonathan Strange & Mr Norrell", Author = "Susanna Clarke", ISBN = "978-0765356154", PublicationDate = "2004", Genre = "Historical Fantasy", Description = "Alternative history of English magic", ImageName = Image.FromFile("Resources/JonathanStrange.jpg") },


                new Book { Title = "Behind the Attic Wall", Author = "Sylvia Cassedy", ISBN = "978-08387745632", PublicationDate = "1983", Genre = "Fiction", Description = "In the bleak, forbidding house of her great-aunts, neglected twelve-year-old orphan Maggie finds magic that awakens in her the capacity to love and be loved.", ImageName = Image.FromFile("Resources/Attic.jpg") },
                new Book { Title = "The Outport People", Author = "Claire Mowat", ISBN = "978-0603824958", PublicationDate = "1987", Genre = "Fiction", Description = "A fictional memoir that beautifully recreates an almost vanished world where life revolved tightly around the home and neighbours", ImageName = Image.FromFile("Resources/Outport.jpg") },
            };
        static LibraryCatalogue()
        {
            LoadBooks(); // Load books from file on application start
        }

        public static List<Book> GetBooks()
        {
            return books;
        }

        public static void AddBook(Book newBook)
        {
            books.Add(newBook);
            SaveBooks(); // Save changes to file
        }

        private static void SaveBooks()
        {
            try
            {
                string json = JsonSerializer.Serialize(books, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText(filePath, json);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error saving books: {ex.Message}");
            }
        }

        private static void LoadBooks()
        {
            if (File.Exists(filePath))
            {
                try
                {
                    string json = File.ReadAllText(filePath);
                    books = JsonSerializer.Deserialize<List<Book>>(json) ?? new List<Book>();
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error loading books: {ex.Message}");
                }
            }
        }
    }
    }

    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }
        public string PublicationDate { get; set; }
        public string Genre { get; set; }
        public string Description { get; set; }
        public Image ImageName { get; set; }
        public DateTime? DueDate { get; set; }
        public bool IsBorrowed { get; set; }
        public override string ToString()
        {
            if (IsBorrowed)
                return $"{Title} - Borrowed (Due: {DueDate?.ToShortDateString()})";
            return $"{Title} - Available";
        }
        
        //{
          //  return $"{Title} - Due: {(DueDate.HasValue ? DueDate.Value.ToShortDateString() : "Not borrowed")}";
        //}
    }


