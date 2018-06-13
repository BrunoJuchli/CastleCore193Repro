using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test177
    {
        private readonly Mock<IClass177> aClass;

        public Test177()
        {
            this.aClass = new Mock<IClass177>();
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
