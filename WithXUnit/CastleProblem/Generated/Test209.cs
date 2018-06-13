using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test209
    {
        private readonly Mock<IClass209> aClass;

        public Test209()
        {
            this.aClass = new Mock<IClass209>();
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
