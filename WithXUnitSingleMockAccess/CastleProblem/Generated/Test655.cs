using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test655
    {
        private readonly Mock<IClass655> aClass;

        public Test655()
        {
            this.aClass = new Mock<IClass655>();
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
