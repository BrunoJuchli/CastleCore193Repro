using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test693
    {
        private readonly Mock<IClass693> aClass;

        public Test693()
        {
            this.aClass = new Mock<IClass693>();
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
