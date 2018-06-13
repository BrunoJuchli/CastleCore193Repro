using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test582
    {
        private readonly Mock<IClass582> aClass;

        public Test582()
        {
            this.aClass = new Mock<IClass582>();
        }

        [Theory]
        [InlineData(true)]
        public void DoSomething(bool value)
        {
            this.aClass.Setup(x => x.DoSomething()).Returns(value);

            Assert.Equal(this.aClass.Object.DoSomething(), value);
        }
    }
}
