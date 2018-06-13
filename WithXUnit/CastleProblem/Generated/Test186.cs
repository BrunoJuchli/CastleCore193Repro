using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test186
    {
        private readonly Mock<IClass186> aClass;

        public Test186()
        {
            this.aClass = new Mock<IClass186>();
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
