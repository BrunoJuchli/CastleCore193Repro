using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test4
    {
        private readonly Mock<IClass4> aClass;

        public Test4()
        {
            this.aClass = new Mock<IClass4>();
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
