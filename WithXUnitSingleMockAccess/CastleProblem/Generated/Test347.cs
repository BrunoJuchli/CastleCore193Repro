using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test347
    {
        private readonly Mock<IClass347> aClass;

        public Test347()
        {
            this.aClass = new Mock<IClass347>();
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
