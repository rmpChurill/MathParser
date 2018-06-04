﻿using Matheparser.Values;

namespace Matheparser.Parsing.PostFixExpressions
{
    public interface IPostFixExpression
    {
        int ArgCount
        {
            get;
        }

        PostFixExpressionType Type
        {
            get;
        }

        IValue Eval(IValue[] operands);
    }
}
