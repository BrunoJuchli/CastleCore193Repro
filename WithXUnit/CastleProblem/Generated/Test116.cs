using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test116
    {
        private readonly Mock<IClass116> aClass;

        public Test116()
        {
            this.aClass = new Mock<IClass116>();
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
