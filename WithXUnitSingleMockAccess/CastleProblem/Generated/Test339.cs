using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test339
    {
        private readonly Mock<IClass339> aClass;

        public Test339()
        {
            this.aClass = new Mock<IClass339>();
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
