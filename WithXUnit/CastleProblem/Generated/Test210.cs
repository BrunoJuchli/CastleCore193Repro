using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test210
    {
        private readonly Mock<IClass210> aClass;

        public Test210()
        {
            this.aClass = new Mock<IClass210>();
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
