using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test455
    {
        private readonly Mock<IClass455> aClass;

        public Test455()
        {
            this.aClass = new Mock<IClass455>();
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
