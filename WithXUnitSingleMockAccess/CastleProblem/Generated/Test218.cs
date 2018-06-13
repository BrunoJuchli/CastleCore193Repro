using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test218
    {
        private readonly Mock<IClass218> aClass;

        public Test218()
        {
            this.aClass = new Mock<IClass218>();
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
