using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test703
    {
        private readonly Mock<IClass703> aClass;

        public Test703()
        {
            this.aClass = new Mock<IClass703>();
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
