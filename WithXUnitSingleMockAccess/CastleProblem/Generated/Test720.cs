using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test720
    {
        private readonly Mock<IClass720> aClass;

        public Test720()
        {
            this.aClass = new Mock<IClass720>();
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
