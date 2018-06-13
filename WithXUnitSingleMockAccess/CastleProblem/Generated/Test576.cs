using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test576
    {
        private readonly Mock<IClass576> aClass;

        public Test576()
        {
            this.aClass = new Mock<IClass576>();
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
