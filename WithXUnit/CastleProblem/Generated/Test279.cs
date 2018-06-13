using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test279
    {
        private readonly Mock<IClass279> aClass;

        public Test279()
        {
            this.aClass = new Mock<IClass279>();
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
