using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test217
    {
        private readonly Mock<IClass217> aClass;

        public Test217()
        {
            this.aClass = new Mock<IClass217>();
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
