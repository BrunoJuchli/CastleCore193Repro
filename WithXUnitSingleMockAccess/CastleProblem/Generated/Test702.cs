using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test702
    {
        private readonly Mock<IClass702> aClass;

        public Test702()
        {
            this.aClass = new Mock<IClass702>();
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
