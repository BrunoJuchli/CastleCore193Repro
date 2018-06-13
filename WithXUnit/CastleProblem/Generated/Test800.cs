using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test800
    {
        private readonly Mock<IClass800> aClass;

        public Test800()
        {
            this.aClass = new Mock<IClass800>();
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
