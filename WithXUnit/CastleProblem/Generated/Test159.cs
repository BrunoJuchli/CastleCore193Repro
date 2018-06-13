using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test159
    {
        private readonly Mock<IClass159> aClass;

        public Test159()
        {
            this.aClass = new Mock<IClass159>();
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
