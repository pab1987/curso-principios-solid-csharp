namespace InterfaceSegregation
{
    class Arquitect : IActivities
    {
        public void Tester()
        {
        }

        public void Plan() 
        {
            throw new ArgumentException();
        }

        public void Comunicate() 
        {
            throw new ArgumentException();
        }

        public void Test() 
        {
            throw new ArgumentException();
        }

        public void Design()
        {
            throw new NotImplementedException();
        }

        public void Develop()
        {
            throw new NotImplementedException();
        }
    }
}