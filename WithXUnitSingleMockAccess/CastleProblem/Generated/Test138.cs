using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test138
    {
        private readonly Mock<IClass138> aClass;

        public Test138()
        {
            this.aClass = new Mock<IClass138>();
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
