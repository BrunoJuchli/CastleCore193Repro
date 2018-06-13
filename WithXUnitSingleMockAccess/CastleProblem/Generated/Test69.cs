using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test69
    {
        private readonly Mock<IClass69> aClass;

        public Test69()
        {
            this.aClass = new Mock<IClass69>();
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
