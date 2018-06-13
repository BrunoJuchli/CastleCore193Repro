using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test890
    {
        private readonly Mock<IClass890> aClass;

        public Test890()
        {
            this.aClass = new Mock<IClass890>();
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
