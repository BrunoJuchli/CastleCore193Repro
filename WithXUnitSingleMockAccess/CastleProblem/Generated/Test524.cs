using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test524
    {
        private readonly Mock<IClass524> aClass;

        public Test524()
        {
            this.aClass = new Mock<IClass524>();
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
