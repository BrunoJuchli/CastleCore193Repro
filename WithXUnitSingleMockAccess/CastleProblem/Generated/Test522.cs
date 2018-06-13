using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test522
    {
        private readonly Mock<IClass522> aClass;

        public Test522()
        {
            this.aClass = new Mock<IClass522>();
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
