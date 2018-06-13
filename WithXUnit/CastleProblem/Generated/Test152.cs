using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test152
    {
        private readonly Mock<IClass152> aClass;

        public Test152()
        {
            this.aClass = new Mock<IClass152>();
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
