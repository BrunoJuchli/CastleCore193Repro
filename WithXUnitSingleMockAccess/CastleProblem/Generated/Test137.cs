using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test137
    {
        private readonly Mock<IClass137> aClass;

        public Test137()
        {
            this.aClass = new Mock<IClass137>();
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
