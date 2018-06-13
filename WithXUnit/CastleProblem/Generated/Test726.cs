using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test726
    {
        private readonly Mock<IClass726> aClass;

        public Test726()
        {
            this.aClass = new Mock<IClass726>();
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
