using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test561
    {
        private readonly Mock<IClass561> aClass;

        public Test561()
        {
            this.aClass = new Mock<IClass561>();
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
