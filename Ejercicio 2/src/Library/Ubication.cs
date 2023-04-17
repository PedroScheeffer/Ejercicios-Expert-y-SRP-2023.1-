namespace Library
{
    public class Ubication
    {
        string name { get; set; }
        string adress { get; set; }
        public Ubication(string name, string adress)
        {
            this.name = name;
            this.adress = adress;
        }
        public Ubication(string adress)
        {
            this.name = adress;
            this.adress = adress;
        }
        public bool isValid()
        {
            foreach(var field in this.GetType().GetFields())
            {
                if(field.ToString() != "")
                {
                    return false;
                }
            }
            return true;
        }
    }
}