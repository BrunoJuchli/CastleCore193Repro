using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test207
    {
        private readonly Mock<IClass207> aClass;

        public Test207()
        {
            this.aClass = new Mock<IClass207>();
        }

        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void DoSomething(bool value)
        {
            this.aClass.Setup(x => x.DoSomething()).Returns(value);

            Assert.Equal(this.aClass.Object.DoSomething(), value);
        }
    }
}
