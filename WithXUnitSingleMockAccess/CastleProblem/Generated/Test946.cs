using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test946
    {
        private readonly Mock<IClass946> aClass;

        public Test946()
        {
            this.aClass = new Mock<IClass946>();
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
