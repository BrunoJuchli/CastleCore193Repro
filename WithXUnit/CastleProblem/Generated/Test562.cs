using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test562
    {
        private readonly Mock<IClass562> aClass;

        public Test562()
        {
            this.aClass = new Mock<IClass562>();
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
