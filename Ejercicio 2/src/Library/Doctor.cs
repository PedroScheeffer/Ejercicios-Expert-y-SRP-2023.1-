namespace Library
{
    public class Doctor
    {
        string name { get; set; }
        public Doctor(string name)
        {
            this.name = name;
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