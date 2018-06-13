using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test248
    {
        private readonly Mock<IClass248> aClass;

        public Test248()
        {
            this.aClass = new Mock<IClass248>();
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
