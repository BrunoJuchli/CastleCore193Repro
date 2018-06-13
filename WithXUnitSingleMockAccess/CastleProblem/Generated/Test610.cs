using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test610
    {
        private readonly Mock<IClass610> aClass;

        public Test610()
        {
            this.aClass = new Mock<IClass610>();
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
