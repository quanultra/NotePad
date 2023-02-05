using System.Collections.Generic;
using Windows.UI.Text;

namespace NotePad.Utilities
{
    public static class FontUtility
    {
        private static readonly IReadOnlyCollection<string> DefaultFonts = new HashSet<string>(new[]
        {
            "Arial",
            "Arial Black",
            "Calibri",
            "Cambria",
            "Cambria Math",
            "Comic Sans MS",
            "Consolas",
            "Constantia",
            "Courier New",
            "Ebrima",
            "Franklin Gothic Medium",
            "Gabriola",
            "Gadugi",
            "Georgia",
            "Impact",
            "Javanese Text",
            "Leelawadee UI",
            "Lucida Console",
            "Lucida Sans Unicode",
            "Malgun Gothic",
            "Marlett",
            "Microsoft Himalaya",
            "Microsoft JhengHei",
            "Microsoft New Tai Lue",
            "Microsoft PhagsPa",
            "Microsoft Sans Serif",
            "Microsoft Tai Le",
            "Microsoft YaHei",
            "Microsoft Yi Baiti",
            "MingLiU-ExtB",
            "Mongolian Baiti",
            "MS Gothic",
            "MV Boli",
            "Myanmar Text",
            "Nirmala UI",
            "Palatino Linotype",
            "Segoe Print",
            "Segoe Script",
            "Segoe UI",
            "SimSun",
            "Sitka",
            "Sylfaen",
            "Tahoma",
            "Times New Roman",
            "Trebuchet MS",
            "Verdana",
            "Yu Gothic"
        });

        public static readonly Dictionary<string, FontStyle> PredefinedFontStyles = new Dictionary<string, FontStyle>()
        {
            {nameof(FontStyle.Normal), FontStyle.Normal },
            {nameof(FontStyle.Italic), FontStyle.Italic },
            {nameof(FontStyle.Oblique), FontStyle.Oblique },
        };

        public static readonly int[] PredefinedFontSizes =
        {
            8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 20, 22, 24, 26, 28, 36, 48, 72
        };
    }
}
