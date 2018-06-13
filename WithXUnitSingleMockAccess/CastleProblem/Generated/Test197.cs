using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test197
    {
        private readonly Mock<IClass197> aClass;

        public Test197()
        {
            this.aClass = new Mock<IClass197>();
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
