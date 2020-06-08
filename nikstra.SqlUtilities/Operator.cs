using System;
using System.Collections.Generic;
using System.Text;

namespace nikstra.SqlUtilities
{
    public class Operator
    {
        public string Value { get; }
        private Operator(string @operator) =>
            Value = @operator;

        public static Operator Equal { get; } = new Operator("=");
        public static Operator GreaterThan { get; } = new Operator(">");
        public static Operator GreaterThanOrEqual { get; } = new Operator(">=");
        public static Operator LessThan { get; } = new Operator("<");
        public static Operator LessThanOrEqual { get; } = new Operator("<=");
        public static Operator NotEqual { get; } = new Operator("!=");

        public override string ToString() =>
            Value;

        public static implicit operator string(Operator @operator) =>
            @operator.Value;
    }
}
