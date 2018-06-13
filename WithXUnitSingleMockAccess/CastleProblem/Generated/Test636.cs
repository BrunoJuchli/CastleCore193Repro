using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test636
    {
        private readonly Mock<IClass636> aClass;

        public Test636()
        {
            this.aClass = new Mock<IClass636>();
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
