using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test464
    {
        private readonly Mock<IClass464> aClass;

        public Test464()
        {
            this.aClass = new Mock<IClass464>();
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
