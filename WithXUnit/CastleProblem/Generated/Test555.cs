using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test555
    {
        private readonly Mock<IClass555> aClass;

        public Test555()
        {
            this.aClass = new Mock<IClass555>();
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
