using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test673
    {
        private readonly Mock<IClass673> aClass;

        public Test673()
        {
            this.aClass = new Mock<IClass673>();
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
