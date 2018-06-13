using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test995
    {
        private readonly Mock<IClass995> aClass;

        public Test995()
        {
            this.aClass = new Mock<IClass995>();
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
