using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test937
    {
        private readonly Mock<IClass937> aClass;

        public Test937()
        {
            this.aClass = new Mock<IClass937>();
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
