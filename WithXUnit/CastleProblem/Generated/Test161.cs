using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test161
    {
        private readonly Mock<IClass161> aClass;

        public Test161()
        {
            this.aClass = new Mock<IClass161>();
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
