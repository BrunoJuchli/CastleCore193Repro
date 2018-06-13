using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test700
    {
        private readonly Mock<IClass700> aClass;

        public Test700()
        {
            this.aClass = new Mock<IClass700>();
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
