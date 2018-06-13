using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test476
    {
        private readonly Mock<IClass476> aClass;

        public Test476()
        {
            this.aClass = new Mock<IClass476>();
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
