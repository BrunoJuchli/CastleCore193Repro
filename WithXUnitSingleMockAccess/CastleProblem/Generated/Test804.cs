using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test804
    {
        private readonly Mock<IClass804> aClass;

        public Test804()
        {
            this.aClass = new Mock<IClass804>();
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
