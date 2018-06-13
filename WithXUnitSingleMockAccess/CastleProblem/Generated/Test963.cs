using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test963
    {
        private readonly Mock<IClass963> aClass;

        public Test963()
        {
            this.aClass = new Mock<IClass963>();
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
