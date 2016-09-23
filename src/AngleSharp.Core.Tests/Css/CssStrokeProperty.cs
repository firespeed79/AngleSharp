﻿namespace AngleSharp.Core.Tests.Css
{
	using AngleSharp.Css.Values;
	using Dom.Css;
	using NUnit.Framework;
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;
	using System.Threading.Tasks;

	[TestFixture]
	public class CssStrokePropertyTests : CssConstructionFunctions
	{
		[Test]
		public void CssStrokeColorRedLegal()
		{
			var snippet = "stroke: red";
			var property = ParseDeclaration(snippet);
			Assert.AreEqual("stroke", property.Name);
			Assert.IsFalse(property.IsImportant);
			Assert.IsInstanceOf<CssStrokeProperty>(property);
			var concrete = (CssStrokeProperty)property;
			Assert.IsFalse(concrete.IsInherited);
			Assert.IsTrue(concrete.HasValue);
			Assert.AreEqual("rgb(255, 0, 0)", concrete.Value);
		}

		[Test]
		public void CssStrokeColorHexLegal()
		{
			var snippet = "stroke: #0F0";
			var property = ParseDeclaration(snippet);
			Assert.AreEqual("stroke", property.Name);
			Assert.IsFalse(property.IsImportant);
			Assert.IsInstanceOf<CssStrokeProperty>(property);
			var concrete = (CssStrokeProperty)property;
			Assert.IsFalse(concrete.IsInherited);
			Assert.IsTrue(concrete.HasValue);
			Assert.AreEqual("rgb(0, 255, 0)", concrete.Value);
		}

		[Test]
		public void CssStrokeColorRgbaLegal()
		{
			var snippet = "stroke: rgba(1, 1, 1, 0)";
			var property = ParseDeclaration(snippet);
			Assert.AreEqual("stroke", property.Name);
			Assert.IsFalse(property.IsImportant);
			Assert.IsInstanceOf<CssStrokeProperty>(property);
			var concrete = (CssStrokeProperty)property;
			Assert.IsFalse(concrete.IsInherited);
			Assert.IsTrue(concrete.HasValue);
			Assert.AreEqual("rgba(1, 1, 1, 0)", concrete.Value);
		}

		[Test]
		public void CssStrokeColorRgbLegal()
		{
			var snippet = "stroke: rgb(1, 255, 100)";
			var property = ParseDeclaration(snippet);
			Assert.AreEqual("stroke", property.Name);
			Assert.IsFalse(property.IsImportant);
			Assert.IsInstanceOf<CssStrokeProperty>(property);
			var concrete = (CssStrokeProperty)property;
			Assert.IsFalse(concrete.IsInherited);
			Assert.IsTrue(concrete.HasValue);
			Assert.AreEqual("rgb(1, 255, 100)", concrete.Value);
		}

		[Test]
		public void CssStrokeNoneLegal()
		{
			var snippet = "stroke: none";
			var property = ParseDeclaration(snippet);
			Assert.AreEqual("stroke", property.Name);
			Assert.IsFalse(property.IsImportant);
			Assert.IsInstanceOf<CssStrokeProperty>(property);
			var concrete = (CssStrokeProperty)property;
			Assert.IsFalse(concrete.IsInherited);
			Assert.IsTrue(concrete.HasValue);
			Assert.AreEqual("none", concrete.Value);
		}

		[Test]
		public void CssStrokeColorRedRedIllegal()
		{
			var snippet = "stroke: red red";
			var property = ParseDeclaration(snippet);
			Assert.AreEqual("stroke", property.Name);
			Assert.IsFalse(property.IsImportant);
			Assert.IsInstanceOf<CssStrokeProperty>(property);
			var concrete = (CssStrokeProperty)property;
			Assert.IsFalse(concrete.IsInherited);
			Assert.IsFalse(concrete.HasValue);
		}

		[Test]
		public void CssStrokeUrlLegal()
		{
			var snippet = "stroke: url(#linear)";
			var property = ParseDeclaration(snippet);
			Assert.AreEqual("stroke", property.Name);
			Assert.IsFalse(property.IsImportant);
			Assert.IsInstanceOf<CssStrokeProperty>(property);
			var concrete = (CssStrokeProperty)property;
			Assert.IsFalse(concrete.IsInherited);
			Assert.IsTrue(concrete.HasValue);
			Assert.AreEqual("url(\"#linear\")", concrete.Value);
		}


		[Test]
		public void CssStrokeDasharrayNumberNumberLegal()
		{
			var snippet = "stroke-dasharray: 5 5";
			var property = ParseDeclaration(snippet);
			Assert.AreEqual("stroke-dasharray", property.Name);
			Assert.IsFalse(property.IsImportant);
			Assert.IsInstanceOf<CssStrokeDasharrayProperty>(property);
			var concrete = (CssStrokeDasharrayProperty)property;
			Assert.IsFalse(concrete.IsInherited);
			Assert.IsTrue(concrete.HasValue);
			Assert.AreEqual("5 5", concrete.Value);
		}

		[Test]
		public void CssStrokeDasharrayLengthLengthLegal()
		{
			var snippet = "stroke-dasharray: 5px 5em";
			var property = ParseDeclaration(snippet);
			Assert.AreEqual("stroke-dasharray", property.Name);
			Assert.IsFalse(property.IsImportant);
			Assert.IsInstanceOf<CssStrokeDasharrayProperty>(property);
			var concrete = (CssStrokeDasharrayProperty)property;
			Assert.IsFalse(concrete.IsInherited);
			Assert.IsTrue(concrete.HasValue);
			Assert.AreEqual("5px 5em", concrete.Value);
		}

		[Test]
		public void CssStrokeDasharrayManyLegal()
		{
			var snippet = "stroke-dasharray: 1px 2em 3vh 4vw 5 6";
			var property = ParseDeclaration(snippet);
			Assert.AreEqual("stroke-dasharray", property.Name);
			Assert.IsFalse(property.IsImportant);
			Assert.IsInstanceOf<CssStrokeDasharrayProperty>(property);
			var concrete = (CssStrokeDasharrayProperty)property;
			Assert.IsFalse(concrete.IsInherited);
			Assert.IsTrue(concrete.HasValue);
			Assert.AreEqual("1px 2em 3vh 4vw 5 6", concrete.Value);
		}

		[Test]
		public void CssStrokeDasharrayNoneLegal()
		{
			var snippet = "stroke-dasharray: none";
			var property = ParseDeclaration(snippet);
			Assert.AreEqual("stroke-dasharray", property.Name);
			Assert.IsFalse(property.IsImportant);
			Assert.IsInstanceOf<CssStrokeDasharrayProperty>(property);
			var concrete = (CssStrokeDasharrayProperty)property;
			Assert.IsFalse(concrete.IsInherited);
			Assert.IsTrue(concrete.HasValue);
			Assert.AreEqual("none", concrete.Value);
		}
	}
}
