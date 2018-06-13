using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test579
    {
        private readonly Mock<IClass579> aClass;

        public Test579()
        {
            this.aClass = new Mock<IClass579>();
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
