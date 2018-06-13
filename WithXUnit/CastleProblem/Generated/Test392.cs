using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test392
    {
        private readonly Mock<IClass392> aClass;

        public Test392()
        {
            this.aClass = new Mock<IClass392>();
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
