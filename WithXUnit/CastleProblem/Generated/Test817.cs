using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test817
    {
        private readonly Mock<IClass817> aClass;

        public Test817()
        {
            this.aClass = new Mock<IClass817>();
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
