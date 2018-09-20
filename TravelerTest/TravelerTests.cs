using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelerTest
{
    [TestFixture]
    class TravelerTests
    {
        Beach beach = new Beach();

        [Test]
        public void Enter_Eye_Color()
        {
            Beach beach = new Beach("blue");
            string response = beach.GetColor;
            Assert.That(response, Is.EqualTo("blue"));
        }

        [Test]
        public void Enter_String_Return_Beach()
        {
            string response = beach.GetBeach("blue");
            Assert.That(response, Is.EqualTo(" "));
        }

        [Test]
        public void Enter_String_Return_Beach_Not_Empty()
        {
            string response = beach.GetBeach("green");
            Assert.That(response, Is.EqualTo("Seal Beach"));
        }

        [Test]
        public void Enter_String_Return_Beach_Color_Brown()
        {
            string response = beach.GetBeach("brown");
            Assert.That(response, Is.EqualTo("Newport Beach"));
        }

        [Test]
        public void Enter_String_Return_Beach_Color_Gray()
        {
            string response = beach.GetBeach("gray");
            Assert.That(response, Is.EqualTo("Huntington Beach"));
        }

        [Test]
        public void Set_Shoe_Size()
        {
            beach.GetShoeSize = 10.5;
            double response = beach.GetShoeSize;
            Assert.That(response, Is.EqualTo(10.5));
        }

        [Test]
        public void Get_Hotel_Size_Equals_0_Beach_Equals_Empty_Return_Null()
        {
            string location = beach.GetBeach(" ");
            string response = beach.GetHotel(0, location);
            Assert.That(response, Is.EqualTo(null));
        }

        [Test]
        public void Get_Hotel_Size_Equals_10_Beach_Equals_SealBeach_Return_Hilton()
        {
            string location = beach.GetBeach("green");
            string response = beach.GetHotel(10, location);
            Assert.That(response, Is.EqualTo("Hilton"));
        }

        [Test]
        public void Get_Hotel_Size_Equals_11dot5_Beach_Equals_Huntington_Beach_Return_BestWestern()
        {
            string location = beach.GetBeach("gray");
            string response = beach.GetHotel(11.5, location);
            Assert.That(response, Is.EqualTo("Best Western"));
        }

        [Test]
        public void Get_Hotel_Size_Equals_12dot5_Beach_Equals_Newport_Beach_Return_Marriot()
        {
            string location = beach.GetBeach("brown");
            string response = beach.GetHotel(12.5, location);
            Assert.That(response, Is.EqualTo("Marriot"));
        }

        [Test]
        public void Get_Hotel_Size_Equals_6_Beach_Equals_Seal_Beach_Return_Hilton()
        {
            string location = beach.GetBeach("green");
            string response = beach.GetHotel(6, location);
            Assert.That(response, Is.EqualTo("Hilton"));
        }

        [Test]
        public void Get_Hotel_Size_Equals_7dot3_Beach_Equals_Seal_Beach_Return_Hilton()
        {
            string location = beach.GetBeach("green");
            string response = beach.GetHotel(7.3, location);
            Assert.That(response, Is.EqualTo("Hilton"));
        }

        [Test]
        public void Get_Hotel_Size_Equals_10dot1_Beach_Equals_Seal_Huntington_Return_BestWestern()
        {
            string location = beach.GetBeach("gray");
            string response = beach.GetHotel(10.1, location);
            Assert.That(response, Is.EqualTo("Best Western"));
        }

        [Test]
        public void Get_Hotel_Size_Greater_Than_12_Beach_Equals_Seal_NewportBeach_Return_Marriot()
        {
            string location = beach.GetBeach("brown");
            string response = beach.GetHotel(13, location);
            Assert.That(response, Is.EqualTo("Marriot"));
        }

        [Test]
        public void Get_Rental_Car_Make_and_Type_Return_Null()
        {
            string response = beach.GetNames();
            Assert.That(response, Is.EqualTo(null));
        }

        [Test]
        public void Get_Rental_Car_Make_and_Type_Return_Length_True()
        {
            beach.Names.Add("Pete");
            beach.Names.Add("Tom");
            bool response = beach.Names.Count != 0;
            Assert.That(response, Is.EqualTo(true));
            beach.Names.RemoveAt(0);
            beach.Names.RemoveAt(0);
        }

        [Test]
        public void Get_Rental_Car_Make_and_Type_Return_Length_False()
        {
            bool response = beach.Names.Count == 0;
            Assert.That(response, Is.EqualTo(true));
        }

        [Test]
        public void Get_Rental_Car_Make_and_Type_Return_Toyota_Length_Greater_Than_Zero_Less_Than_Two()
        {
            beach.Names.Add("Pete");
            beach.Names.Add("Tom");
            string response = beach.GetNames();
            Assert.That(response, Is.EqualTo("Toyota"));
        }

    }
}
