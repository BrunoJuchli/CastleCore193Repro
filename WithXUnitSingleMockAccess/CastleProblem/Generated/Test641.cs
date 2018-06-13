using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test641
    {
        private readonly Mock<IClass641> aClass;

        public Test641()
        {
            this.aClass = new Mock<IClass641>();
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
