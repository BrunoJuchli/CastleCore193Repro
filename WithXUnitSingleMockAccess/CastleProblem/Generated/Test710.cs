using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test710
    {
        private readonly Mock<IClass710> aClass;

        public Test710()
        {
            this.aClass = new Mock<IClass710>();
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
