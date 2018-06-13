using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test251
    {
        private readonly Mock<IClass251> aClass;

        public Test251()
        {
            this.aClass = new Mock<IClass251>();
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
