using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test650
    {
        private readonly Mock<IClass650> aClass;

        public Test650()
        {
            this.aClass = new Mock<IClass650>();
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
