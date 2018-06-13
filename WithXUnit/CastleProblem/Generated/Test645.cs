using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test645
    {
        private readonly Mock<IClass645> aClass;

        public Test645()
        {
            this.aClass = new Mock<IClass645>();
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
