using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test798
    {
        private readonly Mock<IClass798> aClass;

        public Test798()
        {
            this.aClass = new Mock<IClass798>();
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
