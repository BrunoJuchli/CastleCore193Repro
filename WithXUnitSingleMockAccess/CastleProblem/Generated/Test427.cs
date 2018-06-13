using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test427
    {
        private readonly Mock<IClass427> aClass;

        public Test427()
        {
            this.aClass = new Mock<IClass427>();
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
