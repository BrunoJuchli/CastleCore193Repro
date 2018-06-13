using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test367
    {
        private readonly Mock<IClass367> aClass;

        public Test367()
        {
            this.aClass = new Mock<IClass367>();
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
