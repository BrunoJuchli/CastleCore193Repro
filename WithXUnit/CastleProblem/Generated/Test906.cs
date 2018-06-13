using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test906
    {
        private readonly Mock<IClass906> aClass;

        public Test906()
        {
            this.aClass = new Mock<IClass906>();
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
