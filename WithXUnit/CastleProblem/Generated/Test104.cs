using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test104
    {
        private readonly Mock<IClass104> aClass;

        public Test104()
        {
            this.aClass = new Mock<IClass104>();
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
