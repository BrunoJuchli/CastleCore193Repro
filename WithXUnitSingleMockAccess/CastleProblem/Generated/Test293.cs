using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test293
    {
        private readonly Mock<IClass293> aClass;

        public Test293()
        {
            this.aClass = new Mock<IClass293>();
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
