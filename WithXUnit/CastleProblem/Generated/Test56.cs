using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test56
    {
        private readonly Mock<IClass56> aClass;

        public Test56()
        {
            this.aClass = new Mock<IClass56>();
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
