using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test414
    {
        private readonly Mock<IClass414> aClass;

        public Test414()
        {
            this.aClass = new Mock<IClass414>();
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
