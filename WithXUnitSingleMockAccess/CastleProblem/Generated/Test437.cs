using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test437
    {
        private readonly Mock<IClass437> aClass;

        public Test437()
        {
            this.aClass = new Mock<IClass437>();
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
