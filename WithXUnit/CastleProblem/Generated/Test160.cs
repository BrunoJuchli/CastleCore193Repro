using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test160
    {
        private readonly Mock<IClass160> aClass;

        public Test160()
        {
            this.aClass = new Mock<IClass160>();
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
