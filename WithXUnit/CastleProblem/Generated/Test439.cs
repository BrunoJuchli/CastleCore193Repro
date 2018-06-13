using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test439
    {
        private readonly Mock<IClass439> aClass;

        public Test439()
        {
            this.aClass = new Mock<IClass439>();
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
