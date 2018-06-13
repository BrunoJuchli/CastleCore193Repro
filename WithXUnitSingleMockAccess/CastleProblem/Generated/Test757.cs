using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test757
    {
        private readonly Mock<IClass757> aClass;

        public Test757()
        {
            this.aClass = new Mock<IClass757>();
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
