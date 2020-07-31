using System.Windows.Controls;
using System.Windows.Media;

namespace System.Windows
{
    public static class TextBlockExtensions
    {
        public static TextBlock Text(this TextBlock target, string text)
        {
            target.Text = text;
            return target;
        }

        public static TextBlock LineHeight(this TextBlock target, double height)
        {
            target.LineHeight = height;
            return target;
        }

        public static TextBlock FontStyle(this TextBlock target, FontStyle style)
        {
            target.FontStyle = style;
            return target;
        }

        public static TextBlock FontStyleNormal(this TextBlock target) => target.FontStyle(FontStyles.Normal);

        public static TextBlock FontStyleItalic(this TextBlock target) => target.FontStyle(FontStyles.Italic);

        public static TextBlock FontStyleOblique(this TextBlock target) => target.FontStyle(FontStyles.Oblique);

        public static TextBlock FontWeight(this TextBlock target, FontWeight weight)
        {
            target.FontWeight = weight;
            return target;
        }

        public static TextBlock FontWeightBlack(this TextBlock target) => target.FontWeight(FontWeights.Black);

        public static TextBlock FontWeightBold(this TextBlock target) => target.FontWeight(FontWeights.Bold);

        public static TextBlock FontWeightDemiBold(this TextBlock target) => target.FontWeight(FontWeights.DemiBold);

        public static TextBlock FontWeightExtraBlack(this TextBlock target) => target.FontWeight(FontWeights.ExtraBlack);

        public static TextBlock FontWeightExtraBold(this TextBlock target) => target.FontWeight(FontWeights.ExtraBold);

        public static TextBlock FontWeightExtraLight(this TextBlock target) => target.FontWeight(FontWeights.ExtraLight);

        public static TextBlock FontWeightHeavy(this TextBlock target) => target.FontWeight(FontWeights.Heavy);

        public static TextBlock FontWeightLight(this TextBlock target) => target.FontWeight(FontWeights.Light);

        public static TextBlock FontWeightMedium(this TextBlock target) => target.FontWeight(FontWeights.Medium);

        public static TextBlock FontWeightNormal(this TextBlock target) => target.FontWeight(FontWeights.Normal);

        public static TextBlock FontWeightRegular(this TextBlock target) => target.FontWeight(FontWeights.Regular);

        public static TextBlock FontWeightSemiBold(this TextBlock target) => target.FontWeight(FontWeights.SemiBold);

        public static TextBlock FontWeightThin(this TextBlock target) => target.FontWeight(FontWeights.Thin);

        public static TextBlock FontWeightUltraBlack(this TextBlock target) => target.FontWeight(FontWeights.UltraBlack);

        public static TextBlock FontWeightUltraBold(this TextBlock target) => target.FontWeight(FontWeights.UltraBold);

        public static TextBlock FontWeightUltraLight(this TextBlock target) => target.FontWeight(FontWeights.UltraLight);

        public static TextBlock Foreground(this TextBlock target, Brush brush)
        {
            target.Foreground = brush;
            return target;
        }

        public static TextBlock FontSize(this TextBlock target, double size)
        {
            target.FontSize = size;
            return target;
        }

        public static TextBlock Font(this TextBlock target, string family)
        {
            target.FontFamily = new FontFamily(family);
            return target;
        }

        public static TextBlock Font(this TextBlock target, string family = null, double? size = null, FontStyle? style = null, FontWeight? weight = null)
        {
            if (!string.IsNullOrEmpty(family))
            {
                target.Font(family);
            }

            if (size.HasValue)
            {
                target.FontSize(size.Value);
            }

            if (style.HasValue)
            {
                target.FontStyle(style.Value);
            }

            if (weight.HasValue)
            {
                target.FontWeight(weight.Value);
            }

            return target;
        }
    }
}
