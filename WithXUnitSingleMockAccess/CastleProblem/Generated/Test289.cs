using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test289
    {
        private readonly Mock<IClass289> aClass;

        public Test289()
        {
            this.aClass = new Mock<IClass289>();
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
