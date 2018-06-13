using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test16
    {
        private readonly Mock<IClass16> aClass;

        public Test16()
        {
            this.aClass = new Mock<IClass16>();
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
