using System;
using System.Collections.Generic;
using System.Text;

namespace HomeCustomerVersionOfTehranRey.Classes
{
    public enum CarpetType
    {
        Ghali,
        Ghalicheh,
        ZarOnim,
        Kenareh,
        Dayereh
    };
    public enum CarpetMadeInFrom
    {
        Hamedan,
        Mashhad,
        Kashan,
        Ardekan,
        Tabriz,
        Esfehan,
    };

    public class Carpet
    {

        private int width;
        private int length;
        private int code;
        private CarpetType type;
        private CarpetMadeInFrom madeIn;
        private DateTime enterDate;
        // now we use booleans to show the types of Khadamats,
        // but it is better to use enum ...
        private bool shoor;
        private bool rofoo;

        public Carpet(int Width, int Length, int Code, CarpetType Type, CarpetMadeInFrom MadeIn, 
            DateTime EnterDate, bool Shoor, bool Rofoo)
        {
            width = Width;
            length = Length;
            type = Type;
            madeIn = MadeIn;
            code = Code;
            enterDate = EnterDate;
            shoor = Shoor;
            rofoo = Rofoo;
        }


    }

}
