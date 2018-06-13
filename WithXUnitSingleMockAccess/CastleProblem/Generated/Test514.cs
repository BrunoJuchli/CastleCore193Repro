using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test514
    {
        private readonly Mock<IClass514> aClass;

        public Test514()
        {
            this.aClass = new Mock<IClass514>();
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
