using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test38
    {
        private readonly Mock<IClass38> aClass;

        public Test38()
        {
            this.aClass = new Mock<IClass38>();
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
