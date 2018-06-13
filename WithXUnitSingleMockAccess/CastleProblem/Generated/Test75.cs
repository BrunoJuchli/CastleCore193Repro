using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test75
    {
        private readonly Mock<IClass75> aClass;

        public Test75()
        {
            this.aClass = new Mock<IClass75>();
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
