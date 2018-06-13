using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test797
    {
        private readonly Mock<IClass797> aClass;

        public Test797()
        {
            this.aClass = new Mock<IClass797>();
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
