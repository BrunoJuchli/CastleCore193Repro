using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test375
    {
        private readonly Mock<IClass375> aClass;

        public Test375()
        {
            this.aClass = new Mock<IClass375>();
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
