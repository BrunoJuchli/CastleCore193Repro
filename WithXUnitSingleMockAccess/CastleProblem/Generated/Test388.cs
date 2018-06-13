using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test388
    {
        private readonly Mock<IClass388> aClass;

        public Test388()
        {
            this.aClass = new Mock<IClass388>();
        }

        [Theory]
        [InlineData(true)]
        public void DoSomething(bool value)
        {
            this.aClass.Setup(x => x.DoSomething()).Returns(value);

            Assert.Equal(this.aClass.Object.DoSomething(), value);
        }
    }
}
