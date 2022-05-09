using FluentAssertions;
using Xunit;

namespace ConvertEnglishWordToPersian.Unit.Tests
{
    public class ConvertEnglishWordToPersianTests
    {
        [Fact]
        public void english_message_must_be_convert_to_persian_correctly()
        {
            var englishWord = "sghl ]x,vd";
            var expectedPersianWord= "سلام چطوری";

            var correctWord = englishWord.EnglishToPersian();

            correctWord.Should().Be(expectedPersianWord);
        }
    }
}
