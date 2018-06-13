using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test661
    {
        private readonly Mock<IClass661> aClass;

        public Test661()
        {
            this.aClass = new Mock<IClass661>();
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
