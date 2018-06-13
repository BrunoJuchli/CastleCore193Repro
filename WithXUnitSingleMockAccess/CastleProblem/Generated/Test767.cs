using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test767
    {
        private readonly Mock<IClass767> aClass;

        public Test767()
        {
            this.aClass = new Mock<IClass767>();
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
