using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test670
    {
        private readonly Mock<IClass670> aClass;

        public Test670()
        {
            this.aClass = new Mock<IClass670>();
        }

        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void DoSomething(bool value)
        {
            this.aClass.Setup(x => x.DoSomething()).Returns(value);

            Assert.Equal(this.aClass.Object.DoSomething(), value);
        }
    }
}
