using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test443
    {
        private readonly Mock<IClass443> aClass;

        public Test443()
        {
            this.aClass = new Mock<IClass443>();
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
