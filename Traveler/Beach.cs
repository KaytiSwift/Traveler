namespace TravelerTest
{
    public class Beach
    {
        //Fields
        private string eyeColor;
        private double shoeSize;

        //Properties
        public string GetColor
        {
            get { return this.eyeColor; }
            set { this.eyeColor = value; }
        }

        public double GetShoeSize
        {
            get { return this.shoeSize; }
            set { this.shoeSize = value; }
        }

        //Constructors
        public Beach()
        {
            //default constructor
        }

        public Beach(string eyeColor)
        {
            this.GetColor = eyeColor;
        }

        //Methods
        public string GetBeach(string eyeColor)
        {
            if (eyeColor == "green")
            {
                return "Seal Beach";
            }
            else if (eyeColor == "brown")
            {
                return "Newport Beach";
            }
            else if (eyeColor == "gray")
            {
                return "Huntington Beach";
            }
            else
            {
                return " ";
            }
        }

        public string GetHotel(double num, string value)
        {
            if (num == 10 && value == "Seal Beach")
            {
                return "Hilton";
            }
            return null;
        }
       
    }
}