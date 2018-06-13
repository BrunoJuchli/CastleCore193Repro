using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test165
    {
        private readonly Mock<IClass165> aClass;

        public Test165()
        {
            this.aClass = new Mock<IClass165>();
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
