using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test987
    {
        private readonly Mock<IClass987> aClass;

        public Test987()
        {
            this.aClass = new Mock<IClass987>();
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
