using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test679
    {
        private readonly Mock<IClass679> aClass;

        public Test679()
        {
            this.aClass = new Mock<IClass679>();
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
