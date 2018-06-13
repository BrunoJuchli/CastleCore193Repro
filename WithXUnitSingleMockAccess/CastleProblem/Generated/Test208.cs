using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test208
    {
        private readonly Mock<IClass208> aClass;

        public Test208()
        {
            this.aClass = new Mock<IClass208>();
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
