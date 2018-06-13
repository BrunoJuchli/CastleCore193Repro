using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test961
    {
        private readonly Mock<IClass961> aClass;

        public Test961()
        {
            this.aClass = new Mock<IClass961>();
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
