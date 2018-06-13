using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test898
    {
        private readonly Mock<IClass898> aClass;

        public Test898()
        {
            this.aClass = new Mock<IClass898>();
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
