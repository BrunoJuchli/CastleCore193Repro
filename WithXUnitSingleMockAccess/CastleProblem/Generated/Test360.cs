using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test360
    {
        private readonly Mock<IClass360> aClass;

        public Test360()
        {
            this.aClass = new Mock<IClass360>();
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
