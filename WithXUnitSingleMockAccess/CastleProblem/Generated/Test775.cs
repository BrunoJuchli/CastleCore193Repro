using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test775
    {
        private readonly Mock<IClass775> aClass;

        public Test775()
        {
            this.aClass = new Mock<IClass775>();
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
