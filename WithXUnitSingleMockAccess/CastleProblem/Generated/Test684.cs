using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test684
    {
        private readonly Mock<IClass684> aClass;

        public Test684()
        {
            this.aClass = new Mock<IClass684>();
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
