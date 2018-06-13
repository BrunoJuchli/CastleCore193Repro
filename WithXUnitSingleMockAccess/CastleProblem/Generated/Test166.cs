using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test166
    {
        private readonly Mock<IClass166> aClass;

        public Test166()
        {
            this.aClass = new Mock<IClass166>();
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
