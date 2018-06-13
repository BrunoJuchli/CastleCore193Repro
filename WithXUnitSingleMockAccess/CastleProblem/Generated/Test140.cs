using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test140
    {
        private readonly Mock<IClass140> aClass;

        public Test140()
        {
            this.aClass = new Mock<IClass140>();
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
