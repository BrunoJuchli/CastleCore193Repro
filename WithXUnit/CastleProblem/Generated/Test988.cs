using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test988
    {
        private readonly Mock<IClass988> aClass;

        public Test988()
        {
            this.aClass = new Mock<IClass988>();
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
