using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test381
    {
        private readonly Mock<IClass381> aClass;

        public Test381()
        {
            this.aClass = new Mock<IClass381>();
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
