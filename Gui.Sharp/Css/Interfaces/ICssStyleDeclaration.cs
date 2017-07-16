using AngleSharp.Attributes;
using AngleSharp.Css.Values;

namespace Gui.Sharp.Css.Interfaces
{
    [DomName("CSSStyleDeclaration")]
    public interface ICssStyleDeclaration
    {
        #region CSS Property Values

        /// <summary>
        /// Gets or sets the accelerator value.
        /// </summary>
        [DomName("accelerator")]
        string Accelerator { get; set; }

        /// <summary>
        /// Gets or sets the align-content value.
        /// </summary>
        [DomName("alignContent")]
        string AlignContent { get; set; }

        /// <summary>
        /// Gets or sets the align-items value.
        /// </summary>
        [DomName("alignItems")]
        string AlignItems { get; set; }

        /// <summary>
        /// Gets or sets the alignment-baseline value.
        /// </summary>
        [DomName("alignmentBaseline")]
        string AlignmentBaseline { get; set; }

        /// <summary>
        /// Gets or sets the align-self value.
        /// </summary>
        [DomName("alignSelf")]
        string AlignSelf { get; set; }

        /// <summary>
        /// Gets or sets the animation value.
        /// </summary>
        [DomName("animation")]
        string Animation { get; set; }

        /// <summary>
        /// Gets or sets the animation-delay value.
        /// </summary>
        [DomName("animationDelay")]
        string AnimationDelay { get; set; }

        /// <summary>
        /// Gets or sets the animation-direction value.
        /// </summary>
        [DomName("animationDirection")]
        string AnimationDirection { get; set; }

        /// <summary>
        /// Gets or sets the animation-duration value.
        /// </summary>
        [DomName("animationDuration")]
        string AnimationDuration { get; set; }

        /// <summary>
        /// Gets or sets the animation-fill-mode value.
        /// </summary>
        [DomName("animationFillMode")]
        string AnimationFillMode { get; set; }

        /// <summary>
        /// Gets or sets the animation-iteration-count value.
        /// </summary>
        [DomName("animationIterationCount")]
        string AnimationIterationCount { get; set; }

        /// <summary>
        /// Gets or sets the animation-name value.
        /// </summary>
        [DomName("animationName")]
        string AnimationName { get; set; }

        /// <summary>
        /// Gets or sets the animation-play-state value.
        /// </summary>
        [DomName("animationPlayState")]
        string AnimationPlayState { get; set; }

        /// <summary>
        /// Gets or sets the animation-timing-function value.
        /// </summary>
        [DomName("animationTimingFunction")]
        string AnimationTimingFunction { get; set; }

        /// <summary>
        /// Gets or sets the backface-visibility value.
        /// </summary>
        [DomName("backfaceVisibility")]
        string BackfaceVisibility { get; set; }

        /// <summary>
        /// Gets or sets the background value.
        /// </summary>
        [DomName("background")]
        string Background { get; set; }

        /// <summary>
        /// Gets or sets the background-attachment value.
        /// </summary>
        [DomName("backgroundAttachment")]
        string BackgroundAttachment { get; set; }

        /// <summary>
        /// Gets or sets the background-clip value.
        /// </summary>
        [DomName("backgroundClip")]
        string BackgroundClip { get; set; }

        /// <summary>
        /// Gets or sets the background-color value.
        /// </summary>
        [DomName("backgroundColor")]
        OpenTK.Color BackgroundColor { get; set; }

        /// <summary>
        /// Gets or sets the background-image value.
        /// </summary>
        [DomName("backgroundImage")]
        string BackgroundImage { get; set; }

        /// <summary>
        /// Gets or sets the background-origin value.
        /// </summary>
        [DomName("backgroundOrigin")]
        string BackgroundOrigin { get; set; }

        /// <summary>
        /// Gets or sets the background-position value.
        /// </summary>
        [DomName("backgroundPosition")]
        string BackgroundPosition { get; set; }

        /// <summary>
        /// Gets or sets the background-position-x value.
        /// </summary>
        [DomName("backgroundPositionX")]
        string BackgroundPositionX { get; set; }

        /// <summary>
        /// Gets or sets the background-position-y value.
        /// </summary>
        [DomName("backgroundPositionY")]
        string BackgroundPositionY { get; set; }

        /// <summary>
        /// Gets or sets the background-repeat value.
        /// </summary>
        [DomName("backgroundRepeat")]
        string BackgroundRepeat { get; set; }

        /// <summary>
        /// Gets or sets the background-size value.
        /// </summary>
        [DomName("backgroundSize")]
        string BackgroundSize { get; set; }

        /// <summary>
        /// Gets or sets the baseline-shift value.
        /// </summary>
        [DomName("baselineShift")]
        string BaselineShift { get; set; }

        /// <summary>
        /// Gets or sets the behavior value.
        /// </summary>
        [DomName("behavior")]
        string Behavior { get; set; }

        /// <summary>
        /// Gets or sets the border value.
        /// </summary>
        [DomName("border")]
        string Border { get; set; }
  
        /// <summary>
        /// Gets or sets the bottom value.
        /// </summary>
        [DomName("bottom")]
        string Bottom { get; set; }

        /// <summary>
        /// Gets or sets the border-bottom value.
        /// </summary>
        [DomName("borderBottom")]
        string BorderBottom { get; set; }

        /// <summary>
        /// Gets or sets the border-bottom-color value.
        /// </summary>
        [DomName("borderBottomColor")]
        string BorderBottomColor { get; set; }

        /// <summary>
        /// Gets or sets the border-bottom-left-radius value.
        /// </summary>
        [DomName("borderBottomLeftRadius")]
        string BorderBottomLeftRadius { get; set; }

        /// <summary>
        /// Gets or sets the border-bottom-right-radius value.
        /// </summary>
        [DomName("borderBottomRightRadius")]
        string BorderBottomRightRadius { get; set; }

        /// <summary>
        /// Gets or sets the border-bottom-style value.
        /// </summary>
        [DomName("borderBottomStyle")]
        string BorderBottomStyle { get; set; }

        /// <summary>
        /// Gets or sets the border-bottom-width value.
        /// </summary>
        [DomName("borderBottomWidth")]
        string BorderBottomWidth { get; set; }

        /// <summary>
        /// Gets or sets the border-collapse value.
        /// </summary>
        [DomName("borderCollapse")]
        string BorderCollapse { get; set; }

        /// <summary>
        /// Gets or sets the border-color value.
        /// </summary>
        [DomName("borderColor")]
        string BorderColor { get; set; }

        /// <summary>
        /// Gets or sets the border-image value.
        /// </summary>
        [DomName("borderImage")]
        string BorderImage { get; set; }

        /// <summary>
        /// Gets or sets the border-image-outset value.
        /// </summary>
        [DomName("borderImageOutset")]
        string BorderImageOutset { get; set; }

        /// <summary>
        /// Gets or sets the border-image-repeat value.
        /// </summary>
        [DomName("borderImageRepeat")]
        string BorderImageRepeat { get; set; }

        /// <summary>
        /// Gets or sets the border-image-slice value.
        /// </summary>
        [DomName("borderImageSlice")]
        string BorderImageSlice { get; set; }

        /// <summary>
        /// Gets or sets the border-image-source value.
        /// </summary>
        [DomName("borderImageSource")]
        string BorderImageSource { get; set; }

        /// <summary>
        /// Gets or sets the border-image-width value.
        /// </summary>
        [DomName("borderImageWidth")]
        string BorderImageWidth { get; set; }

        /// <summary>
        /// Gets or sets the border-left value.
        /// </summary>
        [DomName("borderLeft")]
        string BorderLeft { get; set; }

        /// <summary>
        /// Gets or sets the border-left-color value.
        /// </summary>
        [DomName("borderLeftColor")]
        string BorderLeftColor { get; set; }

        /// <summary>
        /// Gets or sets the border-left-style value.
        /// </summary>
        [DomName("borderLeftStyle")]
        string BorderLeftStyle { get; set; }

        /// <summary>
        /// Gets or sets the border-left-width value.
        /// </summary>
        [DomName("borderLeftWidth")]
        string BorderLeftWidth { get; set; }

        /// <summary>
        /// Gets or sets the border-radius value.
        /// </summary>
        [DomName("borderRadius")]
        string BorderRadius { get; set; }

        /// <summary>
        /// Gets or sets the border-right value.
        /// </summary>
        [DomName("borderRight")]
        string BorderRight { get; set; }

        /// <summary>
        /// Gets or sets the border-right-color value.
        /// </summary>
        [DomName("borderRightColor")]
        string BorderRightColor { get; set; }

        /// <summary>
        /// Gets or sets the border-right-style value.
        /// </summary>
        [DomName("borderRightStyle")]
        string BorderRightStyle { get; set; }

        /// <summary>
        /// Gets or sets the border-right-width value.
        /// </summary>
        [DomName("borderRightWidth")]
        string BorderRightWidth { get; set; }

        /// <summary>
        /// Gets or sets the border-spacing value.
        /// </summary>
        [DomName("borderSpacing")]
        string BorderSpacing { get; set; }

        /// <summary>
        /// Gets or sets the border-style value.
        /// </summary>
        [DomName("borderStyle")]
        string BorderStyle { get; set; }

        /// <summary>
        /// Gets or sets the border-top value.
        /// </summary>
        [DomName("borderTop")]
        string BorderTop { get; set; }

        /// <summary>
        /// Gets or sets the border-top-color value.
        /// </summary>
        [DomName("borderTopColor")]
        string BorderTopColor { get; set; }

        /// <summary>
        /// Gets or sets the border-top-left-radius value.
        /// </summary>
        [DomName("borderTopLeftRadius")]
        string BorderTopLeftRadius { get; set; }

        /// <summary>
        /// Gets or sets the border-top-right-radius value.
        /// </summary>
        [DomName("borderTopRightRadius")]
        string BorderTopRightRadius { get; set; }

        /// <summary>
        /// Gets or sets the border-top-style value.
        /// </summary>
        [DomName("borderTopStyle")]
        string BorderTopStyle { get; set; }

        /// <summary>
        /// Gets or sets the border-top-width value.
        /// </summary>
        [DomName("borderTopWidth")]
        string BorderTopWidth { get; set; }

        /// <summary>
        /// Gets or sets the border-width value.
        /// </summary>
        [DomName("borderWidth")]
        string BorderWidth { get; set; }

        /// <summary>
        /// Gets or sets the box-shadow value.
        /// </summary>
        [DomName("boxShadow")]
        string BoxShadow { get; set; }

        /// <summary>
        /// Gets or sets the box-sizing value.
        /// </summary>
        [DomName("boxSizing")]
        string BoxSizing { get; set; }

        /// <summary>
        /// Gets or sets the break-after value.
        /// </summary>
        [DomName("breakAfter")]
        string BreakAfter { get; set; }

        /// <summary>
        /// Gets or sets the break-before value.
        /// </summary>
        [DomName("breakBefore")]
        string BreakBefore { get; set; }

        /// <summary>
        /// Gets or sets the break-inside value.
        /// </summary>
        [DomName("breakInside")]
        string BreakInside { get; set; }

        /// <summary>
        /// Gets or sets the caption-side value.
        /// </summary>
        [DomName("captionSide")]
        string CaptionSide { get; set; }

        /// <summary>
        /// Gets or sets the clear value.
        /// </summary>
        [DomName("clear")]
        string Clear { get; set; }

        /// <summary>
        /// Gets or sets the clip value.
        /// </summary>
        [DomName("clip")]
        string Clip { get; set; }

        /// <summary>
        /// Gets or sets the clip-bottom value.
        /// </summary>
        [DomName("clipBottom")]
        string ClipBottom { get; set; }

        /// <summary>
        /// Gets or sets the clip-left value.
        /// </summary>
        [DomName("clipLeft")]
        string ClipLeft { get; set; }

        /// <summary>
        /// Gets or sets the clip-path value.
        /// </summary>
        [DomName("clipPath")]
        string ClipPath { get; set; }

        /// <summary>
        /// Gets or sets the clip-right value.
        /// </summary>
        [DomName("clipRight")]
        string ClipRight { get; set; }

        /// <summary>
        /// Gets or sets the clip-rule value.
        /// </summary>
        [DomName("clipRule")]
        string ClipRule { get; set; }

        /// <summary>
        /// Gets or sets the clip-top value.
        /// </summary>
        [DomName("clipTop")]
        string ClipTop { get; set; }

        /// <summary>
        /// Gets or sets the color value.
        /// </summary>
        [DomName("color")]
        OpenTK.Color Color { get; set; }

        /// <summary>
        /// Gets or sets the color-interpolation-filters value.
        /// </summary>
        [DomName("colorInterpolationFilters")]
        string ColorInterpolationFilters { get; set; }

        /// <summary>
        /// Gets or sets the column-count value.
        /// </summary>
        [DomName("columnCount")]
        string ColumnCount { get; set; }

        /// <summary>
        /// Gets or sets the column-fill value.
        /// </summary>
        [DomName("columnFill")]
        string ColumnFill { get; set; }

        /// <summary>
        /// Gets or sets the column-gap value.
        /// </summary>
        [DomName("columnGap")]
        string ColumnGap { get; set; }

        /// <summary>
        /// Gets or sets the column-rule value.
        /// </summary>
        [DomName("columnRule")]
        string ColumnRule { get; set; }

        /// <summary>
        /// Gets or sets the column-rule-color value.
        /// </summary>
        [DomName("columnRuleColor")]
        string ColumnRuleColor { get; set; }

        /// <summary>
        /// Gets or sets the column-rule-style value.
        /// </summary>
        [DomName("columnRuleStyle")]
        string ColumnRuleStyle { get; set; }

        /// <summary>
        /// Gets or sets the column-rule-width value.
        /// </summary>
        [DomName("columnRuleWidth")]
        string ColumnRuleWidth { get; set; }

        /// <summary>
        /// Gets or sets the columnsv
        /// </summary>
        [DomName("columns")]
        string Columns { get; set; }

        /// <summary>
        /// Gets or sets the column-span value.
        /// </summary>
        [DomName("columnSpan")]
        string ColumnSpan { get; set; }

        /// <summary>
        /// Gets or sets the column-width value.
        /// </summary>
        [DomName("columnWidth")]
        string ColumnWidth { get; set; }

        /// <summary>
        /// Gets or sets the content value.
        /// </summary>
        [DomName("content")]
        string Content { get; set; }

        /// <summary>
        /// Gets or sets the counter-increment value.
        /// </summary>
        [DomName("counterIncrement")]
        string CounterIncrement { get; set; }
        /// <summary>
        /// Gets or sets the counter-reset value.
        /// </summary>
        [DomName("counterReset")]
        string CounterReset { get; set; }

        /// <summary>
        /// Gets or sets the cursor value.
        /// </summary>
        [DomName("cursor")]
        string Cursor { get; set; }

        /// <summary>
        /// Gets or sets the direction value.
        /// </summary>
        [DomName("direction")]
        string Direction { get; set; }

        /// <summary>
        /// Gets or sets the display value.
        /// </summary>
        [DomName("display")]
        string Display { get; set; }

        /// <summary>
        /// Gets or sets the dominant-baseline value.
        /// </summary>
        [DomName("dominantBaseline")]
        string DominantBaseline { get; set; }

        /// <summary>
        /// Gets or sets the empty-cells value.
        /// </summary>
        [DomName("emptyCells")]
        string EmptyCells { get; set; }

        /// <summary>
        /// Gets or sets the enable-background value.
        /// </summary>
        [DomName("enableBackground")]
        string EnableBackground { get; set; }

        /// <summary>
        /// Gets or sets the fill value.
        /// </summary>
        [DomName("fill")]
        string Fill { get; set; }

        /// <summary>
        /// Gets or sets the fill-opacity value.
        /// </summary>
        [DomName("fillOpacity")]
        string FillOpacity { get; set; }

        /// <summary>
        /// Gets or sets the fill-rule value.
        /// </summary>
        [DomName("fillRule")]
        string FillRule { get; set; }

        /// <summary>
        /// Gets or sets the filter value.
        /// </summary>
        [DomName("filter")]
        string Filter { get; set; }

        /// <summary>
        /// Gets or sets the flex value.
        /// </summary>
        [DomName("flex")]
        string Flex { get; set; }

        /// <summary>
        /// Gets or sets the flex-basis value.
        /// </summary>
        [DomName("flexBasis")]
        string FlexBasis { get; set; }

        /// <summary>
        /// Gets or sets the flex-direction value.
        /// </summary>
        [DomName("flexDirection")]
        string FlexDirection { get; set; }

        /// <summary>
        /// Gets or sets the flex-flow value.
        /// </summary>
        [DomName("flexFlow")]
        string FlexFlow { get; set; }

        /// <summary>
        /// Gets or sets the flex-grow value.
        /// </summary>
        [DomName("flexGrow")]
        string FlexGrow { get; set; }

        /// <summary>
        /// Gets or sets the flex-shrink value. 
        /// </summary>
        [DomName("flexShrink")]
        string FlexShrink { get; set; }

        /// <summary>
        /// Gets or sets the flex-wrap value.
        /// </summary>
        [DomName("flexWrap")]
        string FlexWrap { get; set; }

        /// <summary>
        /// Gets or sets the float value.
        /// </summary>
        [DomName("cssFloat")]
        string Float { get; set; }

        /// <summary>
        /// Gets or sets the font value.
        /// </summary>
        [DomName("font")]
        string Font { get; set; }

        /// <summary>
        /// Gets or sets the font-family value.
        /// </summary>
        [DomName("fontFamily")]
        string FontFamily { get; set; }

        /// <summary>
        /// Gets or sets the font-feature-settings value.
        /// </summary>
        [DomName("fontFeatureSettings")]
        string FontFeatureSettings { get; set; }

        /// <summary>
        /// Gets or sets the font-size value.
        /// </summary>
        [DomName("fontSize")]
        string FontSize { get; set; }

        /// <summary>
        /// Gets or sets the font-size-adjust value.
        /// </summary>
        [DomName("fontSizeAdjust")]
        string FontSizeAdjust { get; set; }

        /// <summary>
        /// Gets or sets the font-stretch value.
        /// </summary>
        [DomName("fontStretch")]
        string FontStretch { get; set; }

        /// <summary>
        /// Gets or sets the font-style value.
        /// </summary>
        [DomName("fontStyle")]
        string FontStyle { get; set; }

        /// <summary>
        /// Gets or sets the font-variant value.
        /// </summary>
        [DomName("fontVariant")]
        string FontVariant { get; set; }

        /// <summary>
        /// Gets or sets the font-weight value.
        /// </summary>
        [DomName("fontWeight")]
        string FontWeight { get; set; }

        /// <summary>
        /// Gets or sets the glyph-orientation-horizontal value.
        /// </summary>
        [DomName("glyphOrientationHorizontal")]
        string GlyphOrientationHorizontal { get; set; }

        /// <summary>
        /// Gets or sets the glyph-orientation-vertical value.
        /// </summary>
        [DomName("glyphOrientationVertical")]
        string GlyphOrientationVertical { get; set; }

        /// <summary>
        /// Gets or sets the height value.
        /// </summary>
        [DomName("height")]
        Length Height { get; set; }

        /// <summary>
        /// Gets or sets the ime-mode value.
        /// </summary>
        [DomName("imeMode")]
        string ImeMode { get; set; }

        /// <summary>
        /// Gets or sets the justify-content value.
        /// </summary>
        [DomName("justifyContent")]
        string JustifyContent { get; set; }

        /// <summary>
        /// Gets or sets the layout-grid value.
        /// </summary>
        [DomName("layoutGrid")]
        string LayoutGrid { get; set; }

        /// <summary>
        /// Gets or sets the layout-grid-char value.
        /// </summary>
        [DomName("layoutGridChar")]
        string LayoutGridChar { get; set; }

        /// <summary>
        /// Gets or sets the layout-grid-line value.
        /// </summary>
        [DomName("layoutGridLine")]
        string LayoutGridLine { get; set; }

        /// <summary>
        /// Gets or sets the layout-grid-mode value.
        /// </summary>
        [DomName("layoutGridMode")]
        string LayoutGridMode { get; set; }

        /// <summary>
        /// Gets or sets the layout-grid-type value.
        /// </summary>
        [DomName("layoutGridType")]
        string LayoutGridType { get; set; }

        /// <summary>
        /// Gets or sets the left value.
        /// </summary>
        [DomName("left")]
        string Left { get; set; }

        /// <summary>
        /// Gets or sets the letter-spacing value.
        /// </summary>
        [DomName("letterSpacing")]
        string LetterSpacing { get; set; }

        /// <summary>
        /// Gets or sets the line-height value.
        /// </summary>
        [DomName("lineHeight")]
        string LineHeight { get; set; }

        /// <summary>
        /// Gets or sets the list-style value.
        /// </summary>
        [DomName("listStyle")]
        string ListStyle { get; set; }

        /// <summary>
        /// Gets or sets the list-style-image value.
        /// </summary>
        [DomName("listStyleImage")]
        string ListStyleImage { get; set; }

        /// <summary>
        /// Gets or sets the list-style-position value.
        /// </summary>
        [DomName("listStylePosition")]
        string ListStylePosition { get; set; }

        /// <summary>
        /// Gets or sets the list-style-type value.
        /// </summary>
        [DomName("listStyleType")]
        string ListStyleType { get; set; }

        /// <summary>
        /// Gets or sets the margin value.
        /// </summary>
        [DomName("margin")]
        Length Margin { get; set; }

        /// <summary>
        /// Gets or sets the margin-bottom value.
        /// </summary>
        [DomName("marginBottom")]
        Length MarginBottom { get; set; }

        /// <summary>
        /// Gets or sets the margin-left value.
        /// </summary>
        [DomName("marginLeft")]
        Length MarginLeft { get; set; }

        /// <summary>
        /// Gets or sets the margin-right value.
        /// </summary>
        [DomName("marginRight")]
        Length MarginRight { get; set; }

        /// <summary>
        /// Gets or sets the margin-top value.
        /// </summary>
        [DomName("marginTop")]
        Length MarginTop { get; set; }

        /// <summary>
        /// Gets or sets the marker value.
        /// </summary>
        [DomName("marker")]
        string Marker { get; set; }

        /// <summary>
        /// Gets or sets the marker-end value.
        /// </summary>
        [DomName("markerEnd")]
        string MarkerEnd { get; set; }

        /// <summary>
        /// Gets or sets the marker-mid value.
        /// </summary>
        [DomName("markerMid")]
        string MarkerMid { get; set; }

        /// <summary>
        /// Gets or sets the marker-start value.
        /// </summary>
        [DomName("markerStart")]
        string MarkerStart { get; set; }

        /// <summary>
        /// Gets or sets the mask value.
        /// </summary>
        [DomName("mask")]
        string Mask { get; set; }

        /// <summary>
        /// Gets or sets the max-height value.
        /// </summary>
        [DomName("maxHeight")]
        Length MaxHeight { get; set; }

        /// <summary>
        /// Gets or sets the max-width value.
        /// </summary>
        [DomName("maxWidth")]
        Length MaxWidth { get; set; }

        /// <summary>
        /// Gets or sets the min-height value.
        /// </summary>
        [DomName("minHeight")]
        Length MinHeight { get; set; }

        /// <summary>
        /// Gets or sets the min-width value.
        /// </summary>
        [DomName("minWidth")]
        Length MinWidth { get; set; }

        /// <summary>
        /// Gets or sets the opacity value.
        /// </summary>
        [DomName("opacity")]
        string Opacity { get; set; }

        /// <summary>
        /// Gets or sets the order value.
        /// </summary>
        [DomName("order")]
        string Order { get; set; }

        /// <summary>
        /// Gets or sets the orphans value.
        /// </summary>
        [DomName("orphans")]
        string Orphans { get; set; }

        /// <summary>
        /// Gets or sets the outline value.
        /// </summary>
        [DomName("outline")]
        string Outline { get; set; }

        /// <summary>
        /// Gets or sets the outline-color value.
        /// </summary>
        [DomName("outlineColor")]
        string OutlineColor { get; set; }

        /// <summary>
        /// Gets or sets the outline-style value.
        /// </summary>
        [DomName("outlineStyle")]
        string OutlineStyle { get; set; }

        /// <summary>
        /// Gets or sets the outline-width value.
        /// </summary>
        [DomName("outlineWidth")]
        string OutlineWidth { get; set; }

        /// <summary>
        /// Gets or sets the overflow value.
        /// </summary>
        [DomName("overflow")]
        string Overflow { get; set; }

        /// <summary>
        /// Gets or sets the overflow-x value.
        /// </summary>
        [DomName("overflowX")]
        string OverflowX { get; set; }

        /// <summary>
        /// Gets or sets the overflow-y value.
        /// </summary>
        [DomName("overflowY")]
        string OverflowY { get; set; }

		/// <summary>
		/// Gets or sets the overflow-wrap value.
		/// </summary>
		[DomName("overflowWrap")]
		string OverflowWrap { get; set; }

		/// <summary>
		/// Gets or sets the padding value.
		/// </summary>
		[DomName("padding")]
        Length Padding { get; set; }

        /// <summary>
        /// Gets or sets the padding-bottom value.
        /// </summary>
        [DomName("paddingBottom")]
        Length PaddingBottom { get; set; }

        /// <summary>
        /// Gets or sets the padding-left value.
        /// </summary>
        [DomName("paddingLeft")]
        Length PaddingLeft { get; set; }

        /// <summary>
        /// Gets or sets the padding-right value.
        /// </summary>
        [DomName("paddingRight")]
        Length PaddingRight { get; set; }

        /// <summary>
        /// Gets or sets the padding-top value.
        /// </summary>
        [DomName("paddingTop")]
        Length PaddingTop { get; set; }

        /// <summary>
        /// Gets or sets the page-break-after value.
        /// </summary>
        [DomName("pageBreakAfter")]
        string PageBreakAfter { get; set; }

        /// <summary>
        /// Gets or sets the page-break-before value.
        /// </summary>
        [DomName("pageBreakBefore")]
        string PageBreakBefore { get; set; }

        /// <summary>
        /// Gets or sets the page-break-inside value.
        /// </summary>
        [DomName("pageBreakInside")]
        string PageBreakInside { get; set; }

        /// <summary>
        /// Gets or sets the perspective value.
        /// </summary>
        [DomName("perspective")]
        string Perspective { get; set; }

        /// <summary>
        /// Gets or sets the perspective-origin value.
        /// </summary>
        [DomName("perspectiveOrigin")]
        string PerspectiveOrigin { get; set; }

        /// <summary>
        /// Gets or sets the pointer-events value.
        /// </summary>
        [DomName("pointerEvents")]
        string PointerEvents { get; set; }

        /// <summary>
        /// Gets or sets the position value.
        /// </summary>
        [DomName("position")]
        string Position { get; set; }

        /// <summary>
        /// Gets or sets the quotes value.
        /// </summary>
        [DomName("quotes")]
        string Quotes { get; set; }

        /// <summary>
        /// Gets or sets the right value.
        /// </summary>
        [DomName("right")]
        string Right { get; set; }

        /// <summary>
        /// Gets or sets the ruby-align value.
        /// </summary>
        [DomName("rubyAlign")]
        string RubyAlign { get; set; }

        /// <summary>
        /// Gets or sets the ruby-overhang value.
        /// </summary>
        [DomName("rubyOverhang")]
        string RubyOverhang { get; set; }

        /// <summary>
        /// Gets or sets the ruby-position value.
        /// </summary>
        [DomName("rubyPosition")]
        string RubyPosition { get; set; }

        /// <summary>
        /// Gets or sets the scrollbar3d-light-color value.
        /// </summary>
        [DomName("scrollbar3dLightColor")]
        string Scrollbar3dLightColor { get; set; }

        /// <summary>
        /// Gets or sets the scrollbar-arrow-color value.
        /// </summary>
        [DomName("scrollbarArrowColor")]
        string ScrollbarArrowColor { get; set; }

        /// <summary>
        /// Gets or sets the scrollbar-dark-shadow-color value.
        /// </summary>
        [DomName("scrollbarDarkShadowColor")]
        string ScrollbarDarkShadowColor { get; set; }

        /// <summary>
        /// Gets or sets the scrollbar-face-color value.
        /// </summary>
        [DomName("scrollbarFaceColor")]
        string ScrollbarFaceColor { get; set; }

        /// <summary>
        /// Gets or sets the scrollbar-highlight-color value.
        /// </summary>
        [DomName("scrollbarHighlightColor")]
        string ScrollbarHighlightColor { get; set; }

        /// <summary>
        /// Gets or sets the scrollbar-shadow-color value.
        /// </summary>
        [DomName("scrollbarShadowColor")]
        string ScrollbarShadowColor { get; set; }

        /// <summary>
        /// Gets or sets the scrollbar-track-color value.
        /// </summary>
        [DomName("scrollbarTrackColor")]
        string ScrollbarTrackColor { get; set; }

        /// <summary>
        /// Gets or sets the stroke value.
        /// </summary>
        [DomName("stroke")]
        string Stroke { get; set; }

        /// <summary>
        /// Gets or sets the stroke-dasharray value.
        /// </summary>
        [DomName("strokeDasharray")]
        string StrokeDasharray { get; set; }

        /// <summary>
        /// Gets or sets the stroke-dashoffset value.
        /// </summary>
        [DomName("strokeDashoffset")]
        string StrokeDashoffset { get; set; }

        /// <summary>
        /// Gets or sets the stroke-linecap value.
        /// </summary>
        [DomName("strokeLinecap")]
        string StrokeLinecap { get; set; }

        /// <summary>
        /// Gets or sets the stroke-line-join value.
        /// </summary>
        [DomName("strokeLinejoin")]
        string StrokeLinejoin { get; set; }

        /// <summary>
        /// Gets or sets the stroke-miterlimit value.
        /// </summary>
        [DomName("strokeMiterlimit")]
        string StrokeMiterlimit { get; set; }

        /// <summary>
        /// Gets or sets the stroke-opacity value.
        /// </summary>
        [DomName("strokeOpacity")]
        string StrokeOpacity { get; set; }

        /// <summary>
        /// Gets or sets the stroke-width value.
        /// </summary>
        [DomName("strokeWidth")]
        string StrokeWidth { get; set; }
        /// <summary>
        /// Gets or sets the table-layout value.
        /// </summary>
        [DomName("tableLayout")]
        string TableLayout { get; set; }

        /// <summary>
        /// Gets or sets the text-align value.
        /// </summary>
        [DomName("textAlign")]
        string TextAlign { get; set; }

        /// <summary>
        /// Gets or sets the text-align-last value.
        /// </summary>
        [DomName("textAlignLast")]
        string TextAlignLast { get; set; }

        /// <summary>
        /// Gets or sets the text-anchor value.
        /// </summary>
        [DomName("textAnchor")]
        string TextAnchor { get; set; }

        /// <summary>
        /// Gets or sets the text-autospace value.
        /// </summary>
        [DomName("textAutospace")]
        string TextAutospace { get; set; }

        /// <summary>
        /// Gets or sets the text-decoration value.
        /// </summary>
        [DomName("textDecoration")]
        string TextDecoration { get; set; }

        /// <summary>
        /// Gets or sets the text-indent value.
        /// </summary>
        [DomName("textIndent")]
        string TextIndent { get; set; }

        /// <summary>
        /// Gets or sets the text-justify value.
        /// </summary>
        [DomName("textJustify")]
        string TextJustify { get; set; }

        /// <summary>
        /// Gets or sets the text-overflow value.
        /// </summary>
        [DomName("textOverflow")]
        string TextOverflow { get; set; }

        /// <summary>
        /// Gets or sets the text-shadow value.
        /// </summary>
        [DomName("textShadow")]
        string TextShadow { get; set; }

        /// <summary>
        /// Gets or sets the text-transform value.
        /// </summary>
        [DomName("textTransform")]
        string TextTransform { get; set; }

        /// <summary>
        /// Gets or sets the text-underline-position value.
        /// </summary>
        [DomName("textUnderlinePosition")]
        string TextUnderlinePosition { get; set; }

        /// <summary>
        /// Gets or sets the top value.
        /// </summary>
        [DomName("top")]
        string Top { get; set; }

        /// <summary>
        /// Gets or sets the transform value.
        /// </summary>
        [DomName("transform")]
        string Transform { get; set; }

        /// <summary>
        /// Gets or sets the transform-origin value.
        /// </summary>
        [DomName("transformOrigin")]
        string TransformOrigin { get; set; }

        /// <summary>
        /// Gets or sets the transform-style value.
        /// </summary>
        [DomName("transformStyle")]
        string TransformStyle { get; set; }

        /// <summary>
        /// Gets or sets the  value.
        /// </summary>
        [DomName("transition")]
        string Transition { get; set; }

        /// <summary>
        /// Gets or sets the transition-delay value.
        /// </summary>
        [DomName("transitionDelay")]
        string TransitionDelay { get; set; }

        /// <summary>
        /// Gets or sets the transition-duration value.
        /// </summary>
        [DomName("transitionDuration")]
        string TransitionDuration { get; set; }

        /// <summary>
        /// Gets or sets the transition-property value.
        /// </summary>
        [DomName("transitionProperty")]
        string TransitionProperty { get; set; }

        /// <summary>
        /// Gets or sets the transition-timing-function value.
        /// </summary>
        [DomName("transitionTimingFunction")]
        string TransitionTimingFunction { get; set; }

        /// <summary>
        /// Gets or sets the unicode-bidi value.
        /// </summary>
        [DomName("unicodeBidi")]
        string UnicodeBidi { get; set; }

        /// <summary>
        /// Gets or sets the vertical-align value.
        /// </summary>
        [DomName("verticalAlign")]
        string VerticalAlign { get; set; }

        /// <summary>
        /// Gets or sets the visibility value.
        /// </summary>
        [DomName("visibility")]
        string Visibility { get; set; }

        /// <summary>
        /// Gets or sets the white-space value.
        /// </summary>
        [DomName("whiteSpace")]
        string WhiteSpace { get; set; }

        /// <summary>
        /// Gets or sets the widows value.
        /// </summary>
        [DomName("widows")]
        string Widows { get; set; }

        /// <summary>
        /// Gets or sets the width value.
        /// </summary>
        [DomName("width")]
        Length Width { get; set; }

        /// <summary>
        /// Gets or sets the word-break value.
        /// </summary>
        [DomName("wordBreak")]
        string WordBreak { get; set; }

        /// <summary>
        /// Gets or sets the word-spacing value.
        /// </summary>
        [DomName("wordSpacing")]
        string WordSpacing { get; set; }

        /// <summary>
        /// Gets or sets the writing-mode value.
        /// </summary>
        [DomName("writingMode")]
        string WritingMode { get; set; }

        /// <summary>
        /// Gets or sets the z-index value.
        /// </summary>
        [DomName("zIndex")]
        string ZIndex { get; set; }

        /// <summary>
        /// Gets or sets the zoom value.
        /// </summary>
        [DomName("zoom")]
        string Zoom { get; set; }

        #endregion
    }
}
