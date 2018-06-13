using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test277
    {
        private readonly Mock<IClass277> aClass;

        public Test277()
        {
            this.aClass = new Mock<IClass277>();
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
