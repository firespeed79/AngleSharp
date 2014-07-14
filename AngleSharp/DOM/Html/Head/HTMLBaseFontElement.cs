﻿namespace AngleSharp.DOM.Html
{
    using System;

    /// <summary>
    /// Represents an HTML basefont element.
    /// Deprecated in HTML 4.01.
    /// </summary>
    [DomHistorical]
    sealed class HTMLBaseFontElement : HTMLElement
    {
        internal HTMLBaseFontElement()
        {
            _name = Tags.BaseFont;
        }

        /// <summary>
        /// Gets if the node is in the special category.
        /// </summary>
        protected internal override Boolean IsSpecial
        {
            get { return true; }
        }
    }
}
