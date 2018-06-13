using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test169
    {
        private readonly Mock<IClass169> aClass;

        public Test169()
        {
            this.aClass = new Mock<IClass169>();
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
