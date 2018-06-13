using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test640
    {
        private readonly Mock<IClass640> aClass;

        public Test640()
        {
            this.aClass = new Mock<IClass640>();
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
