using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test873
    {
        private readonly Mock<IClass873> aClass;

        public Test873()
        {
            this.aClass = new Mock<IClass873>();
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
