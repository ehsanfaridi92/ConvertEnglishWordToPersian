namespace ConvertEnglishWordToPersian
{
    public static class Utilities
    {
        public static  string EnglishToPersian(this string str)
        {
            var newStr = "";
            for (var i = 0; i < str.Length; i++)
            {
                var keyword = str.Substring(i, 1);
                switch (keyword)
                {
                    //Common Characters
                    case " ":
                        newStr += " ";
                        break;
                    case ":":
                        newStr += ":";
                        break;
                    case "\"":
                        newStr += "\"";
                        break;
                    case "?":
                        newStr += "؟";
                        break;
                    case "؟":
                        newStr += "?";
                        break;
                    //English to Farsi

                    case "q":
                        newStr += "ض";
                        break;
                    case "w":
                        newStr += "ص";
                        break;
                    case "e":
                        newStr += "ث";
                        break;
                    case "r":
                        newStr += "ق";
                        break;
                    case "t":
                        newStr += "ف";
                        break;
                    case "y":
                        newStr += "غ";
                        break;
                    case "u":
                        newStr += "ع";
                        break;
                    case "i":
                        newStr += "ه";
                        break;
                    case "o":
                        newStr += "خ";
                        break;
                    case "p":
                        newStr += "ح";
                        break;
                    case "a":
                        newStr += "ش";
                        break;
                    case "s":
                        newStr += "س";
                        break;
                    case "d":
                        newStr += "ی";
                        break;
                    case "f":
                        newStr += "ب";
                        break;
                    case "g":
                        newStr += "ل";
                        break;
                    case "h":
                        newStr += "ا";
                        break;
                    case "j":
                        newStr += "ت";
                        break;
                    case "k":
                        newStr += "ن";
                        break;
                    case "l":
                        newStr += "م";
                        break;
                    case ";":
                        newStr += "ک";
                        break;
                    case "'":
                        newStr += 'گ';
                        break;
                    case "z":
                        newStr += "ظ";
                        break;
                    case "x":
                        newStr += "ط";
                        break;
                    case "c":
                        newStr += "ز";
                        break;
                    case "v":
                        newStr += "ر";
                        break;
                    case "b":
                        newStr += "ذ";
                        break;
                    case "n":
                        newStr += "د";
                        break;
                    case "m":
                        newStr += "ئ";
                        break;
                    case ",":
                        newStr += "و";
                        break;
                    case "Q":
                        newStr += "ً";
                        break;
                    case "W":
                        newStr += "ٌ";
                        break;
                    case "E":
                        newStr += "ٍ";
                        break;
                    case "R":
                        newStr += "ريال";
                        break;
                    case "T":
                        newStr += "،";
                        break;
                    case "Y":
                        newStr += "؛";
                        break;
                    case "A":
                        newStr += "َ";
                        break;
                    case "S":
                        newStr += "ُ";
                        break;
                    case "D":
                        newStr += "ِ";
                        break;
                    case "M":
                        newStr += "ء";
                        break;
                    case "F":
                        newStr += "ّ";
                        break;
                    case "H":
                        newStr += "آ";
                        break;
                    case "J":
                        newStr += "ـ";
                        break;
                    case "K":
                        newStr += "»";
                        break;
                    case "L":
                        newStr += "«";
                        break;
                    case "Z":
                        newStr += "ؤ";
                        break;
                    case "C":
                        newStr += "ژ";
                        break;
                    case "":
                        newStr += "ژ";
                        break;
                    case "B":
                        newStr += "إ";
                        break;
                    case "N":
                        newStr += "أ";
                        break;
                    case "`":
                        newStr += "پ";
                        break;
                    case "]":
                        newStr += "چ";
                        break;
                    case "[":
                        newStr += "ج";
                        break;

                    default:
                        var res = keyword.Substring(i, 1);
                        newStr += res;
                        break;
                }

            }
            return newStr;
        }
    }
}
