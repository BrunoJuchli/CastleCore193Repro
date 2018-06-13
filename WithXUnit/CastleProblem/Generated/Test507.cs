using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test507
    {
        private readonly Mock<IClass507> aClass;

        public Test507()
        {
            this.aClass = new Mock<IClass507>();
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
