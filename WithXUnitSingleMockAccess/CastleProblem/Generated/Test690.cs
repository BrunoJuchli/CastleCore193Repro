using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test690
    {
        private readonly Mock<IClass690> aClass;

        public Test690()
        {
            this.aClass = new Mock<IClass690>();
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
