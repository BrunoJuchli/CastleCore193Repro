using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test148
    {
        private readonly Mock<IClass148> aClass;

        public Test148()
        {
            this.aClass = new Mock<IClass148>();
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
