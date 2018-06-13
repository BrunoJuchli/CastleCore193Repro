using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test960
    {
        private readonly Mock<IClass960> aClass;

        public Test960()
        {
            this.aClass = new Mock<IClass960>();
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
