using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test98
    {
        private readonly Mock<IClass98> aClass;

        public Test98()
        {
            this.aClass = new Mock<IClass98>();
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
