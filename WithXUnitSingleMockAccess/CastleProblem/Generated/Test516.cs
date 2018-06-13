using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test516
    {
        private readonly Mock<IClass516> aClass;

        public Test516()
        {
            this.aClass = new Mock<IClass516>();
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
