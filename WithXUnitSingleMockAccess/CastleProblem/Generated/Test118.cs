using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test118
    {
        private readonly Mock<IClass118> aClass;

        public Test118()
        {
            this.aClass = new Mock<IClass118>();
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
