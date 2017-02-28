﻿// Copyright (c) Allan Hardy. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.

using System;
using App.Metrics.Abstractions.MetricTypes;
using App.Metrics.Core.Abstractions;

namespace App.Metrics.Gauge.Abstractions
{
    public interface IBuildGaugeMetrics
    {
        IGaugeMetric Build(Func<double> valueProvider);

        IGaugeMetric Build(Func<IMetricValueProvider<double>> valueProvider);

        IGaugeMetric Build();

        IGaugeMetric Build<T>(Func<T> builder)
            where T : IGaugeMetric;
    }
}