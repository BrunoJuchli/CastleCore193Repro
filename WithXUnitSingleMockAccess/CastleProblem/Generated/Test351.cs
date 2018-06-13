using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test351
    {
        private readonly Mock<IClass351> aClass;

        public Test351()
        {
            this.aClass = new Mock<IClass351>();
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
