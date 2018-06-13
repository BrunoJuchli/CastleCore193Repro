using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test442
    {
        private readonly Mock<IClass442> aClass;

        public Test442()
        {
            this.aClass = new Mock<IClass442>();
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
