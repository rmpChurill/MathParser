﻿using System.Diagnostics;
using Matheparser.Parsing.PostFixExpressions.Exceptions;
using Matheparser.Values;

namespace Matheparser.Parsing.PostFixExpressions.Binary.Arithmetic
{
    [DebuggerDisplay("Operator %")]
    public sealed class ModExpression : BinaryOperatorExpressionBase
    {
        internal override IValue EvalNumber(double double1, double double2)
        {
            return new DoubleValue(double1 % double2);
        }

        internal override IValue EvalString(string string1, string string2)
        {
            throw new IllegalOperationException();
        }

        public override string ToString()
        {
            return "Op %";
        }
    }
}