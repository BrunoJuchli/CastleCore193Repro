using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test428
    {
        private readonly Mock<IClass428> aClass;

        public Test428()
        {
            this.aClass = new Mock<IClass428>();
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
