
namespace Data
{
    public class PracticeContextFactory : IPracticeContextFactory
    {
        public IPracticeContext CreateContext()
        {
            return new PracticeContext();
        }
    }
}
