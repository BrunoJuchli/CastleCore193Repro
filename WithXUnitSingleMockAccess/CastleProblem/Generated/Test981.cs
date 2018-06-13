using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test981
    {
        private readonly Mock<IClass981> aClass;

        public Test981()
        {
            this.aClass = new Mock<IClass981>();
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
