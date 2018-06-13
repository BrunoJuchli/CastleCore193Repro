using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test85
    {
        private readonly Mock<IClass85> aClass;

        public Test85()
        {
            this.aClass = new Mock<IClass85>();
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
