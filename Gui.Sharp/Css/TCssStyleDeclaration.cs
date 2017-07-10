using AngleSharp.Css.Values;
using Gui.Sharp.Css.Interfaces;
using System.ComponentModel;

namespace Gui.Sharp.Css
{
    /// <summary>
    /// Represents a single CSS declaration block.
    /// </summary>
    public class TCssStyleDeclaration : ICssStyleDeclaration, INotifyPropertyChanged
    {
        #region CSS Properties

        /// <summary>
        /// Gets or sets the accelerator value.
        /// </summary>
        public string Accelerator { get; set; }

        /// <summary>
        /// Gets or sets the align-content value.
        /// </summary>
        public string AlignContent { get; set; }

        /// <summary>
        /// Gets or sets the align-items value.
        /// </summary>
        public string AlignItems { get; set; }

        /// <summary>
        /// Gets or sets the alignment-baseline value.
        /// </summary>
        public string AlignmentBaseline { get; set; }

        /// <summary>
        /// Gets or sets the align-self value.
        /// </summary>
        public string AlignSelf { get; set; }

        /// <summary>
        /// Gets or sets the animation value.
        /// </summary>
        public string Animation { get; set; }

        /// <summary>
        /// Gets or sets the animation-delay value.
        /// </summary>
        public string AnimationDelay { get; set; }

        /// <summary>
        /// Gets or sets the animation-direction value.
        /// </summary>
        public string AnimationDirection { get; set; }

        /// <summary>
        /// Gets or sets the animation-duration value.
        /// </summary>
        public string AnimationDuration { get; set; }

        /// <summary>
        /// Gets or sets the animation-fill-mode value.
        /// </summary>
        public string AnimationFillMode { get; set; }

        /// <summary>
        /// Gets or sets the animation-iteration-count value.
        /// </summary>
        public string AnimationIterationCount { get; set; }

        /// <summary>
        /// Gets or sets the animation-name value.
        /// </summary>
        public string AnimationName { get; set; }

        /// <summary>
        /// Gets or sets the animation-play-state value.
        /// </summary>
        public string AnimationPlayState { get; set; }

        /// <summary>
        /// Gets or sets the animation-timing-function value.
        /// </summary>
        public string AnimationTimingFunction { get; set; }

        /// <summary>
        /// Gets or sets the backface-visibility value.
        /// </summary>
        public string BackfaceVisibility { get; set; }

        /// <summary>
        /// Gets or sets the background value.
        /// </summary>
        public string Background { get; set; }

        /// <summary>
        /// Gets or sets the background-attachment value.
        /// </summary>
        public string BackgroundAttachment { get; set; }

        /// <summary>
        /// Gets or sets the background-clip value.
        /// </summary>
        public string BackgroundClip { get; set; }

        /// <summary>
        /// Gets or sets the background-color value.
        /// </summary>
        public OpenTK.Color BackgroundColor { get; set; }

        /// <summary>
        /// Gets or sets the background-image value.
        /// </summary>
        public string BackgroundImage { get; set; }

        /// <summary>
        /// Gets or sets the background-origin value.
        /// </summary>
        public string BackgroundOrigin { get; set; }

        /// <summary>
        /// Gets or sets the background-position value.
        /// </summary>
        public string BackgroundPosition { get; set; }

        /// <summary>
        /// Gets or sets the background-position-x value.
        /// </summary>
        public string BackgroundPositionX { get; set; }

        /// <summary>
        /// Gets or sets the background-position-y value.
        /// </summary>
        public string BackgroundPositionY { get; set; }

        /// <summary>
        /// Gets or sets the background-repeat value.
        /// </summary>
        public string BackgroundRepeat { get; set; }

        /// <summary>
        /// Gets or sets the background-size value.
        /// </summary>
        public string BackgroundSize { get; set; }

        /// <summary>
        /// Gets or sets the baseline-shift value.
        /// </summary>
        public string BaselineShift { get; set; }

        /// <summary>
        /// Gets or sets the behavior value.
        /// </summary>
        public string Behavior { get; set; }

        /// <summary>
        /// Gets or sets the border value.
        /// </summary>
        public string Border { get; set; }
  
        /// <summary>
        /// Gets or sets the bottom value.
        /// </summary>
        public string Bottom { get; set; }

        /// <summary>
        /// Gets or sets the border-bottom value.
        /// </summary>
        public string BorderBottom { get; set; }

        /// <summary>
        /// Gets or sets the border-bottom-color value.
        /// </summary>
        public string BorderBottomColor { get; set; }

        /// <summary>
        /// Gets or sets the border-bottom-left-radius value.
        /// </summary>
        public string BorderBottomLeftRadius { get; set; }

        /// <summary>
        /// Gets or sets the border-bottom-right-radius value.
        /// </summary>
        public string BorderBottomRightRadius { get; set; }

        /// <summary>
        /// Gets or sets the border-bottom-style value.
        /// </summary>
        public string BorderBottomStyle { get; set; }

        /// <summary>
        /// Gets or sets the border-bottom-width value.
        /// </summary>
        public string BorderBottomWidth { get; set; }

        /// <summary>
        /// Gets or sets the border-collapse value.
        /// </summary>
        public string BorderCollapse { get; set; }

        /// <summary>
        /// Gets or sets the border-color value.
        /// </summary>
        public string BorderColor { get; set; }

        /// <summary>
        /// Gets or sets the border-image value.
        /// </summary>
        public string BorderImage { get; set; }

        /// <summary>
        /// Gets or sets the border-image-outset value.
        /// </summary>
        public string BorderImageOutset { get; set; }

        /// <summary>
        /// Gets or sets the border-image-repeat value.
        /// </summary>
        public string BorderImageRepeat { get; set; }

        /// <summary>
        /// Gets or sets the border-image-slice value.
        /// </summary>
        public string BorderImageSlice { get; set; }

        /// <summary>
        /// Gets or sets the border-image-source value.
        /// </summary>
        public string BorderImageSource { get; set; }

        /// <summary>
        /// Gets or sets the border-image-width value.
        /// </summary>
        public string BorderImageWidth { get; set; }

        /// <summary>
        /// Gets or sets the border-left value.
        /// </summary>
        public string BorderLeft { get; set; }

        /// <summary>
        /// Gets or sets the border-left-color value.
        /// </summary>
        public string BorderLeftColor { get; set; }

        /// <summary>
        /// Gets or sets the border-left-style value.
        /// </summary>
        public string BorderLeftStyle { get; set; }

        /// <summary>
        /// Gets or sets the border-left-width value.
        /// </summary>
        public string BorderLeftWidth { get; set; }

        /// <summary>
        /// Gets or sets the border-radius value.
        /// </summary>
        public string BorderRadius { get; set; }

        /// <summary>
        /// Gets or sets the border-right value.
        /// </summary>
        public string BorderRight { get; set; }

        /// <summary>
        /// Gets or sets the border-right-color value.
        /// </summary>
        public string BorderRightColor { get; set; }

        /// <summary>
        /// Gets or sets the border-right-style value.
        /// </summary>
        public string BorderRightStyle { get; set; }

        /// <summary>
        /// Gets or sets the border-right-width value.
        /// </summary>
        public string BorderRightWidth { get; set; }

        /// <summary>
        /// Gets or sets the border-spacing value.
        /// </summary>
        public string BorderSpacing { get; set; }

        /// <summary>
        /// Gets or sets the border-style value.
        /// </summary>
        public string BorderStyle { get; set; }

        /// <summary>
        /// Gets or sets the border-top value.
        /// </summary>
        public string BorderTop { get; set; }

        /// <summary>
        /// Gets or sets the border-top-color value.
        /// </summary>
        public string BorderTopColor { get; set; }

        /// <summary>
        /// Gets or sets the border-top-left-radius value.
        /// </summary>
        public string BorderTopLeftRadius { get; set; }

        /// <summary>
        /// Gets or sets the border-top-right-radius value.
        /// </summary>
        public string BorderTopRightRadius { get; set; }

        /// <summary>
        /// Gets or sets the border-top-style value.
        /// </summary>
        public string BorderTopStyle { get; set; }

        /// <summary>
        /// Gets or sets the border-top-width value.
        /// </summary>
        public string BorderTopWidth { get; set; }

        /// <summary>
        /// Gets or sets the border-width value.
        /// </summary>
        public string BorderWidth { get; set; }

        /// <summary>
        /// Gets or sets the box-shadow value.
        /// </summary>
        public string BoxShadow { get; set; }

        /// <summary>
        /// Gets or sets the box-sizing value.
        /// </summary>
        public string BoxSizing { get; set; }

        /// <summary>
        /// Gets or sets the break-after value.
        /// </summary>
        public string BreakAfter { get; set; }

        /// <summary>
        /// Gets or sets the break-before value.
        /// </summary>
        public string BreakBefore { get; set; }

        /// <summary>
        /// Gets or sets the break-inside value.
        /// </summary>
        public string BreakInside { get; set; }

        /// <summary>
        /// Gets or sets the caption-side value.
        /// </summary>
        public string CaptionSide { get; set; }

        /// <summary>
        /// Gets or sets the clear value.
        /// </summary>
        public string Clear { get; set; }

        /// <summary>
        /// Gets or sets the clip value.
        /// </summary>
        public string Clip { get; set; }

        /// <summary>
        /// Gets or sets the clip-bottom value.
        /// </summary>
        public string ClipBottom { get; set; }

        /// <summary>
        /// Gets or sets the clip-left value.
        /// </summary>
        public string ClipLeft { get; set; }

        /// <summary>
        /// Gets or sets the clip-path value.
        /// </summary>
        public string ClipPath { get; set; }

        /// <summary>
        /// Gets or sets the clip-right value.
        /// </summary>
        public string ClipRight { get; set; }

        /// <summary>
        /// Gets or sets the clip-rule value.
        /// </summary>
        public string ClipRule { get; set; }

        /// <summary>
        /// Gets or sets the clip-top value.
        /// </summary>
        public string ClipTop { get; set; }

        /// <summary>
        /// Gets or sets the color value.
        /// </summary>
        public OpenTK.Color Color { get; set; }

        /// <summary>
        /// Gets or sets the color-interpolation-filters value.
        /// </summary>
        public string ColorInterpolationFilters { get; set; }

        /// <summary>
        /// Gets or sets the column-count value.
        /// </summary>
        public string ColumnCount { get; set; }

        /// <summary>
        /// Gets or sets the column-fill value.
        /// </summary>
        public string ColumnFill { get; set; }

        /// <summary>
        /// Gets or sets the column-gap value.
        /// </summary>
        public string ColumnGap { get; set; }

        /// <summary>
        /// Gets or sets the column-rule value.
        /// </summary>
        public string ColumnRule { get; set; }

        /// <summary>
        /// Gets or sets the column-rule-color value.
        /// </summary>
        public string ColumnRuleColor { get; set; }

        /// <summary>
        /// Gets or sets the column-rule-style value.
        /// </summary>
        public string ColumnRuleStyle { get; set; }

        /// <summary>
        /// Gets or sets the column-rule-width value.
        /// </summary>
        public string ColumnRuleWidth { get; set; }

        /// <summary>
        /// Gets or sets the columnsv
        /// </summary>
        public string Columns { get; set; }

        /// <summary>
        /// Gets or sets the column-span value.
        /// </summary>
        public string ColumnSpan { get; set; }

        /// <summary>
        /// Gets or sets the column-width value.
        /// </summary>
        public string ColumnWidth { get; set; }

        /// <summary>
        /// Gets or sets the content value.
        /// </summary>
        public string Content { get; set; }

        /// <summary>
        /// Gets or sets the counter-increment value.
        /// </summary>
        public string CounterIncrement { get; set; }

        /// <summary>
        /// Gets or sets the counter-reset value.
        /// </summary>
        public string CounterReset { get; set; }

        /// <summary>
        /// Gets or sets the cursor value.
        /// </summary>
        public string Cursor { get; set; }

        /// <summary>
        /// Gets or sets the direction value.
        /// </summary>
        public string Direction { get; set; }

        /// <summary>
        /// Gets or sets the display value.
        /// </summary>
        public string Display { get; set; }

        /// <summary>
        /// Gets or sets the dominant-baseline value.
        /// </summary>
        public string DominantBaseline { get; set; }

        /// <summary>
        /// Gets or sets the empty-cells value.
        /// </summary>
        public string EmptyCells { get; set; }

        /// <summary>
        /// Gets or sets the enable-background value.
        /// </summary>
        public string EnableBackground { get; set; }

        /// <summary>
        /// Gets or sets the fill value.
        /// </summary>
        public string Fill { get; set; }

        /// <summary>
        /// Gets or sets the fill-opacity value.
        /// </summary>
        public string FillOpacity { get; set; }

        /// <summary>
        /// Gets or sets the fill-rule value.
        /// </summary>
        public string FillRule { get; set; }

        /// <summary>
        /// Gets or sets the filter value.
        /// </summary>
        public string Filter { get; set; }

        /// <summary>
        /// Gets or sets the flex value.
        /// </summary>
        public string Flex { get; set; }

        /// <summary>
        /// Gets or sets the flex-basis value.
        /// </summary>
        public string FlexBasis { get; set; }

        /// <summary>
        /// Gets or sets the flex-direction value.
        /// </summary>
        public string FlexDirection { get; set; }

        /// <summary>
        /// Gets or sets the flex-flow value.
        /// </summary>
        public string FlexFlow { get; set; }

        /// <summary>
        /// Gets or sets the flex-grow value.
        /// </summary>
        public string FlexGrow { get; set; }

        /// <summary>
        /// Gets or sets the flex-shrink value. 
        /// </summary>
        public string FlexShrink { get; set; }

        /// <summary>
        /// Gets or sets the flex-wrap value.
        /// </summary>
        public string FlexWrap { get; set; }

        /// <summary>
        /// Gets or sets the float value.
        /// </summary>
        public string Float { get; set; }

        /// <summary>
        /// Gets or sets the font value.
        /// </summary>
        public string Font { get; set; }

        /// <summary>
        /// Gets or sets the font-family value.
        /// </summary>
        public string FontFamily { get; set; }

        /// <summary>
        /// Gets or sets the font-feature-settings value.
        /// </summary>
        public string FontFeatureSettings { get; set; }

        /// <summary>
        /// Gets or sets the font-size value.
        /// </summary>
        public string FontSize { get; set; }

        /// <summary>
        /// Gets or sets the font-size-adjust value.
        /// </summary>
        public string FontSizeAdjust { get; set; }

        /// <summary>
        /// Gets or sets the font-stretch value.
        /// </summary>
        public string FontStretch { get; set; }

        /// <summary>
        /// Gets or sets the font-style value.
        /// </summary>
        public string FontStyle { get; set; }

        /// <summary>
        /// Gets or sets the font-variant value.
        /// </summary>
        public string FontVariant { get; set; }

        /// <summary>
        /// Gets or sets the font-weight value.
        /// </summary>
        public string FontWeight { get; set; }

        /// <summary>
        /// Gets or sets the glyph-orientation-horizontal value.
        /// </summary>
        public string GlyphOrientationHorizontal { get; set; }

        /// <summary>
        /// Gets or sets the glyph-orientation-vertical value.
        /// </summary>
        public string GlyphOrientationVertical { get; set; }

        /// <summary>
        /// Gets or sets the height value.
        /// </summary>
        public Length Height { get; set; }

        /// <summary>
        /// Gets or sets the ime-mode value.
        /// </summary>
        public string ImeMode { get; set; }

        /// <summary>
        /// Gets or sets the justify-content value.
        /// </summary>
        public string JustifyContent { get; set; }

        /// <summary>
        /// Gets or sets the layout-grid value.
        /// </summary>
        public string LayoutGrid { get; set; }

        /// <summary>
        /// Gets or sets the layout-grid-char value.
        /// </summary>
        public string LayoutGridChar { get; set; }

        /// <summary>
        /// Gets or sets the layout-grid-line value.
        /// </summary>
        public string LayoutGridLine { get; set; }

        /// <summary>
        /// Gets or sets the layout-grid-mode value.
        /// </summary>
        public string LayoutGridMode { get; set; }

        /// <summary>
        /// Gets or sets the layout-grid-type value.
        /// </summary>
        public string LayoutGridType { get; set; }

        /// <summary>
        /// Gets or sets the left value.
        /// </summary>
        public string Left { get; set; }

        /// <summary>
        /// Gets or sets the letter-spacing value.
        /// </summary>
        public string LetterSpacing { get; set; }

        /// <summary>
        /// Gets or sets the line-height value.
        /// </summary>
        public string LineHeight { get; set; }

        /// <summary>
        /// Gets or sets the list-style value.
        /// </summary>
        public string ListStyle { get; set; }

        /// <summary>
        /// Gets or sets the list-style-image value.
        /// </summary>
        public string ListStyleImage { get; set; }

        /// <summary>
        /// Gets or sets the list-style-position value.
        /// </summary>
        public string ListStylePosition { get; set; }

        /// <summary>
        /// Gets or sets the list-style-type value.
        /// </summary>
        public string ListStyleType { get; set; }

        /// <summary>
        /// Gets or sets the margin value.
        /// </summary>
        public Length Margin { get; set; }

        /// <summary>
        /// Gets or sets the margin-bottom value.
        /// </summary>
        public Length MarginBottom { get; set; }

        /// <summary>
        /// Gets or sets the margin-left value.
        /// </summary>
        public Length MarginLeft { get; set; }

        /// <summary>
        /// Gets or sets the margin-right value.
        /// </summary>
        public Length MarginRight { get; set; }

        /// <summary>
        /// Gets or sets the margin-top value.
        /// </summary>
        public Length MarginTop { get; set; }

        /// <summary>
        /// Gets or sets the marker value.
        /// </summary>
        public string Marker { get; set; }

        /// <summary>
        /// Gets or sets the marker-end value.
        /// </summary>
        public string MarkerEnd { get; set; }

        /// <summary>
        /// Gets or sets the marker-mid value.
        /// </summary>
        public string MarkerMid { get; set; }

        /// <summary>
        /// Gets or sets the marker-start value.
        /// </summary>
        public string MarkerStart { get; set; }

        /// <summary>
        /// Gets or sets the mask value.
        /// </summary>
        public string Mask { get; set; }

        /// <summary>
        /// Gets or sets the max-height value.
        /// </summary>
        public Length MaxHeight { get; set; }

        /// <summary>
        /// Gets or sets the max-width value.
        /// </summary>
        public Length MaxWidth { get; set; }

        /// <summary>
        /// Gets or sets the min-height value.
        /// </summary>
        public Length MinHeight { get; set; }

        /// <summary>
        /// Gets or sets the min-width value.
        /// </summary>
        public Length MinWidth { get; set; }

        /// <summary>
        /// Gets or sets the opacity value.
        /// </summary>
        public string Opacity { get; set; }

        /// <summary>
        /// Gets or sets the order value.
        /// </summary>
        public string Order { get; set; }

        /// <summary>
        /// Gets or sets the orphans value.
        /// </summary>
        public string Orphans { get; set; }

        /// <summary>
        /// Gets or sets the outline value.
        /// </summary>
        public string Outline { get; set; }

        /// <summary>
        /// Gets or sets the outline-color value.
        /// </summary>
        public string OutlineColor { get; set; }

        /// <summary>
        /// Gets or sets the outline-style value.
        /// </summary>
        public string OutlineStyle { get; set; }

        /// <summary>
        /// Gets or sets the outline-width value.
        /// </summary>
        public string OutlineWidth { get; set; }

        /// <summary>
        /// Gets or sets the overflow value.
        /// </summary>
        public string Overflow { get; set; }

        /// <summary>
        /// Gets or sets the overflow-x value.
        /// </summary>
        public string OverflowX { get; set; }

        /// <summary>
        /// Gets or sets the overflow-y value.
        /// </summary>
        public string OverflowY { get; set; }

        /// <summary>
        /// Gets or sets the overflow-wrap value.
        /// </summary>
        public string OverflowWrap { get; set; }

		/// <summary>
		/// Gets or sets the padding value.
		/// </summary>
        public Length Padding { get; set; }

        /// <summary>
        /// Gets or sets the padding-bottom value.
        /// </summary>
        public Length PaddingBottom { get; set; }

        /// <summary>
        /// Gets or sets the padding-left value.
        /// </summary>
        public Length PaddingLeft { get; set; }

        /// <summary>
        /// Gets or sets the padding-right value.
        /// </summary>
        public Length PaddingRight { get; set; }

        /// <summary>
        /// Gets or sets the padding-top value.
        /// </summary>
        public Length PaddingTop { get; set; }

        /// <summary>
        /// Gets or sets the page-break-after value.
        /// </summary>
        public string PageBreakAfter { get; set; }

        /// <summary>
        /// Gets or sets the page-break-before value.
        /// </summary>
        public string PageBreakBefore { get; set; }

        /// <summary>
        /// Gets or sets the page-break-inside value.
        /// </summary>
        public string PageBreakInside { get; set; }

        /// <summary>
        /// Gets or sets the perspective value.
        /// </summary>
        public string Perspective { get; set; }

        /// <summary>
        /// Gets or sets the perspective-origin value.
        /// </summary>
        public string PerspectiveOrigin { get; set; }

        /// <summary>
        /// Gets or sets the pointer-events value.
        /// </summary>
        public string PointerEvents { get; set; }

        /// <summary>
        /// Gets or sets the position value.
        /// </summary>
        public string Position { get; set; }

        /// <summary>
        /// Gets or sets the quotes value.
        /// </summary>
        public string Quotes { get; set; }

        /// <summary>
        /// Gets or sets the right value.
        /// </summary>
        public string Right { get; set; }

        /// <summary>
        /// Gets or sets the ruby-align value.
        /// </summary>
        public string RubyAlign { get; set; }

        /// <summary>
        /// Gets or sets the ruby-overhang value.
        /// </summary>
        public string RubyOverhang { get; set; }

        /// <summary>
        /// Gets or sets the ruby-position value.
        /// </summary>
        public string RubyPosition { get; set; }

        /// <summary>
        /// Gets or sets the scrollbar3d-light-color value.
        /// </summary>
        public string Scrollbar3dLightColor { get; set; }

        /// <summary>
        /// Gets or sets the scrollbar-arrow-color value.
        /// </summary>
        public string ScrollbarArrowColor { get; set; }

        /// <summary>
        /// Gets or sets the scrollbar-dark-shadow-color value.
        /// </summary>
        public string ScrollbarDarkShadowColor { get; set; }

        /// <summary>
        /// Gets or sets the scrollbar-face-color value.
        /// </summary>
        public string ScrollbarFaceColor { get; set; }

        /// <summary>
        /// Gets or sets the scrollbar-highlight-color value.
        /// </summary>
        public string ScrollbarHighlightColor { get; set; }

        /// <summary>
        /// Gets or sets the scrollbar-shadow-color value.
        /// </summary>
        public string ScrollbarShadowColor { get; set; }

        /// <summary>
        /// Gets or sets the scrollbar-track-color value.
        /// </summary>
        public string ScrollbarTrackColor { get; set; }

        /// <summary>
        /// Gets or sets the stroke value.
        /// </summary>
        public string Stroke { get; set; }

        /// <summary>
        /// Gets or sets the stroke-dasharray value.
        /// </summary>
        public string StrokeDasharray { get; set; }

        /// <summary>
        /// Gets or sets the stroke-dashoffset value.
        /// </summary>
        public string StrokeDashoffset { get; set; }

        /// <summary>
        /// Gets or sets the stroke-linecap value.
        /// </summary>
        public string StrokeLinecap { get; set; }

        /// <summary>
        /// Gets or sets the stroke-line-join value.
        /// </summary>
        public string StrokeLinejoin { get; set; }

        /// <summary>
        /// Gets or sets the stroke-miterlimit value.
        /// </summary>
        public string StrokeMiterlimit { get; set; }

        /// <summary>
        /// Gets or sets the stroke-opacity value.
        /// </summary>
        public string StrokeOpacity { get; set; }

        /// <summary>
        /// Gets or sets the stroke-width value.
        /// </summary>
        public string StrokeWidth { get; set; }
        /// <summary>
        /// Gets or sets the table-layout value.
        /// </summary>
        public string TableLayout { get; set; }

        /// <summary>
        /// Gets or sets the text-align value.
        /// </summary>
        public string TextAlign { get; set; }

        /// <summary>
        /// Gets or sets the text-align-last value.
        /// </summary>
        public string TextAlignLast { get; set; }

        /// <summary>
        /// Gets or sets the text-anchor value.
        /// </summary>
        public string TextAnchor { get; set; }

        /// <summary>
        /// Gets or sets the text-autospace value.
        /// </summary>
        public string TextAutospace { get; set; }

        /// <summary>
        /// Gets or sets the text-decoration value.
        /// </summary>
        public string TextDecoration { get; set; }

        /// <summary>
        /// Gets or sets the text-indent value.
        /// </summary>
        public string TextIndent { get; set; }

        /// <summary>
        /// Gets or sets the text-justify value.
        /// </summary>
        public string TextJustify { get; set; }

        /// <summary>
        /// Gets or sets the text-overflow value.
        /// </summary>
        public string TextOverflow { get; set; }

        /// <summary>
        /// Gets or sets the text-shadow value.
        /// </summary>
        public string TextShadow { get; set; }

        /// <summary>
        /// Gets or sets the text-transform value.
        /// </summary>
        public string TextTransform { get; set; }

        /// <summary>
        /// Gets or sets the text-underline-position value.
        /// </summary>
        public string TextUnderlinePosition { get; set; }

        /// <summary>
        /// Gets or sets the top value.
        /// </summary>
        public string Top { get; set; }

        /// <summary>
        /// Gets or sets the transform value.
        /// </summary>
        public string Transform { get; set; }

        /// <summary>
        /// Gets or sets the transform-origin value.
        /// </summary>
        public string TransformOrigin { get; set; }

        /// <summary>
        /// Gets or sets the transform-style value.
        /// </summary>
        public string TransformStyle { get; set; }

        /// <summary>
        /// Gets or sets the  value.
        /// </summary>
        public string Transition { get; set; }

        /// <summary>
        /// Gets or sets the transition-delay value.
        /// </summary>
        public string TransitionDelay { get; set; }

        /// <summary>
        /// Gets or sets the transition-duration value.
        /// </summary>
        public string TransitionDuration { get; set; }

        /// <summary>
        /// Gets or sets the transition-property value.
        /// </summary>
        public string TransitionProperty { get; set; }

        /// <summary>
        /// Gets or sets the transition-timing-function value.
        /// </summary>
        public string TransitionTimingFunction { get; set; }

        /// <summary>
        /// Gets or sets the unicode-bidi value.
        /// </summary>
        public string UnicodeBidi { get; set; }

        /// <summary>
        /// Gets or sets the vertical-align value.
        /// </summary>
        public string VerticalAlign { get; set; }

        /// <summary>
        /// Gets or sets the visibility value.
        /// </summary>
        public string Visibility { get; set; }

        /// <summary>
        /// Gets or sets the white-space value.
        /// </summary>
        public string WhiteSpace { get; set; }

        /// <summary>
        /// Gets or sets the widows value.
        /// </summary>
        public string Widows { get; set; }

        /// <summary>
        /// Gets or sets the width value.
        /// </summary>
        public Length Width { get; set; }

        /// <summary>
        /// Gets or sets the word-break value.
        /// </summary>
        public string WordBreak { get; set; }

        /// <summary>
        /// Gets or sets the word-spacing value.
        /// </summary>
        public string WordSpacing { get; set; }

        /// <summary>
        /// Gets or sets the writing-mode value.
        /// </summary>
        public string WritingMode { get; set; }

        /// <summary>
        /// Gets or sets the z-index value.
        /// </summary>
        public string ZIndex { get; set; }

        /// <summary>
        /// Gets or sets the zoom value.
        /// </summary>
        public string Zoom { get; set; }

        #endregion

        #region INotifyPropertyChanged

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void NotifyPropertyChanged([System.Runtime.CompilerServices.CallerMemberName] string propertyName = null)
        {
            var handler = PropertyChanged;

            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        #endregion
    }
}
