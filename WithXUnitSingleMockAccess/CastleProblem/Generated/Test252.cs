using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test252
    {
        private readonly Mock<IClass252> aClass;

        public Test252()
        {
            this.aClass = new Mock<IClass252>();
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
