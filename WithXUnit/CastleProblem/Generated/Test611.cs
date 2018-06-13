using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test611
    {
        private readonly Mock<IClass611> aClass;

        public Test611()
        {
            this.aClass = new Mock<IClass611>();
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
