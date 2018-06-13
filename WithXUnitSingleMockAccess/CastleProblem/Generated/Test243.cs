using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test243
    {
        private readonly Mock<IClass243> aClass;

        public Test243()
        {
            this.aClass = new Mock<IClass243>();
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
