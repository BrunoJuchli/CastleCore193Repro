using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test404
    {
        private readonly Mock<IClass404> aClass;

        public Test404()
        {
            this.aClass = new Mock<IClass404>();
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
