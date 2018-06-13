using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test44
    {
        private readonly Mock<IClass44> aClass;

        public Test44()
        {
            this.aClass = new Mock<IClass44>();
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
