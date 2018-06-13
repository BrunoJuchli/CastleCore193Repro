using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test60
    {
        private readonly Mock<IClass60> aClass;

        public Test60()
        {
            this.aClass = new Mock<IClass60>();
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
