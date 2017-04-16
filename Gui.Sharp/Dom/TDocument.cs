﻿using AngleSharp;
using AngleSharp.Parser.Html;
using AngleSharp.Services.Default;
using Gui.Sharp.Dom.Interfaces;
using System;

namespace Gui.Sharp.Dom
{
    public class TDocument : ITDocument
    {
        public ITElement Body { get; set; }

        public TDocument()  {}

        public void Parse(string html)
        {
            var config = new Configuration().WithCss();
            var parser = new HtmlParser(config ?? Configuration.Default);
            var document = parser.Parse(html);

            var factory = new TElementFactory();
            Body = factory.Create(document.Body);
        }

        public void Render()
        {
            throw new NotImplementedException();
        }
    }
}
