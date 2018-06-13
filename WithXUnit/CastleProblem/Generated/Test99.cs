using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test99
    {
        private readonly Mock<IClass99> aClass;

        public Test99()
        {
            this.aClass = new Mock<IClass99>();
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
