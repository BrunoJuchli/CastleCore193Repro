using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test111
    {
        private readonly Mock<IClass111> aClass;

        public Test111()
        {
            this.aClass = new Mock<IClass111>();
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
