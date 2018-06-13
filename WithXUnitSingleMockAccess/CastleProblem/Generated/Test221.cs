using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test221
    {
        private readonly Mock<IClass221> aClass;

        public Test221()
        {
            this.aClass = new Mock<IClass221>();
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
