using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test663
    {
        private readonly Mock<IClass663> aClass;

        public Test663()
        {
            this.aClass = new Mock<IClass663>();
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
