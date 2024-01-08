namespace snapshooter_net462 
{
    using NUnit.Framework;
    using Snapshooter;
    using Snapshooter.NUnit;
    
    public class Tests
    {
        [Test]
        public void Test1()
        {
            Snapshot.Match(42);
        }
    }
}