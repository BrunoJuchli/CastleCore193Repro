using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test949
    {
        private readonly Mock<IClass949> aClass;

        public Test949()
        {
            this.aClass = new Mock<IClass949>();
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
