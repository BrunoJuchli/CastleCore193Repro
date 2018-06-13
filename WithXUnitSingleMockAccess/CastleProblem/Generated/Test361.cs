using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test361
    {
        private readonly Mock<IClass361> aClass;

        public Test361()
        {
            this.aClass = new Mock<IClass361>();
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
