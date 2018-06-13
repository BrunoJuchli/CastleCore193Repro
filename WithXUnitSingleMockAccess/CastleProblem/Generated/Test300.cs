using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test300
    {
        private readonly Mock<IClass300> aClass;

        public Test300()
        {
            this.aClass = new Mock<IClass300>();
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
