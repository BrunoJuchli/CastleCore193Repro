using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test654
    {
        private readonly Mock<IClass654> aClass;

        public Test654()
        {
            this.aClass = new Mock<IClass654>();
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
