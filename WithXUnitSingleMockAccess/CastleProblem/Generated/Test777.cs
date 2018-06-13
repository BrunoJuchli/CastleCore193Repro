using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test777
    {
        private readonly Mock<IClass777> aClass;

        public Test777()
        {
            this.aClass = new Mock<IClass777>();
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
