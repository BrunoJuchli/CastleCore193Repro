using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test933
    {
        private readonly Mock<IClass933> aClass;

        public Test933()
        {
            this.aClass = new Mock<IClass933>();
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
