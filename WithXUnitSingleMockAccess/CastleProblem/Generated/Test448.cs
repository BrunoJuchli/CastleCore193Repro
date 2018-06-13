using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test448
    {
        private readonly Mock<IClass448> aClass;

        public Test448()
        {
            this.aClass = new Mock<IClass448>();
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
