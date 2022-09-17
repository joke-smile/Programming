namespace ObjectOrientedPractics.Services
{
    public class IdGenerator
    {
        private static int _id = 0;

        public static int GetId()
        {
            return _id++;
        }
    }
}
