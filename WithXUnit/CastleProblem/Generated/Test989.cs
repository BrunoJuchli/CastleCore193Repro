using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test989
    {
        private readonly Mock<IClass989> aClass;

        public Test989()
        {
            this.aClass = new Mock<IClass989>();
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
