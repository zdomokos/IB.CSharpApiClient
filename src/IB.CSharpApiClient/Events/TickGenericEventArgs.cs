﻿namespace IB.CSharpApiClient.Events
{
    public class TickGenericEventArgs : MarketDataEventArgs
    {
        public TickGenericEventArgs(int requestId, int field, double value) : base(requestId, field)
        {
            Value = value;
        }

        public double Value { get; }

        public override string ToString()
        {
            return $"{base.ToString()}, {nameof(Value)}: {Value}";
        }
    }
}