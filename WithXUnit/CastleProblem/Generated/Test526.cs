using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test526
    {
        private readonly Mock<IClass526> aClass;

        public Test526()
        {
            this.aClass = new Mock<IClass526>();
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
