using System.Windows.Documents;

namespace MarkupChain.WPF
{
    public static partial class FlowDocumentScrollViewerExtensions
    {
        public static T ZoomIncrement<T>(this T flowDoc, double zoomIncrement) where T : FlowDocumentScrollViewer
        {
            flowDoc.SetValue (FlowDocumentScrollViewer.ZoomIncrementProperty, zoomIncrement);

            return flowDoc;
        }
        public static T VerticalScrollBarVisibility<T>(this T flowDoc, ScrollBarVisibility verticalScrollBarVisibility) where T : FlowDocumentScrollViewer
        {
            flowDoc.SetValue (FlowDocumentScrollViewer.VerticalScrollBarVisibilityProperty, verticalScrollBarVisibility);

            return flowDoc;
        }
        public static T SelectionOpacity<T>(this T flowDoc, double selectionOpacity) where T : FlowDocumentScrollViewer
        {
            flowDoc.SetValue (FlowDocumentScrollViewer.SelectionOpacityProperty, selectionOpacity);

            return flowDoc;
        }
        public static T SelectionBrush<T>(this T flowDoc, Brush selectionBrush) where T : FlowDocumentScrollViewer
        {
            flowDoc.SetValue (FlowDocumentScrollViewer.SelectionBrushProperty, selectionBrush);

            return flowDoc;
        }
        public static T MinZoom<T>(this T flowDoc, double minZoom) where T : FlowDocumentScrollViewer
        {
            flowDoc.SetValue (FlowDocumentScrollViewer.MinZoomProperty, minZoom);

            return flowDoc;
        }
        public static T Zoom<T>(this T flowDoc, double canDecreaseZoom) where T : FlowDocumentScrollViewer
        {
            flowDoc.SetValue (FlowDocumentScrollViewer.ZoomProperty, canDecreaseZoom);

            return flowDoc;
        }
        public static T IsSelectionEnabled<T>(this T flowDoc, bool isSelectionEnabled) where T : FlowDocumentScrollViewer
        {
            flowDoc.SetValue (FlowDocumentScrollViewer.IsSelectionEnabledProperty, isSelectionEnabled);

            return flowDoc;
        }
        public static T IsInactiveSelectionHighlightEnabled<T>(this T flowDoc, bool isInactiveSelectionHighlightEnabled) where T : FlowDocumentScrollViewer
        {
            flowDoc.SetValue (FlowDocumentScrollViewer.IsInactiveSelectionHighlightEnabledProperty, isInactiveSelectionHighlightEnabled);

            return flowDoc;
        }
        public static T HorizontalScrollBarVisibility<T>(this T flowDoc, ScrollBarVisibility horizontalScrollBarVisibility) where T : FlowDocumentScrollViewer
        {
            flowDoc.SetValue (FlowDocumentScrollViewer.HorizontalScrollBarVisibilityProperty, horizontalScrollBarVisibility);

            return flowDoc;
        }
        public static T Document<T>(this T flowDoc, FlowDocument document) where T : FlowDocumentScrollViewer
        {
            flowDoc.SetValue (FlowDocumentScrollViewer.DocumentProperty, document);

            return flowDoc;
        }
        public static T IsToolBarVisible<T>(this T flowDoc, bool isToolBarVisible) where T : FlowDocumentScrollViewer
        {
            flowDoc.SetValue (FlowDocumentScrollViewer.IsToolBarVisibleProperty, isToolBarVisible);

            return flowDoc;
        }
    }
}
