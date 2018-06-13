using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test592
    {
        private readonly Mock<IClass592> aClass;

        public Test592()
        {
            this.aClass = new Mock<IClass592>();
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
