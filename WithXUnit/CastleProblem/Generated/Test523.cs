using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test523
    {
        private readonly Mock<IClass523> aClass;

        public Test523()
        {
            this.aClass = new Mock<IClass523>();
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
