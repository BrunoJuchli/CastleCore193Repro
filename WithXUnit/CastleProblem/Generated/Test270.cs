using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test270
    {
        private readonly Mock<IClass270> aClass;

        public Test270()
        {
            this.aClass = new Mock<IClass270>();
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
