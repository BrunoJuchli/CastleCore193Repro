using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test815
    {
        private readonly Mock<IClass815> aClass;

        public Test815()
        {
            this.aClass = new Mock<IClass815>();
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
