using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test418
    {
        private readonly Mock<IClass418> aClass;

        public Test418()
        {
            this.aClass = new Mock<IClass418>();
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
