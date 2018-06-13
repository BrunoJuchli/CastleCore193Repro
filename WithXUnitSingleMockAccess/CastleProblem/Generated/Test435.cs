using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test435
    {
        private readonly Mock<IClass435> aClass;

        public Test435()
        {
            this.aClass = new Mock<IClass435>();
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
