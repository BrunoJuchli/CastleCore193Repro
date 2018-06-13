using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test545
    {
        private readonly Mock<IClass545> aClass;

        public Test545()
        {
            this.aClass = new Mock<IClass545>();
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
