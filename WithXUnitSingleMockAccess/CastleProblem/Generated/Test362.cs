using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test362
    {
        private readonly Mock<IClass362> aClass;

        public Test362()
        {
            this.aClass = new Mock<IClass362>();
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
