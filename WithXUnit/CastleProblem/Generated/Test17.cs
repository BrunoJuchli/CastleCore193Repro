using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test17
    {
        private readonly Mock<IClass17> aClass;

        public Test17()
        {
            this.aClass = new Mock<IClass17>();
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
