using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test141
    {
        private readonly Mock<IClass141> aClass;

        public Test141()
        {
            this.aClass = new Mock<IClass141>();
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
