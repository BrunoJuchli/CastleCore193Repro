using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test15
    {
        private readonly Mock<IClass15> aClass;

        public Test15()
        {
            this.aClass = new Mock<IClass15>();
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
