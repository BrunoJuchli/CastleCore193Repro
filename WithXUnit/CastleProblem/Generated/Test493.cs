using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test493
    {
        private readonly Mock<IClass493> aClass;

        public Test493()
        {
            this.aClass = new Mock<IClass493>();
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
