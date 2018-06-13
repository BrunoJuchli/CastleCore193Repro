using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test990
    {
        private readonly Mock<IClass990> aClass;

        public Test990()
        {
            this.aClass = new Mock<IClass990>();
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
