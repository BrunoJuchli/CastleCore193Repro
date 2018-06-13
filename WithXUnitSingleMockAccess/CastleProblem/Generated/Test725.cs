using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test725
    {
        private readonly Mock<IClass725> aClass;

        public Test725()
        {
            this.aClass = new Mock<IClass725>();
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
