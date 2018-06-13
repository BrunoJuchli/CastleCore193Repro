using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test25
    {
        private readonly Mock<IClass25> aClass;

        public Test25()
        {
            this.aClass = new Mock<IClass25>();
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
