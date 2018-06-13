using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test61
    {
        private readonly Mock<IClass61> aClass;

        public Test61()
        {
            this.aClass = new Mock<IClass61>();
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
