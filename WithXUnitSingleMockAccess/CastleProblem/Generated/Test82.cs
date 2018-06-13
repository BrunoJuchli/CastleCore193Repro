using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test82
    {
        private readonly Mock<IClass82> aClass;

        public Test82()
        {
            this.aClass = new Mock<IClass82>();
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
