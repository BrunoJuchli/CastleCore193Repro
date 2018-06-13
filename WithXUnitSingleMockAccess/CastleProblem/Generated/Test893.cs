using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test893
    {
        private readonly Mock<IClass893> aClass;

        public Test893()
        {
            this.aClass = new Mock<IClass893>();
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
