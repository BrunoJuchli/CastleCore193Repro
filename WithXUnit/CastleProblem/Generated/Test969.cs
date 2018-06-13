using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test969
    {
        private readonly Mock<IClass969> aClass;

        public Test969()
        {
            this.aClass = new Mock<IClass969>();
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
