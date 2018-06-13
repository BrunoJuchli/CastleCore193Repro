using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test314
    {
        private readonly Mock<IClass314> aClass;

        public Test314()
        {
            this.aClass = new Mock<IClass314>();
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
