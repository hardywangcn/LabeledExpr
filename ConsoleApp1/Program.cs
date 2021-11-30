using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

using Antlr4.Runtime;
using Antlr4.Runtime.Tree;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            StreamReader input_src;
            if (args.Length > 0)
            { 
                input_src = File.OpenText(args[0]);
            }
            else
            {
                Console.WriteLine("Enter expressions to evaluate");
                input_src = new StreamReader(Console.OpenStandardInput(), Console.InputEncoding);
            }
            */

            //AntlrInputStream input_stream = new AntlrInputStream(input_src);
            
            string txt = "a=3; b=9; a+b;";
            AntlrInputStream input_stream = new AntlrInputStream(txt);
            LabeledExprLexer lexer = new LabeledExprLexer(input_stream);
            CommonTokenStream tokens = new CommonTokenStream(lexer);
            LabeledExprParser parser = new LabeledExprParser(tokens);

            IParseTree tree = parser.prog(); // parse

            EvalVisitor eval = new EvalVisitor();
            eval.Visit(tree);
            
            Console.ReadLine();
        }
    }
}
