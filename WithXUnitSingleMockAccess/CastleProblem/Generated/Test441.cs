using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test441
    {
        private readonly Mock<IClass441> aClass;

        public Test441()
        {
            this.aClass = new Mock<IClass441>();
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
