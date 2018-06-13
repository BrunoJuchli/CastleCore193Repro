using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test223
    {
        private readonly Mock<IClass223> aClass;

        public Test223()
        {
            this.aClass = new Mock<IClass223>();
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
