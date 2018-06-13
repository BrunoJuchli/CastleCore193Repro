using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test318
    {
        private readonly Mock<IClass318> aClass;

        public Test318()
        {
            this.aClass = new Mock<IClass318>();
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
