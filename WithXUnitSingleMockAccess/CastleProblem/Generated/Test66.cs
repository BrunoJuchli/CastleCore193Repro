using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test66
    {
        private readonly Mock<IClass66> aClass;

        public Test66()
        {
            this.aClass = new Mock<IClass66>();
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
