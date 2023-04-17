using System;
namespace Library
{
    public class Patient
    {
        public string name { get; set; }
        public string id { get; set; }
        public string number { get; set; }
        public Patient(string name, string id, string number)
        {
            this.name = name;
            this.id = id;
            this.number = number;
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