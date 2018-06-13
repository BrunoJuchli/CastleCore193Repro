using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test694
    {
        private readonly Mock<IClass694> aClass;

        public Test694()
        {
            this.aClass = new Mock<IClass694>();
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
