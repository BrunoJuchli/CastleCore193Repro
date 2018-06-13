using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test382
    {
        private readonly Mock<IClass382> aClass;

        public Test382()
        {
            this.aClass = new Mock<IClass382>();
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
