using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test734
    {
        private readonly Mock<IClass734> aClass;

        public Test734()
        {
            this.aClass = new Mock<IClass734>();
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
