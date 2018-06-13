using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test915
    {
        private readonly Mock<IClass915> aClass;

        public Test915()
        {
            this.aClass = new Mock<IClass915>();
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
