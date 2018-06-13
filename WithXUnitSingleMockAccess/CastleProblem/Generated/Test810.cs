using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test810
    {
        private readonly Mock<IClass810> aClass;

        public Test810()
        {
            this.aClass = new Mock<IClass810>();
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
