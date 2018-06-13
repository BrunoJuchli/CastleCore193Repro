using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test770
    {
        private readonly Mock<IClass770> aClass;

        public Test770()
        {
            this.aClass = new Mock<IClass770>();
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
