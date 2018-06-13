using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test878
    {
        private readonly Mock<IClass878> aClass;

        public Test878()
        {
            this.aClass = new Mock<IClass878>();
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
