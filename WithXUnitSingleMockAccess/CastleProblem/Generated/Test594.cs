using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test594
    {
        private readonly Mock<IClass594> aClass;

        public Test594()
        {
            this.aClass = new Mock<IClass594>();
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
