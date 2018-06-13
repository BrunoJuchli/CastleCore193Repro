using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test245
    {
        private readonly Mock<IClass245> aClass;

        public Test245()
        {
            this.aClass = new Mock<IClass245>();
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
