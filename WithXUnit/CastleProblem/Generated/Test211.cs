using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test211
    {
        private readonly Mock<IClass211> aClass;

        public Test211()
        {
            this.aClass = new Mock<IClass211>();
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
