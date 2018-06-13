using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test955
    {
        private readonly Mock<IClass955> aClass;

        public Test955()
        {
            this.aClass = new Mock<IClass955>();
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
