using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test885
    {
        private readonly Mock<IClass885> aClass;

        public Test885()
        {
            this.aClass = new Mock<IClass885>();
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
