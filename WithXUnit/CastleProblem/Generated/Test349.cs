using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test349
    {
        private readonly Mock<IClass349> aClass;

        public Test349()
        {
            this.aClass = new Mock<IClass349>();
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
