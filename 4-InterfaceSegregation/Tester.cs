namespace InterfaceSegregation
{
    public class Tester : IWorkTeamActivities, ITestActivities
    {
        public Tester()
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
            Console.WriteLine("I am a tester and I'm testing a app.");
        }
    }
}