using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test814
    {
        private readonly Mock<IClass814> aClass;

        public Test814()
        {
            this.aClass = new Mock<IClass814>();
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
