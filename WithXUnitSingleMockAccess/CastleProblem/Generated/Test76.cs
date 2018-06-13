using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test76
    {
        private readonly Mock<IClass76> aClass;

        public Test76()
        {
            this.aClass = new Mock<IClass76>();
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
