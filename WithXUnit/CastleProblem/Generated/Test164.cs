using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test164
    {
        private readonly Mock<IClass164> aClass;

        public Test164()
        {
            this.aClass = new Mock<IClass164>();
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
