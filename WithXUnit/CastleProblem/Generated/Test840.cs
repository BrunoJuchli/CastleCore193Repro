using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test840
    {
        private readonly Mock<IClass840> aClass;

        public Test840()
        {
            this.aClass = new Mock<IClass840>();
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
