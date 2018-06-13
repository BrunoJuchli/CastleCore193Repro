using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test170
    {
        private readonly Mock<IClass170> aClass;

        public Test170()
        {
            this.aClass = new Mock<IClass170>();
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
