using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test14
    {
        private readonly Mock<IClass14> aClass;

        public Test14()
        {
            this.aClass = new Mock<IClass14>();
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
