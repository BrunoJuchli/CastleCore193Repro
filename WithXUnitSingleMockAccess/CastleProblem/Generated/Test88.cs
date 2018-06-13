using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test88
    {
        private readonly Mock<IClass88> aClass;

        public Test88()
        {
            this.aClass = new Mock<IClass88>();
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
