using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test828
    {
        private readonly Mock<IClass828> aClass;

        public Test828()
        {
            this.aClass = new Mock<IClass828>();
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
