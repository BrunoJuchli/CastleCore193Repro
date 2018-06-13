using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test658
    {
        private readonly Mock<IClass658> aClass;

        public Test658()
        {
            this.aClass = new Mock<IClass658>();
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
