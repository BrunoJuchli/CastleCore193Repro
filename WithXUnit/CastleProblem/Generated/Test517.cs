using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test517
    {
        private readonly Mock<IClass517> aClass;

        public Test517()
        {
            this.aClass = new Mock<IClass517>();
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
