using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test821
    {
        private readonly Mock<IClass821> aClass;

        public Test821()
        {
            this.aClass = new Mock<IClass821>();
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
