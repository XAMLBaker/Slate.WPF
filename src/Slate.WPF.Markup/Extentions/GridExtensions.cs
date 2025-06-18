using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;

namespace Slate.WPF.Markup
{
    public static class GridExtensions
    {
        public static T Columns<T>(this T grd, params string[] columns) where T : Grid
        {
            foreach (var col in columns)
            {
                if (!TryParseGridLength (col, out var gridLength))
                {
                    Debug.WriteLine ($"⚠️ Columns: 잘못된 형식 \"{col}\" → GridLength.Auto로 대체됩니다.");
                    gridLength = GridLength.Auto;
                }

                grd.ColumnDefinitions.Add (new ColumnDefinition { Width = gridLength });
            }

            return grd;
        }

        public static T Columns<T>(this T grd, string columns) where T : Grid
        {
            return grd.Columns (columns
                .Split (',')                     // 콤마로 자르기
                .Select (s => s.Trim ())          // 앞뒤 공백 제거
                .ToArray ());
        }

        public static T Rows<T>(this T grd, string rows) where T : Grid
        {
            return grd.Rows (rows
                .Split (',')
                .Select (s => s.Trim ())
                .ToArray ());
        }

        public static T Rows<T>(this T grd, params string[] rows) where T : Grid
        {
            foreach (var row in rows)
            {
                if (!TryParseGridLength (row, out var gridLength))
                {
                    Debug.WriteLine ($"⚠️ Rows: 잘못된 형식 \"{row}\" → GridLength.Auto로 대체됩니다.");
                    gridLength = GridLength.Auto;
                }

                grd.RowDefinitions.Add (new RowDefinition { Height = gridLength });
            }

            return grd;
        }

        private static bool TryParseGridLength(string input, out GridLength length)
        {
            if (input.Equals ("Auto", StringComparison.OrdinalIgnoreCase))
            {
                length = GridLength.Auto;
                return true;
            }

            if (input.EndsWith ("*"))
            {
                var factorPart = input.TrimEnd ('*');
                double factor = 1;

                if (!string.IsNullOrWhiteSpace (factorPart))
                {
                    if (!double.TryParse (factorPart, out factor))
                    {
                        length = default;
                        return false;
                    }
                }

                length = new GridLength (factor, GridUnitType.Star);
                return true;
            }

            if (double.TryParse (input, out double pixels))
            {
                length = new GridLength (pixels, GridUnitType.Pixel);
                return true;
            }

            length = default;
            return false;
        }

        public static T AddChild<T>(this T grid, UIElement child, int row = 0, int column = 0) where T : Grid
        {
            Grid.SetRow (child, row);
            Grid.SetColumn (child, column);
            grid.Children.Add (child);
            return grid;
        }

        public static T AddChild<T>(this T grid, UIElement child, int row, int column, int rowSpan, int columnSpan) where T : Grid
        {
            Grid.SetRow (child, row);
            Grid.SetColumn (child, column);
            Grid.SetRowSpan (child, rowSpan);
            Grid.SetColumnSpan (child, columnSpan);
            grid.Children.Add (child);
            return grid;
        }
    }
}
