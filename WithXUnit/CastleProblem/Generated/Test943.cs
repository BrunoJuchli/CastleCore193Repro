using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test943
    {
        private readonly Mock<IClass943> aClass;

        public Test943()
        {
            this.aClass = new Mock<IClass943>();
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
