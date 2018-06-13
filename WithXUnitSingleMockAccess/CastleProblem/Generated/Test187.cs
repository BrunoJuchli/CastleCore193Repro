using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test187
    {
        private readonly Mock<IClass187> aClass;

        public Test187()
        {
            this.aClass = new Mock<IClass187>();
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
