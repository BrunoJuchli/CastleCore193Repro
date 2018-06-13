using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test762
    {
        private readonly Mock<IClass762> aClass;

        public Test762()
        {
            this.aClass = new Mock<IClass762>();
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
