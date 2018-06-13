using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test844
    {
        private readonly Mock<IClass844> aClass;

        public Test844()
        {
            this.aClass = new Mock<IClass844>();
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
