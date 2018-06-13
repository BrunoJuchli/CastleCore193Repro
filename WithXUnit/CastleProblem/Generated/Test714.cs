using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test714
    {
        private readonly Mock<IClass714> aClass;

        public Test714()
        {
            this.aClass = new Mock<IClass714>();
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
