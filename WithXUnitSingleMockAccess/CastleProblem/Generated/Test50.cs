using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test50
    {
        private readonly Mock<IClass50> aClass;

        public Test50()
        {
            this.aClass = new Mock<IClass50>();
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
