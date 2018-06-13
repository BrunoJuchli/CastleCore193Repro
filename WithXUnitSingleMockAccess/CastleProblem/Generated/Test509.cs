using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test509
    {
        private readonly Mock<IClass509> aClass;

        public Test509()
        {
            this.aClass = new Mock<IClass509>();
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
