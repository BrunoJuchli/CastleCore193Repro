using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test424
    {
        private readonly Mock<IClass424> aClass;

        public Test424()
        {
            this.aClass = new Mock<IClass424>();
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
