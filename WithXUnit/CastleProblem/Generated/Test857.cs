using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test857
    {
        private readonly Mock<IClass857> aClass;

        public Test857()
        {
            this.aClass = new Mock<IClass857>();
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
