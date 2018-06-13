using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test42
    {
        private readonly Mock<IClass42> aClass;

        public Test42()
        {
            this.aClass = new Mock<IClass42>();
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
