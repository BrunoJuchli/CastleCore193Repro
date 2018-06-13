using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test883
    {
        private readonly Mock<IClass883> aClass;

        public Test883()
        {
            this.aClass = new Mock<IClass883>();
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
