namespace Systekna.Core.ValidObject
{
    public class Valid : EntityUser
    {
        public bool ValidValue { get; set; } = false;
        public string StringMethod { get; set; }

        public Valid()
        {

        }

        public Valid(string method)
        {
            StringMethod = method;
        }
    }
}
