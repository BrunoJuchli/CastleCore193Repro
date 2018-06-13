using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test502
    {
        private readonly Mock<IClass502> aClass;

        public Test502()
        {
            this.aClass = new Mock<IClass502>();
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
