using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test385
    {
        private readonly Mock<IClass385> aClass;

        public Test385()
        {
            this.aClass = new Mock<IClass385>();
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
