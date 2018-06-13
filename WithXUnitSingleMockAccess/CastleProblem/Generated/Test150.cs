using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test150
    {
        private readonly Mock<IClass150> aClass;

        public Test150()
        {
            this.aClass = new Mock<IClass150>();
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
