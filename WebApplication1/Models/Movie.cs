namespace WebApplication1.Models
{
    public class Movie
    {
        private int id;
        private string name;
        private string image;
        private float rate;
        private string category;
        public int Id {
            get { return id; }
            set { id = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Image
        {
            get { return image; }
            set { image = value; }
        }

        public float Rate
        {
            get { return rate; }
            set { rate = value; }
        }

        public string Category
        {
            get { return category; }
            set { category = value; }
        }

        public Movie(int id, string name, string image, float rate, string category)
        {
            this.id = id;
            this.name = name;
            this.image = image;
            this.rate = rate;
            this.category = category;
        }

        public Movie()
        {
            
        }
    }
}