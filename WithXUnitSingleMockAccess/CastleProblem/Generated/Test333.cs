using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test333
    {
        private readonly Mock<IClass333> aClass;

        public Test333()
        {
            this.aClass = new Mock<IClass333>();
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
