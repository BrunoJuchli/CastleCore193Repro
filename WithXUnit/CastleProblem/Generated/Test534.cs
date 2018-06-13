using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test534
    {
        private readonly Mock<IClass534> aClass;

        public Test534()
        {
            this.aClass = new Mock<IClass534>();
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
