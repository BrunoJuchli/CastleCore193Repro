using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test733
    {
        private readonly Mock<IClass733> aClass;

        public Test733()
        {
            this.aClass = new Mock<IClass733>();
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
