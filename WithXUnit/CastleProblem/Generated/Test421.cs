using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test421
    {
        private readonly Mock<IClass421> aClass;

        public Test421()
        {
            this.aClass = new Mock<IClass421>();
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
