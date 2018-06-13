using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test705
    {
        private readonly Mock<IClass705> aClass;

        public Test705()
        {
            this.aClass = new Mock<IClass705>();
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
