using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test668
    {
        private readonly Mock<IClass668> aClass;

        public Test668()
        {
            this.aClass = new Mock<IClass668>();
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
