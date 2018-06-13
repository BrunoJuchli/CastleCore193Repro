using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test497
    {
        private readonly Mock<IClass497> aClass;

        public Test497()
        {
            this.aClass = new Mock<IClass497>();
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
