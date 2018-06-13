using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test831
    {
        private readonly Mock<IClass831> aClass;

        public Test831()
        {
            this.aClass = new Mock<IClass831>();
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
