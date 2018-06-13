using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test984
    {
        private readonly Mock<IClass984> aClass;

        public Test984()
        {
            this.aClass = new Mock<IClass984>();
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
