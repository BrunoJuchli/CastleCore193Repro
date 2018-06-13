using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test634
    {
        private readonly Mock<IClass634> aClass;

        public Test634()
        {
            this.aClass = new Mock<IClass634>();
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
