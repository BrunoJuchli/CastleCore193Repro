using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test189
    {
        private readonly Mock<IClass189> aClass;

        public Test189()
        {
            this.aClass = new Mock<IClass189>();
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
