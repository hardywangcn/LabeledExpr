using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class EvalVisitor : LabeledExprBaseVisitor<int>
    {
        private Hashtable memory = new Hashtable();


        public override int VisitAssign(LabeledExprParser.AssignContext ctx)
        {
            String id = ctx.ID().GetText();  // id is left-hand side of '='
            int value = Visit(ctx.expr());   // compute value of expression on right
            memory.Add(id, value);           // store it in our memory
            return value;
        }

        /** expr NEWLINE */

        public override int VisitPrintExpr(LabeledExprParser.PrintExprContext ctx)
        {
            int value = Visit(ctx.expr()); // evaluate the expr child
            Console.Out.WriteLine(value);         // print the result
            return 0;                          // return dummy value
        }

        /** clear NEWLINE */
        public override int VisitClear(LabeledExprParser.ClearContext ctx)
        {
            memory.Clear();                    // clear the memory map
            return 0;                          // return dummy value
        }

        /** INT */
        public override int VisitInt(LabeledExprParser.IntContext ctx)
        {
            return int.Parse(ctx.INT().GetText());
        }

        /** ID */
        
    public override int VisitId(LabeledExprParser.IdContext ctx)
        {
            String id = ctx.ID().GetText();
            if (memory.ContainsKey(id)) return (int)memory[id];
            return 0;
        }

        /** expr op=('*'|'/') expr */
        public override  int VisitMulDiv(LabeledExprParser.MulDivContext ctx)
        {
            int left = Visit(ctx.expr(0));  // get value of left subexpression
            int right = Visit(ctx.expr(1)); // get value of right subexpression
            if (ctx.op.Type == LabeledExprParser.MUL) return left * right;
            return left / right; // must be DIV
        }

        /** expr op=('+'|'-') expr */
        public override int VisitAddSub(LabeledExprParser.AddSubContext ctx)
        {
            int left = Visit(ctx.expr(0));  // get value of left subexpression
            int right = Visit(ctx.expr(1)); // get value of right subexpression
            if (ctx.op.Type == LabeledExprParser.ADD) return left + right;
            return left - right; // must be SUB
        }

        /** '(' expr ')' */
        public override int VisitParens(LabeledExprParser.ParensContext ctx)
        {
            return Visit(ctx.expr()); // return child expr's value
        }
    }
}
