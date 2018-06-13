using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test261
    {
        private readonly Mock<IClass261> aClass;

        public Test261()
        {
            this.aClass = new Mock<IClass261>();
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
