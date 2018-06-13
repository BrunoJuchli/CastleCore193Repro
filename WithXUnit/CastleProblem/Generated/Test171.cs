using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test171
    {
        private readonly Mock<IClass171> aClass;

        public Test171()
        {
            this.aClass = new Mock<IClass171>();
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
