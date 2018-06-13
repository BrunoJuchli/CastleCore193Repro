using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test600
    {
        private readonly Mock<IClass600> aClass;

        public Test600()
        {
            this.aClass = new Mock<IClass600>();
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
