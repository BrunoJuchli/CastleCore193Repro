using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test52
    {
        private readonly Mock<IClass52> aClass;

        public Test52()
        {
            this.aClass = new Mock<IClass52>();
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
