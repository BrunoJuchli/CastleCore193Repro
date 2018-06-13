using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test222
    {
        private readonly Mock<IClass222> aClass;

        public Test222()
        {
            this.aClass = new Mock<IClass222>();
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
