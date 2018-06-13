using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test731
    {
        private readonly Mock<IClass731> aClass;

        public Test731()
        {
            this.aClass = new Mock<IClass731>();
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
