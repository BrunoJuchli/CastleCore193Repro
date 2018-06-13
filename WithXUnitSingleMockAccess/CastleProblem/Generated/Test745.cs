using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test745
    {
        private readonly Mock<IClass745> aClass;

        public Test745()
        {
            this.aClass = new Mock<IClass745>();
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
