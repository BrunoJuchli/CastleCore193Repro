using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test422
    {
        private readonly Mock<IClass422> aClass;

        public Test422()
        {
            this.aClass = new Mock<IClass422>();
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
