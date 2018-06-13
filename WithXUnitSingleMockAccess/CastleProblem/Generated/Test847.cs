using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test847
    {
        private readonly Mock<IClass847> aClass;

        public Test847()
        {
            this.aClass = new Mock<IClass847>();
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
