using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test982
    {
        private readonly Mock<IClass982> aClass;

        public Test982()
        {
            this.aClass = new Mock<IClass982>();
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
