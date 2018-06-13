using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test357
    {
        private readonly Mock<IClass357> aClass;

        public Test357()
        {
            this.aClass = new Mock<IClass357>();
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
