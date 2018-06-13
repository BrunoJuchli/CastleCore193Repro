using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test20
    {
        private readonly Mock<IClass20> aClass;

        public Test20()
        {
            this.aClass = new Mock<IClass20>();
        }

        [Theory]
        [InlineData(true)]
        public void DoSomething(bool value)
        {
            this.aClass.Setup(x => x.DoSomething()).Returns(value);

            Assert.Equal(this.aClass.Object.DoSomething(), value);
        }
    }
}
