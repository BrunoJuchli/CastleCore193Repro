using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test540
    {
        private readonly Mock<IClass540> aClass;

        public Test540()
        {
            this.aClass = new Mock<IClass540>();
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
