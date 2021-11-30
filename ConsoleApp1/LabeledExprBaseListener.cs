//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.9.3
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from .\LabeledExpr.g4 by ANTLR 4.9.3

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419


using Antlr4.Runtime.Misc;
using IErrorNode = Antlr4.Runtime.Tree.IErrorNode;
using ITerminalNode = Antlr4.Runtime.Tree.ITerminalNode;
using IToken = Antlr4.Runtime.IToken;
using ParserRuleContext = Antlr4.Runtime.ParserRuleContext;

/// <summary>
/// This class provides an empty implementation of <see cref="ILabeledExprListener"/>,
/// which can be extended to create a listener which only needs to handle a subset
/// of the available methods.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.9.3")]
[System.Diagnostics.DebuggerNonUserCode]
[System.CLSCompliant(false)]
public partial class LabeledExprBaseListener : ILabeledExprListener {
	/// <summary>
	/// Enter a parse tree produced by <see cref="LabeledExprParser.prog"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterProg([NotNull] LabeledExprParser.ProgContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="LabeledExprParser.prog"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitProg([NotNull] LabeledExprParser.ProgContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>printExpr</c>
	/// labeled alternative in <see cref="LabeledExprParser.stat"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterPrintExpr([NotNull] LabeledExprParser.PrintExprContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>printExpr</c>
	/// labeled alternative in <see cref="LabeledExprParser.stat"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitPrintExpr([NotNull] LabeledExprParser.PrintExprContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>assign</c>
	/// labeled alternative in <see cref="LabeledExprParser.stat"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAssign([NotNull] LabeledExprParser.AssignContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>assign</c>
	/// labeled alternative in <see cref="LabeledExprParser.stat"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAssign([NotNull] LabeledExprParser.AssignContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>blank</c>
	/// labeled alternative in <see cref="LabeledExprParser.stat"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterBlank([NotNull] LabeledExprParser.BlankContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>blank</c>
	/// labeled alternative in <see cref="LabeledExprParser.stat"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitBlank([NotNull] LabeledExprParser.BlankContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>clear</c>
	/// labeled alternative in <see cref="LabeledExprParser.stat"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterClear([NotNull] LabeledExprParser.ClearContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>clear</c>
	/// labeled alternative in <see cref="LabeledExprParser.stat"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitClear([NotNull] LabeledExprParser.ClearContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>parens</c>
	/// labeled alternative in <see cref="LabeledExprParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterParens([NotNull] LabeledExprParser.ParensContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>parens</c>
	/// labeled alternative in <see cref="LabeledExprParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitParens([NotNull] LabeledExprParser.ParensContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>MulDiv</c>
	/// labeled alternative in <see cref="LabeledExprParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterMulDiv([NotNull] LabeledExprParser.MulDivContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>MulDiv</c>
	/// labeled alternative in <see cref="LabeledExprParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitMulDiv([NotNull] LabeledExprParser.MulDivContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>AddSub</c>
	/// labeled alternative in <see cref="LabeledExprParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAddSub([NotNull] LabeledExprParser.AddSubContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>AddSub</c>
	/// labeled alternative in <see cref="LabeledExprParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAddSub([NotNull] LabeledExprParser.AddSubContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>id</c>
	/// labeled alternative in <see cref="LabeledExprParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterId([NotNull] LabeledExprParser.IdContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>id</c>
	/// labeled alternative in <see cref="LabeledExprParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitId([NotNull] LabeledExprParser.IdContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>int</c>
	/// labeled alternative in <see cref="LabeledExprParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterInt([NotNull] LabeledExprParser.IntContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>int</c>
	/// labeled alternative in <see cref="LabeledExprParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitInt([NotNull] LabeledExprParser.IntContext context) { }

	/// <inheritdoc/>
	/// <remarks>The default implementation does nothing.</remarks>
	public virtual void EnterEveryRule([NotNull] ParserRuleContext context) { }
	/// <inheritdoc/>
	/// <remarks>The default implementation does nothing.</remarks>
	public virtual void ExitEveryRule([NotNull] ParserRuleContext context) { }
	/// <inheritdoc/>
	/// <remarks>The default implementation does nothing.</remarks>
	public virtual void VisitTerminal([NotNull] ITerminalNode node) { }
	/// <inheritdoc/>
	/// <remarks>The default implementation does nothing.</remarks>
	public virtual void VisitErrorNode([NotNull] IErrorNode node) { }
}
