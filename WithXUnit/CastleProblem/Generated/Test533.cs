using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test533
    {
        private readonly Mock<IClass533> aClass;

        public Test533()
        {
            this.aClass = new Mock<IClass533>();
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
