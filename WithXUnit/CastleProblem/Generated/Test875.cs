using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test875
    {
        private readonly Mock<IClass875> aClass;

        public Test875()
        {
            this.aClass = new Mock<IClass875>();
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
