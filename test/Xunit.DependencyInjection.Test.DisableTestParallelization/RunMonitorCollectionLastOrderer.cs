﻿using Xunit.Abstractions;

namespace Xunit.DependencyInjection.Test.DisableTestParallelization;

public class RunMonitorCollectionLastOrderer : ITestCollectionOrderer
{
    public IEnumerable<ITestCollection> OrderTestCollections(IEnumerable<ITestCollection> testCollections) =>
        testCollections.OrderBy(c => c.DisplayName.EndsWith("MonitorTest"));
}
