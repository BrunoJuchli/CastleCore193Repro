using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test450
    {
        private readonly Mock<IClass450> aClass;

        public Test450()
        {
            this.aClass = new Mock<IClass450>();
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
