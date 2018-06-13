using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test557
    {
        private readonly Mock<IClass557> aClass;

        public Test557()
        {
            this.aClass = new Mock<IClass557>();
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
