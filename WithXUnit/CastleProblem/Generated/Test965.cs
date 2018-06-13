using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test965
    {
        private readonly Mock<IClass965> aClass;

        public Test965()
        {
            this.aClass = new Mock<IClass965>();
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
