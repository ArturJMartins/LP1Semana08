namespace AnimalKingdom
{
    public class Bat : Animal, IMammal, ICanFly
    {
        public int NumberOfWings{get{return 2;}}

        public int NumberOfNipples{get{return 2;}}
        public override string Sound()
        {
            return base.Sound() + "<Click>";
        }
    }
}