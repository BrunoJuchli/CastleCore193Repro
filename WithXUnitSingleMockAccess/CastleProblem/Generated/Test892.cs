using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test892
    {
        private readonly Mock<IClass892> aClass;

        public Test892()
        {
            this.aClass = new Mock<IClass892>();
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
