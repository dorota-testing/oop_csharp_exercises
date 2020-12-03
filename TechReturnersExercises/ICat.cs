using System;

namespace TechReturners.Exercises
{
    public interface ICat
    {
        bool IsAsleep { get; }
        string Setting { get; }
        float AverageHeight { get; }
        string Eat { get; }
        void GoToSleep();
        void WakeUp();


    }

    public abstract class Cat
    {
        public bool IsAsleep { get; set; }
        public string Setting { get; set; }
        public string Eat { get; set; }
        public float AverageHeight { get; set; }
        public void GoToSleep()
        {
            IsAsleep = true;
        }
        public void WakeUp()
        {
            IsAsleep = false;
        }
    }

    public class LionCat : Cat, ICat
    {
        public LionCat()
        {
            Eat = "Roar!!!!";
            AverageHeight = 1100;
            Setting = "Wild";

        }
    }
    public class CheetahCat : Cat, ICat
    {
        public CheetahCat()
        {
            Eat = "Zzzzzzz";
            AverageHeight = 300;
            Setting = "Wild";

        }
    }
    public class DomesticCat : Cat, ICat
    {
        public DomesticCat()
        {
            Eat = "Purrrrrrr";
            AverageHeight = 23;
            Setting = "domestic";

        }
    }
}
