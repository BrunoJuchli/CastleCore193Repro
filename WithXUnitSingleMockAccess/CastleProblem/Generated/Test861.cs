using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test861
    {
        private readonly Mock<IClass861> aClass;

        public Test861()
        {
            this.aClass = new Mock<IClass861>();
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
