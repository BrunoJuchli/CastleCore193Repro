using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test548
    {
        private readonly Mock<IClass548> aClass;

        public Test548()
        {
            this.aClass = new Mock<IClass548>();
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
