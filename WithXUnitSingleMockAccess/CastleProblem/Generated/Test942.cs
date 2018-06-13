using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test942
    {
        private readonly Mock<IClass942> aClass;

        public Test942()
        {
            this.aClass = new Mock<IClass942>();
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
