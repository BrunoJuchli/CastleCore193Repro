using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test43
    {
        private readonly Mock<IClass43> aClass;

        public Test43()
        {
            this.aClass = new Mock<IClass43>();
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
