using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test206
    {
        private readonly Mock<IClass206> aClass;

        public Test206()
        {
            this.aClass = new Mock<IClass206>();
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
