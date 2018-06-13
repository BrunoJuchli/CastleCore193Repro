using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test22
    {
        private readonly Mock<IClass22> aClass;

        public Test22()
        {
            this.aClass = new Mock<IClass22>();
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
