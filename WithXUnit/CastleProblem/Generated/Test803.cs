using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test803
    {
        private readonly Mock<IClass803> aClass;

        public Test803()
        {
            this.aClass = new Mock<IClass803>();
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
