using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test176
    {
        private readonly Mock<IClass176> aClass;

        public Test176()
        {
            this.aClass = new Mock<IClass176>();
        }

        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void DoSomething(bool value)
        {
            this.aClass.Setup(x => x.DoSomething()).Returns(value);

            Assert.Equal(this.aClass.Object.DoSomething(), value);
        }
    }
}
