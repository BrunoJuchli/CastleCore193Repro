using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test713
    {
        private readonly Mock<IClass713> aClass;

        public Test713()
        {
            this.aClass = new Mock<IClass713>();
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
