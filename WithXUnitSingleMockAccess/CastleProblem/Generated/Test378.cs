using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test378
    {
        private readonly Mock<IClass378> aClass;

        public Test378()
        {
            this.aClass = new Mock<IClass378>();
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
