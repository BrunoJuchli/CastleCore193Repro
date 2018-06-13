using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test219
    {
        private readonly Mock<IClass219> aClass;

        public Test219()
        {
            this.aClass = new Mock<IClass219>();
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
