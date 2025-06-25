using System.Windows.Documents;

namespace MarkupChain.WPF
{
    public static partial class FlowDocumentScrollViewerExtensions
    {
        public static T SelectionBrush<T>(this T flowDoc, Color selectionBrush) where T : FlowDocumentScrollViewer
        {
            return flowDoc.SelectionBrush (selectionBrush);
        }
        public static T SelectionBrush<T>(this T flowDoc, string selectionBrush) where T : FlowDocumentScrollViewer
        {
            return flowDoc.SelectionBrush (selectionBrush);
        }
    }
}
