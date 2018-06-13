using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test511
    {
        private readonly Mock<IClass511> aClass;

        public Test511()
        {
            this.aClass = new Mock<IClass511>();
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
