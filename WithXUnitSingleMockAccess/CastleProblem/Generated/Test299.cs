using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test299
    {
        private readonly Mock<IClass299> aClass;

        public Test299()
        {
            this.aClass = new Mock<IClass299>();
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
