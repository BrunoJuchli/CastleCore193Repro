using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test486
    {
        private readonly Mock<IClass486> aClass;

        public Test486()
        {
            this.aClass = new Mock<IClass486>();
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
