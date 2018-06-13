using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test836
    {
        private readonly Mock<IClass836> aClass;

        public Test836()
        {
            this.aClass = new Mock<IClass836>();
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
