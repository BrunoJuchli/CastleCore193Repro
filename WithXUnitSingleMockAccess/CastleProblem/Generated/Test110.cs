using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test110
    {
        private readonly Mock<IClass110> aClass;

        public Test110()
        {
            this.aClass = new Mock<IClass110>();
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
