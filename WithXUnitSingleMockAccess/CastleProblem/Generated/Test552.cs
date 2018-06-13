using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test552
    {
        private readonly Mock<IClass552> aClass;

        public Test552()
        {
            this.aClass = new Mock<IClass552>();
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
