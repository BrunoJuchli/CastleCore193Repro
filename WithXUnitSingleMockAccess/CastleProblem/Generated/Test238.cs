using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test238
    {
        private readonly Mock<IClass238> aClass;

        public Test238()
        {
            this.aClass = new Mock<IClass238>();
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
